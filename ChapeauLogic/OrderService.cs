using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAL;
using System.Data.SqlClient;

namespace ChapeauLogic
{
    public class OrderService
    {
        OrderDAO ordersdb;

        private SqlConnection connection;

        public OrderService()
        {
            ordersdb = new OrderDAO();
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = ordersdb.GetAllOrders();
            return orders;
        }

        public void UpdateOrder(Order order, bool completed)
        {
            ordersdb.UpdateOrder(order, completed);
        }
    }
}
