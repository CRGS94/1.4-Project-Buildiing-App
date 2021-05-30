using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using ChapeauModel;

namespace ChapeauDAL
{
    public class TableDAO : BaseDao
    {
        //returns a list of tables
        public List<Table> GetAllTables()
        {
            string query = "SELECT table_id, table_number, table_capacity, table_availability FROM [Table]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    Table_ID = (int)dr["table_id"],
                    Table_Number = (int)(dr["table_number"]),
                    Table_Capacity = (int)(dr["table_capacity"]),
                    Table_Availability = ((Table_Availability)dr["table_availability"])
                };
                tables.Add(table);
            }
            return tables;
        }

        //change tablee availabilitys
        public void UpdateTable(Table table, bool occupied)
        {
            string query = $"UPDATE [Table] SET table_availability={occupied} WHERE table_id={table.Table_ID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}