using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ITMO.ADO.NET.DBConnection
{
    class WorkWithDataBase
    {
        public static int ExecuteScalarMethod(string cs, string qv)
        {
            using (SqlConnection connection=new SqlConnection(cs))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = qv;
                int number = (int)command.ExecuteScalar();
                return number;
            }
        }
    }
}
