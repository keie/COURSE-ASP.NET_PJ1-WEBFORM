

namespace BusinessRules.Patient
{
    using System;
    using System.Data.SqlClient;
    using DataAccess.Patient;
    public class BrPatient:brConnection
    {
        public bool RegisterPatient(string data)
        {
            bool answer = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaPatient odaPatient = new DaPatient();
                    answer = odaPatient.RegisterPatient(connection, data);

                }
                catch (Exception e)
                {
                    RecordLog(e.Message, e.StackTrace);
                }
            }
            return answer;
        }
        public string GetListPatient()
        {
            String answer = "";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaPatient odaPatient = new DaPatient();
                    answer = odaPatient.GetListPatient(connection);
                }
                catch (Exception e)
                {
                    RecordLog(e.Message, e.StackTrace);
                }
            }
            return answer;
        }
        public bool UpdatePatient(string data)
        {
            bool answer = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    DaPatient odaPatient = new DaPatient();
                    answer = odaPatient.UpdatePatient(connection, data);

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
