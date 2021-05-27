using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using ChapeauModel;

namespace ChapeauModel
{
    public class Order
    {
        public Order(int orderID, int billID, Table tableNumber, Employee employeeNumber, DateTime orderTime, bool orderStatus, string comment)
        {
            orderID = OrderID;
            billID = BillID;
            tableNumber = Table_Number; // don't know why this is happening
            employeeNumber = Employee_Number;  // don't know why this is happening
            orderTime = Order_Time;
            orderStatus = Order_Status;
            comment = Comment;
        }

        public Order()
        {
        }

        public List<OrderItem> orderItems = new List<OrderItem>();

        public int OrderID { get; set; } // to refer to the order later

        public int BillID { get; set; } //to refer to the bill within the order

        public int Table_Number { get; set; } // 1 - 10

        public int Employee_Number { get; set; } // who took the order

        public DateTime Order_Time { get; set; } // what time was the order taken

        public bool Order_Status { get; set; } // order incomplete/order complete

        public string Comment { get; set; } // customer places comment
    }
}
