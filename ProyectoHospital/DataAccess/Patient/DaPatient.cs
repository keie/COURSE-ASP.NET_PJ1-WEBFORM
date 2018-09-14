

namespace DataAccess.Patient
{
    using System.Data;
    using System.Data.SqlClient;
    public class DaPatient
    {
        public bool RegisterPatient(SqlConnection sqlConnection, string data)
        {
            bool answer = false;
            SqlCommand sqlCommand = new SqlCommand("[usp.PATIENT.Register]", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@data", data);
            int obj = sqlCommand.ExecuteNonQuery();
            if (obj >= 1) answer = true;
            return answer;
        }
        public string GetListPatient(SqlConnection sqlConnection)
        {
            string answer = "";
            SqlCommand sqlCommand = new SqlCommand("[usp.PATIENT.GetList]", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            object obj = sqlCommand.ExecuteScalar();
            if (obj != null) answer = obj.ToString();
            return answer;
        }
        public bool UpdatePatient(SqlConnection sqlConnection, string data)
        {
            bool answer = false;
            SqlCommand sqlCommand = new SqlCommand("[usp.PATIENT.Update]", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@data", data);
            int obj = sqlCommand.ExecuteNonQuery();
            if (obj >= 1) answer = true;
            return answer;
        }
        public bool DeletePatient(SqlConnection sqlConnection, string data)
        {
            bool answer = false;
            SqlCommand sqlCommand = new SqlCommand("[usp.PATIENT.Delete]", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@data", data);
            int obj = sqlCommand.ExecuteNonQuery();
            if (obj >= 1) answer = true;
            return answer;
        }
    }
}
