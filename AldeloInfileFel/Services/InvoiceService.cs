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
        private readonly TokenService tokenService;
        private readonly Configuration _configuration;

        public InvoiceService(OrderRepository orderRepository, TokenService tokenService)
        {
            _orderRepository = orderRepository;
            _configuration = ConfigurationService.LoadConfiguration();
            this.tokenService = tokenService;
        }

        public InvoiceGenerationResponse GenerateInvoice(ConsumerData consumerData)
        {
            try
            {
                var details = _orderRepository.GetOrderDetails(consumerData.OrderId);
                var tipAmount = _orderRepository.GetTipAmount(consumerData.OrderId);

                var invoiceTotal = details.Select(detail => detail.Quantity * detail.UnitPrice)
                    .Sum();

                if ((invoiceTotal > 2500) && "CF".Equals(consumerData.TaxId, StringComparison.InvariantCultureIgnoreCase))
                {
                    throw new Exception("El monto máximo permitido a facturar para un nit CF es de Q. 2,500.00");
                }

                var barDetails = details.Where(detail => detail.Bar);
                var restaurantDetails = details.Where(detail => !detail.Bar);

                var preRequest = BuildGenerationRequest(consumerData, barDetails, restaurantDetails, tipAmount);

                // Filter generation requests that have a total of 0
                var invoices = preRequest.Invoices
                        .Where(req => !NonValueGenerationRequest(req))
                        .ToList();

                var sanitizedRequest = new GenerationRequest
                {
                    Invoices = invoices
                };

                return AldeloFelClient.GenerateInvoiceRequest(sanitizedRequest);
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

        public string QueryId(string id)
        {
            try
            {
                var token = tokenService.GetToken();

                var response = InfileClient.IdQuery(token, id);

                if ((response == null) || (!response.Result))
                {
                    throw new Exception("No es posible consultar el CUI");
                }

                var idValue = response.Id;

                return idValue.Name;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }


        // ---------------------------------------------------------------------------------------------------------

        private GenerationRequest BuildGenerationRequest(ConsumerData consumerData, 
                                                         IEnumerable<OrderDetail> barDetails,
                                                         IEnumerable<OrderDetail> restaurantDetails,
                                                         double tipAmount)
        {
            return new GenerationRequest
            {
                Invoices = new List<InvoiceGenerationRequest>
                {
                    BuildInvoiceGenerationRequest(consumerData, "RESTAURANT", restaurantDetails, tipAmount),
                    BuildInvoiceGenerationRequest(consumerData, "BAR", barDetails, 0.00)
                }
            };
        }

        private InvoiceGenerationRequest BuildInvoiceGenerationRequest(ConsumerData consumerData, string type, IEnumerable<OrderDetail> details, double tipAmount)
        {
            var isItemizedTip = IsItemizedTip();

            if (isItemizedTip)
            {

                var detailsWithTip = tipAmount > 0 ? details.Append(BuildTipAsOrderDetail(tipAmount))
                    : details;

                return new InvoiceGenerationRequest()
                {
                    InvoiceType = type,
                    OrderId = consumerData.OrderId,
                    TaxId = consumerData.TaxId,
                    TaxIdType = consumerData.TaxIdType,
                    Name = consumerData.Name,
                    Email = consumerData.Email,
                    Details = BuildItemDetails(detailsWithTip)
                };
            }

            return new InvoiceGenerationRequest()
            {
                OrderId = consumerData.OrderId,
                TaxId = consumerData.TaxId,
                TaxIdType = consumerData.TaxIdType,
                Name = consumerData.Name,
                Email = consumerData.Email,
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

        private bool NonValueGenerationRequest(InvoiceGenerationRequest invoiceGenerationRequest)
        {
            var totalItems = invoiceGenerationRequest.Details
                .Select(detail => detail.UnitPrice * detail.Quantity)
                .Sum();

            return totalItems + invoiceGenerationRequest.TipAmount == 0;
        }

    }
}
