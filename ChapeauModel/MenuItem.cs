using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class MenuItem
    {
        public int Menu_Item_ID { get; set; }
        public string Menu_Item_Name { get; set; }
        public int Menu_Item_Stock { get; set; }
        public int Menu_Item_Price { get; set; }
        public int Menu_Item_Vat { get; set; }
        public Menu Menu_ID { get; set; }
        public string Menu_Item_Category { get; set; }

    }
}
