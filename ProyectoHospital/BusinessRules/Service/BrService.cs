

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
    }
}
