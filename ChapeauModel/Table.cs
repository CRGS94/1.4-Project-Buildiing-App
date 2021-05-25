using System;

namespace ChapeauModel
{
    public class Table
    {
        public int Table_ID { get; set; }
        public int Table_Number { get; set; } //1-10
        public int Table_Capacity { get; set; } // how many customerrs can fit on one  table? 5
        public Enum Table_Availability { get; set; } //reserved, occupied, available
    }
}
