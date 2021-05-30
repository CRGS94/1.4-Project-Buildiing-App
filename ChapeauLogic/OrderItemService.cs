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
    public class OrderItemService
    {
        OrderItemDAO orderitemsdb;

        public OrderItemService()
        {
            orderitemsdb = new OrderItemDAO();
        }

        public void UpdateOrderItem(OrderItem orderitem, int newQuantity)
        {
            orderitemsdb.UpdateOrderItem(orderitem, newQuantity);
        }
    }
}
