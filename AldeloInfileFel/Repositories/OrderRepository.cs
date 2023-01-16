using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using AldeloInfileFel.Domain;
using AldeloInfileFel.Services;
using Dapper;

namespace AldeloInfileFel.Repositories
{
    public class OrderRepository
    {
        private const string OrderInformationQuery = 
            
            " SELECT OrderTransactions.OrderID, OrderTransactions.MenuItemID as ItemID, " +
            "  OrderTransactions.MenuItemUnitPrice as UnitPrice, OrderTransactions.Quantity as Quantity, " +
            "  OrderTransactions.DiscountAmountUsed as DiscountAmount, MenuItems.Bar, " +
            "  MenuItems.MenuItemText as ItemText, MenuItems.MenuItemDescription as ItemDescription" +
            " FROM MenuItems " +
            "   INNER JOIN OrderTransactions ON MenuItems.MenuItemID = OrderTransactions.MenuItemID" +
            " WHERE OrderTransactions.TransactionStatus = '1' AND OrderTransactions.OrderID = @Id";

        private readonly Configuration configuration;

        public OrderRepository()
        {
            this.configuration = ConfigurationService.LoadConfiguration();
        }

        public IList<OrderDetail> GetOrderDetails(long orderId)
        {
            var details = new List<OrderDetail>();
            using (IDbConnection db = new OleDbConnection(configuration.AldeloDbConnectionString))
            {

                var query = string.IsNullOrEmpty(configuration.OrderInformationCustomQuery) 
                    ? OrderInformationQuery
                    : configuration.OrderInformationCustomQuery;

                details = db.Query<OrderDetail>(query, new { Id = orderId })
                    .ToList();
            }

            return details;
        }

        public double GetTipAmount(long orderId)
        {
            try
            {
                var tip = 0.00;
                using (IDbConnection db = new OleDbConnection(configuration.AldeloDbConnectionString))
                {
                    tip = db.QuerySingleOrDefault<double>(configuration.TipAmountQuery, new { Id = orderId });
                }

                return tip;
            } 
            catch (Exception)
            {
                return 0.00;
            }
        }
    }
}
