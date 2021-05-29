using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Bill

    {
        //order overview
        public int OrderId { get; set; }// which order is linked
        public int BillId { get; set; }//the number of such bill
        public string Host_name { get; set; }//who served that order
        public List<OrderItem> Items { get; set; }//list of the order's items
        public List<OrderItem> Items_price { get; set; }//their prices
        public int TotalPrice { get; set; }//total price of the meal
        //for the payment method, message box
        public PaymentType Type { get; set; }//how gonna be pay
        public string Feedback { get; set; }//any comments to add
        public int Tip { get; set; }//tip for the host
        public OrderItem Vat { get; set; }//Taxes over the price of the items or the total?

        public Bill(int orderId, int billId, string host_name, List<OrderItem> items, List<OrderItem> items_price, int totalPrice, PaymentType type, string feedback, int tip, OrderItem vat)
        {
            this.OrderId = orderId;
            this.BillId = billId;
            this.Host_name = host_name;
            this.Items = items;
            this.Items_price = items_price;
            this.TotalPrice = totalPrice;
            this.Type = type;
            this.Feedback = feedback;
            this.Tip = tip;
            this.Vat = vat;
        }


    }
}
