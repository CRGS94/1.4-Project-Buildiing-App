using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using ChapeauDAL;
using ChapeauModel;


namespace ChapeauDAL
{
    public class BillDAO: BaseDao
    {
        private SqlConnection dbConnection;
        public BillDAO()
        {
            string connString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            dbConnection = new SqlConnection(connString);
        }
    }
}
