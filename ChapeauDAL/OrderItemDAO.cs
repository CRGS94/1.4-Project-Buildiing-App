using System;
using System.Collections.Generic;
using System.Text;
using ChapeauModel;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class OrderItemDAO : BaseDao
    {
        public List<OrderItem> GetOrderItems(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderitem = new OrderItem()
                {
                    OrderItemID = (int)dr["order_ID"],
                    Order_Number = (int)dr["order_number"],
                    MenuItemID = (MenuItem)dr["menu_item_id"],
                    Quantity = (int)dr["quantity"],
                    Comment = (string)dr["comment"],
                    Order_Status = (OrderStatus)dr["status"],
                    Order_Time = (DateTime)dr["datetime"],
                    Table = (Table)dr["table_number"]
                };
                orderItems.Add(orderitem);
            }
            return orderItems;
        }
        
        // public List<OrderItem> GetAllOrderItems() {to be updated}
        //{
        //    List<OrderItem> orderItems = new List<OrderItem>();
        //    return orderItems;
        // }

        public void UpdateOrderItem(OrderItem orderItem, int newQuantity)
        {
            string query = $"UPDATE [Order_Item] SET order_quantity={newQuantity} WHERE order_quanity={orderItem.Quantity}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
