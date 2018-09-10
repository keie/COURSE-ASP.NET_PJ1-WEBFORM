
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
    }
}
