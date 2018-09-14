

namespace DataAccess.Service
{
    using System.Data;
    using System.Data.SqlClient;
    public class DaService
    {
        public bool RegisterService(SqlConnection sqlConnection, string data)
        {
            bool answer = false;
            SqlCommand sqlCommand = new SqlCommand("[usp.EMPLOYEE.Register]", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@data", data);
            int obj = sqlCommand.ExecuteNonQuery();
            if (obj >= 1) answer = true;
            return answer;
        }
    }
}
