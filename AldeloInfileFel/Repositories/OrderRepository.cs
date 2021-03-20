using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using AldeloInfileFel.Domain;
using Dapper;

namespace AldeloInfileFel.Repositories
{
    public class OrderRepository
    {
        private const string OrderInformationQuery = "SELECT OrderTransactions.OrderID, OrderTransactions.MenuItemID as ItemID, " +
            "  OrderTransactions.MenuItemUnitPrice as UnitPrice, OrderTransactions.Quantity, " +
            "  OrderTransactions.DiscountAmount, OrderTransactions.DiscountTaxable," +
            "  MenuItems.MenuItemText as ItemText, MenuItems.MenuItemDescription as ItemDescription" +
            " FROM MenuItems " +
            "   INNER JOIN OrderTransactions ON MenuItems.MenuItemID = OrderTransactions.MenuItemID" +
            " WHERE OrderTransactions.OrderID = @Id";

        public IList<OrderDetail> GetOrderDetails(long orderId)
        {
            var details = new List<OrderDetail>();

            var connectionString = Environment.GetEnvironmentVariable("ALDELO_DB_CONNECTION_STRING");
            using (IDbConnection db = new OleDbConnection(connectionString))
            {
                details = db.Query<OrderDetail>(OrderInformationQuery, new { Id = orderId })
                    .ToList();
            }

            return details;
        }
    }
}
