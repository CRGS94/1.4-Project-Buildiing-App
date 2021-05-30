using System;

namespace ChapeauModel
{
    public class Table
    {
        public int Table_ID { get; set; }
        public int Table_Number { get; set; } //1-10
        public int Table_Capacity { get; set; } // how many customerrs can fit on one  table? 5
        public Table_Availability Table_Availability { get; set; }

        public Table(int table_Number, Table_Availability table_Availability)
        {
            this.Table_Number = table_Number;
            this.Table_Availability = table_Availability;
        }

        public Table()
        {

        }
    }
}
