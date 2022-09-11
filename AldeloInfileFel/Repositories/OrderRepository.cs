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
        /*
        private const string OrderInformationQuery = "SELECT OrderTransactions.OrderID, OrderTransactions.MenuItemID as ItemID, " +
            "  OrderTransactions.MenuItemUnitPrice as UnitPrice, OrderTransactions.Quantity, " +
            "  OrderTransactions.DiscountAmount, OrderTransactions.DiscountTaxable," +
            "  MenuItems.MenuItemText as ItemText, MenuItems.MenuItemDescription as ItemDescription" +
            " FROM MenuItems " +
            "   INNER JOIN OrderTransactions ON MenuItems.MenuItemID = OrderTransactions.MenuItemID" +
            " WHERE OrderTransactions.OrderID = @Id";
        */

        /*
        private const string OrderInformationQuery = "SELECT OrderTransactions.OrderID, OrderTransactions.MenuItemID as ItemID, " +
            "  OrderTransactions.ExtendedPrice as UnitPrice, OrderTransactions.Quantity, " +
            "  (OrderTransactions.DiscountAmount / 100) as DiscountAmount, OrderTransactions.DiscountTaxable," +
            "  MenuItems.MenuItemText as ItemText, MenuItems.MenuItemDescription as ItemDescription" +
            " FROM MenuItems " +
            "   INNER JOIN OrderTransactions ON MenuItems.MenuItemID = OrderTransactions.MenuItemID" +
            " WHERE OrderTransactions.TransactionStatus = '1' AND OrderTransactions.OrderID = @Id"; */

        private const string OrderInformationQuery = "SELECT OrderTransactions.OrderID, OrderTransactions.MenuItemID as ItemID, " +
            "  OrderTransactions.MenuItemUnitPrice as UnitPrice, OrderTransactions.Quantity as Quantity, " +
            "  OrderTransactions.DiscountAmountUsed as DiscountAmount, " +
            "  MenuItems.MenuItemText as ItemText, MenuItems.MenuItemDescription as ItemDescription" +
            " FROM MenuItems " +
            "   INNER JOIN OrderTransactions ON MenuItems.MenuItemID = OrderTransactions.MenuItemID" +
            " WHERE OrderTransactions.TransactionStatus = '1' AND OrderTransactions.OrderID = @Id";


        private const string TipInformation = "SELECT OrderID, AmountPaid, EmployeeComp " +
            " FROM OrderPayments " +
            " WHERE OrderID = @Id";

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
                details = db.Query<OrderDetail>(OrderInformationQuery, new { Id = orderId })
                    .ToList();
            }

            return details;
        }

        public OrderPayment GetOrderPayment(long orderId)
        {
            OrderPayment orderPayment = null;
            using (IDbConnection db = new OleDbConnection(configuration.AldeloDbConnectionString))
            {
                orderPayment = db.QueryFirstOrDefault<OrderPayment>(TipInformation, new { Id = orderId });
            }

            return orderPayment;
        }

        public double GetTipAmount(long orderId)
        {
            var tip = 0.00;
            using (IDbConnection db = new OleDbConnection(configuration.AldeloDbConnectionString))
            {
                tip = db.QuerySingleOrDefault<double>(configuration.TipAmountQuery, new { Id = orderId });
            }

            return tip;
        }
    }
}
