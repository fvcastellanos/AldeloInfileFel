using System;
using System.Collections.Generic;
using System.Linq;
using AldeloInfileFel.Client;
using AldeloInfileFel.Domain;
using AldeloInfileFel.Repositories;

namespace AldeloInfileFel.Services
{
    public class InvoiceService
    {
        private const string DownStatus = "DOWN";
        private readonly OrderRepository _orderRepository;
        private readonly Configuration _configuration;

        public InvoiceService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
            _configuration = ConfigurationService.LoadConfiguration();
        }

        public InvoiceGenerationResponse GenerateInvoice(long orderId, string taxId, string name, string email)
        {
            try
            {
                var details = _orderRepository.GetOrderDetails(orderId);
                var tipAmount = _orderRepository.GetTipAmount(orderId);

                var barDetails = details.Where(detail => detail.Bar);
                var restaurantDetails = details.Where(detail => !detail.Bar);

                var request = BuildGenerationRequest(orderId, taxId, name, email, barDetails, restaurantDetails, tipAmount);

                return AldeloFelClient.GenerateInvoiceRequest(request);
            } 
            catch (Exception exception)
            {
                return BuildErrorResponse(exception);
            }
        }

        public ApiStatus GetApiStatus()
        {
            try
            {
                return AldeloFelClient.GetApiFelStatus();
            }
            catch 
            {
                return BuildApiStatusErrorResponse();
            }
        }

        public string QueryTaxId(string taxId)
        {
            try
            {
                return InfileClient.QueryTaxId(taxId);

            } catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // ---------------------------------------------------------------------------------------------------------

        private GenerationRequest BuildGenerationRequest(long orderId, 
                                                         string taxId, 
                                                         string name, 
                                                         string email, 
                                                         IEnumerable<OrderDetail> barDetails,
                                                         IEnumerable<OrderDetail> restaurantDetails,
                                                         double tipAmount)
        {
            return new GenerationRequest
            {
                Invoices = new List<InvoiceGenerationRequest>
                {
                    BuildInvoiceGenerationRequest(orderId, taxId, name, email, restaurantDetails, tipAmount),
                    BuildInvoiceGenerationRequest(orderId, taxId, name, email, barDetails, 0.00)
                }
            };
        }

        private InvoiceGenerationRequest BuildInvoiceGenerationRequest(long orderId, string taxId, string name, string email, IEnumerable<OrderDetail> details, double tipAmount)
        {
            var isItemizedTip = IsItemizedTip();

            if (isItemizedTip)
            {
                var detailsWithTip = details.Append(BuildTipAsOrderDetail(tipAmount));

                return new InvoiceGenerationRequest()
                {
                    OrderId = orderId,
                    TaxId = taxId,
                    Name = name,
                    Email = email,
                    Details = BuildItemDetails(detailsWithTip)
                };
            }

            return new InvoiceGenerationRequest()
            {
                OrderId = orderId,
                TaxId = taxId,
                Name = name,
                Email = email,
                TipAmount = tipAmount,
                Details = BuildItemDetails(details)
            };
        }

        private IEnumerable<ItemDetail> BuildItemDetails(IEnumerable<OrderDetail> details)
        {
            return details.Select(detail =>
            {
                return new ItemDetail()
                {
                    Quantity = detail.Quantity,
                    UnitPrice = detail.UnitPrice,
                    ItemText = detail.ItemText,
                    DiscountAmount = detail.DiscountAmount
                };

            }).ToList();
        }

        private OrderDetail BuildTipAsOrderDetail(double tipAmount)
        {
            return new OrderDetail
            {
                Quantity = 1,
                UnitPrice = tipAmount,
                ItemText = _configuration.TipDescription,
                DiscountAmount = 0
            };
        }

        private InvoiceGenerationResponse BuildErrorResponse(Exception exception)
        {
            return new InvoiceGenerationResponse()
            {
                Success = false,
                Errors = new List<string>()
                {
                    { exception.Message }
                }
            };
        }

        private ApiStatus BuildApiStatusErrorResponse()
        {
            return new ApiStatus()
            {
                Status = DownStatus,
                Components = new StatusComponents()
                {
                    InFile = new InFileStatus()
                    {
                        Status = DownStatus,
                        Details = new InfileDetails()
                        {
                            Signature = DownStatus,
                            Certificate = DownStatus
                        }
                    }
                }
            };
        }

        private bool IsItemizedTip()
        {
            if ((string.IsNullOrEmpty(_configuration.TipProcessingType))
                    || _configuration.TipProcessingType.Equals("Amend", StringComparison.InvariantCultureIgnoreCase))
            {
                return false;
            }

            return true;
        }
    }
}
