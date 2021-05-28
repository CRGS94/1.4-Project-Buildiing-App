using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using ChapeauModel;

namespace ChapeauDAL
{
    public class MenuDAO : BaseDao
    {
        private SqlConnection dbConnection;

        public MenuDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }

        public List<Menu> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Menu", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Menu> menuList = new List<Menu>();

            while (reader.Read())
            {
                Menu menu = Readmenus(reader);
                menuList.Add(menu);
            }
            reader.Close();
            dbConnection.Close();

            return menuList;
        }

        public Menu GetById(int menu_id)
        {
            dbConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Menu WHERE menu_id = @Id", dbConnection);

            command.Parameters.AddWithValue("@Id", menu_id);

            SqlDataReader reader = command.ExecuteReader();
            Menu menu = null;

            if (reader.Read())
            {
                menu = Readmenus(reader);
            }
            reader.Close();
            dbConnection.Close();

            return menu;
        }

        private Menu Readmenus(SqlDataReader reader)
        {
            //retrieve data from all fields
            int id = (int)reader["menu_id"];
            string name = (string)reader["menu_name"];
            DateTime start = (DateTime)reader["start_time"];
            DateTime end = (DateTime)reader["end_time"];

            //return new book object
            return new Menu(id, name, start, end);
        }
    }
}
