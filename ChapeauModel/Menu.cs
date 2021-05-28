using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Menu
    {
        public int Menu_ID { get; set; }

        public string Menu_Name { get; set; }

        public DateTime Start_Time { get; set; }

        public DateTime End_Time { get; set; }

        public Menu(int menu_id, string menu_name, DateTime start_time, DateTime end_time)
        {
            Menu_ID = menu_id;
            Menu_Name = menu_name;
            Start_Time = start_time;
            End_Time = end_time;
        }
    }
}
