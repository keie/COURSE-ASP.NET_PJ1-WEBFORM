


namespace BusinessRules.Bed
{
    using System;
    using System.Data.SqlClient;
    using DataAccess.Bed;
    using System;
    public class BrBed:brConnection
    {
        public bool RegisterBed(string data)
        {
            bool answer = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaBed odaBed = new DaBed();
                    answer = odaBed.RegisterBed(connection, data);

                }
                catch (Exception e)
                {
                    RecordLog(e.Message, e.StackTrace);
                }
            }
            return answer;
        }
        public string GetListBed()
        {
            String answer = "";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaBed odaBed = new DaBed();
                    answer = odaBed.GetListBed(connection);
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
