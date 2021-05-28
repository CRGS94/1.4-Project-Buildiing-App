using System;
using System.Collections.Generic;
using System.Text;
using ChapeauModel;

namespace ChapeauModel
{
    public class OrderItem
    {
        // (will not be accessbile until menuitem is updated)
        public OrderItem(int orderItemID, int orderNumber, MenuItem menuItem, int quantity, string comment, OrderStatus orderStatus, DateTime Ordertime, Table tableNumber)
        {
            OrderItemID = orderItemID;
            Order_Number = orderNumber;
            MenuItem = menuItem;
            Quantity = quantity;
            Comment = comment;
            Order_Status = orderStatus;
            Order_Time = Ordertime;
            Table_Number = tableNumber;
            
        }

       
        public enum OrderStatus
        {
            ordered, preparing, ready, delivered
        }

        public int OrderItemID { get; set; }
        public int Order_Number { get; set; }
        public MenuItem MenuItem { get; set; } // (will not be accessbile until menuitem is updated)
        public int Quantity { get; set; }
        public string Comment { get; set; }

        public OrderStatus Order_Status { get; set; }

        public DateTime Order_Time { get; set; }

        public Table Table_Number { get; set; }

        

        public OrderItem() : this(0, 0, new MenuItem(), 1, "", OrderStatus.ordered, DateTime.Now, new Table())
        {

        }
    }
}
