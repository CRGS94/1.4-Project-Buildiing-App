using System;
using System.Collections.Generic;
using System.Text;
using ChapeauModel;

namespace ChapeauModel
{
    public class OrderItem
    {
        public OrderItem(int orderItemID, int orderNumber, int menuitemID, int quantity, string comment, OrderStatus orderStatus, Table table, DateTime Ordertime)
        {
            OrderItemID = orderItemID;
            Order_Number = orderNumber;
            MenuItemID = menuitemID;
            Quantity = quantity;
            Comment = comment;
            Order_Status = orderStatus;
            Table = table;
            Order_Time = Ordertime;
        }


        public int OrderItemID { get; set; }
        public int Order_Number { get; set; }
        public int MenuItemID { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }

        public OrderStatus Order_Status { get; set; }

        public Table Table { get; set; }

        public DateTime Order_Time { get; set; }

    }
}
