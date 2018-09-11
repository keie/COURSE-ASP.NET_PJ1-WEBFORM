

namespace BusinessRules.Employee
{
    using System;
    using System.Collections.Generic;
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
        public string GetListEmployee()
        {
            String answer="" ;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaEmployee odaUser = new DaEmployee();
                    answer = odaUser.GetListEmployee(connection);
                }
                catch (Exception e)
                {
                    RecordLog(e.Message, e.StackTrace);
                }
            }
            return answer;
        }
        public bool DeleteEmployee(string data)
        {
            bool answer =false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaEmployee odaUser = new DaEmployee();
                    answer = odaUser.DeleteEmployee(connection,data);

                }
                catch (Exception e)
                {
                    RecordLog(e.Message, e.StackTrace);
                }
            }
            return answer;
        }
        public bool UpdateEmployee(string data)
        {
            bool answer = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaEmployee odaUser = new DaEmployee();
                    answer = odaUser.UpdateEmployee(connection, data);

                }
                catch (Exception e)
                {
                    RecordLog(e.Message, e.StackTrace);
                }
            }
            return answer;
        }
        public bool RegisterEmployee(string data)
        {
            bool answer = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaEmployee odaUser = new DaEmployee();
                    answer = odaUser.RegisterEmployee(connection, data);

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
