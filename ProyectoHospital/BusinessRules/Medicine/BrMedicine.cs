

namespace BusinessRules.Medicine
{
    using System;
    using System.Data.SqlClient;
    using DataAccess.Medicine;
    public class BrMedicine:brConnection
    {
        public bool RegisterEmployee(string data)
        {
            bool answer = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaMedicine odaMedicine = new DaMedicine();
                    answer = odaMedicine.RegisterMedicine(connection, data);

                }
                catch (Exception e)
                {
                    RecordLog(e.Message, e.StackTrace);
                }
            }
            return answer;
        }
        public string GetListMedicine()
        {
            String answer = "";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaMedicine odaMedicine = new DaMedicine();
                    answer = odaMedicine.GetListMedicine(connection);
                }
                catch (Exception e)
                {
                    RecordLog(e.Message, e.StackTrace);
                }
            }
            return answer;
        }
        public bool UpdateMedicine(string data)
        {
            bool answer = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaMedicine odaMedicine = new DaMedicine();
                    answer = odaMedicine.UpdateMedicine(connection,data);

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
