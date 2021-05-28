using System;
using System.Collections.Generic;
using System.Text;
using ChapeauModel;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class OrderDAO : BaseDao
    {
        public OrderDAO()
        {
            
        }
        List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderID = (int)dr["order_ID"],
                    BillID = (int)dr["bill_ID"],
                    Table_Number = (Table)dr["table_number"],
                    Employee_Number = (Employee)dr["empoyee_number"],
                    Order_Time = (DateTime)dr["order_time"],
                    Order_Status = (bool)dr["order_status"],
                    Comment = (string)dr["comment"]
                };
                orders.Add(order);
            }
            return orders;
        }
        public List<Order> GetAllOrders()
        {
            string query = "SELECT order_number, bill_ID, table_number, employee_number, order_time, order_status, comment FROM [Order]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateOrder(Order order, bool completed)
        {
            string query = $"UPDATE [Table] SET order_status={completed} WHERE table_id={order.OrderID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
