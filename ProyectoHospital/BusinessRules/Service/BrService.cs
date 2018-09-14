

namespace BusinessRules.Service
{
    using DataAccess.Service;
    using System;
    using System.Data.SqlClient;

    public class BrService:brConnection
    {
        public bool RegisterService(string data)
        {
            bool answer = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaService odaUser = new DaService();
                    answer = odaUser.RegisterService(connection, data);

                }
                catch (Exception e)
                {
                    RecordLog(e.Message, e.StackTrace);
                }
            }
            return answer;
        }
        public string GetListService()
        {
            String answer = "";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaService odaService = new DaService();
                    answer = odaService.GetListService(connection);
                }
                catch (Exception e)
                {
                    RecordLog(e.Message, e.StackTrace);
                }
            }
            return answer;
        }
        public bool UpdateService(string data)
        {
            bool answer = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaService odaService = new DaService();
                    answer = odaService.UpdateService(connection, data);

                }
                catch (Exception e)
                {
                    RecordLog(e.Message, e.StackTrace);
                }
            }
            return answer;
        }
        public bool DeleteService(string data)
        {
            bool answer = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaService odaService = new DaService();
                    answer = odaService.DeleteService(connection, data);

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
