using System;
using System.Collections.Generic;
using AldeloInfileFel.Client;
using AldeloInfileFel.Domain;
using AldeloInfileFel.Repositories;

namespace AldeloInfileFel.Services
{
    public class InvoiceService
    {
        private OrderRepository _orderRepository;

        public InvoiceService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public InvoiceGenerationResponse GenerateInvoice(long orderId, string taxId, string name, string email)
        {
            try
            {
                var details = _orderRepository.GetOrderDetails(orderId);
                var request = BuildRequest(orderId, taxId, name, email, details);

                return AldeloFelClient.GenerateInvoiceRequest(request);
            } 
            catch (Exception exception)
            {
                return BuildErrorResponse(exception);
            }
        }

        private InvoiceGenerationRequest BuildRequest(long orderId, string taxId, string name, string email, IEnumerable<OrderDetail> details)
        {
            return new InvoiceGenerationRequest()
            {
                OrderId = orderId,
                TaxId = taxId,
                Name = name,
                Email = email,
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
    }
}
