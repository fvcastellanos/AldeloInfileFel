using System;
using System.Collections.Generic;
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

                var request = BuildRequest(orderId, taxId, name, email, details, tipAmount);

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

        private InvoiceGenerationRequest BuildRequest(long orderId, string taxId, string name, string email, IEnumerable<OrderDetail> details, double tipAmount)
        {
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
            var items = new List<ItemDetail>();

            foreach (var detail in details)
            {
                var item = new ItemDetail()
                {
                    Quantity = detail.Quantity,
                    UnitPrice = detail.UnitPrice,
                    ItemText = detail.ItemText,
                    DiscountAmount = detail.DiscountAmount
                };

                items.Add(item);
            }

            return items;
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
    }
}
