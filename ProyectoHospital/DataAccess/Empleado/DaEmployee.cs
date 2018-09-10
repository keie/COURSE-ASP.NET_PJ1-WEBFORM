
namespace DataAccess.Empleado
{
    using System.Data;
    using System.Data.SqlClient;
    public class DaEmployee
    {
        public string Login(SqlConnection sqlConnection, string data)
        {
            string answer = "";
            SqlCommand sqlCommand = new SqlCommand("[usp.EMPLOYEE.login]", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@data", data);
            object obj = sqlCommand.ExecuteScalar();
            if (obj != null) answer = obj.ToString();
            return answer;
        }
        public string GetListEmployee(SqlConnection sqlConnection)
        {
            string answer = "";
            SqlCommand sqlCommand = new SqlCommand("[usp.EMPLOYEE.GetList]", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            object obj = sqlCommand.ExecuteScalar();
            if (obj != null) answer = obj.ToString();
            return answer;
        }
        public bool DeleteEmployee(SqlConnection sqlConnection,string data)
        {
            bool answer = false;
            SqlCommand sqlCommand = new SqlCommand("[usp.EMPLOYEE.Delete]", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@data", data);
            int obj = sqlCommand.ExecuteNonQuery();
            if (obj >=1) answer = true;
            return answer;
        }
    }
}
