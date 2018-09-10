

namespace BusinessRules.Employee
{
    using System;
    using System.Data.SqlClient;
    using DataAccess.Empleado;
    
    public class BrEmployee:brConnection
    {
        public string Login(string data)
        {
            string answer = "";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaEmployee odaUser = new DaEmployee();
                    answer = odaUser.Login(connection, data);
                }
                catch (Exception e)
                {
                    RecordLog(e.Message, e.StackTrace);
                }
            }
            return answer;
        }
    }
}
