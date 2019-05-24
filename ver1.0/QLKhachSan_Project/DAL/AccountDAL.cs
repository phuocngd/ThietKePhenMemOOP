using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DA
{
    public class AccountDAL
    {
        public string SearchTypeAccountByUsername_Pass(string _username, string _password)
        {
            string TypeAccout = "";
            // đây là cách select binh thường
            string commandText = "GetTypeAccountWithUserPass";

            // tạo list parametter
            SqlParameter sqlParametersUsername = new SqlParameter("@Username", SqlDbType.VarChar, 50)
            {
                Value = Convert.ToString(_username)
            };

            SqlParameter sqlParametersPass = new SqlParameter("@Pass", SqlDbType.VarChar, 50)
            {
                Value = Convert.ToString(_password)
            };

            SqlParameter parameterTyeAccount = new SqlParameter("@TpyeAccount", SqlDbType.VarChar, 50)
            {
                Direction = ParameterDirection.Output
            };

            using (SqlDataReader reader = SqlHelper.Instance.ExecuteReader(commandText,
            CommandType.StoredProcedure, sqlParametersUsername, sqlParametersPass, parameterTyeAccount))
            {
                return TypeAccout = parameterTyeAccount.Value.ToString();
            }
        }
        
        public int AddAccount(AccountDTO accountDTO)
        {
            string commandText = "AddAccount";
            SqlParameter sqlParametersUsername = new SqlParameter("@Username", SqlDbType.VarChar, 50)
            {
                Value = Convert.ToString(accountDTO.Username)
            };

            SqlParameter sqlParametersPass = new SqlParameter("@Pass", SqlDbType.VarChar, 50)
            {
                Value = Convert.ToString(accountDTO.Pass)
            };

            SqlParameter sqlParametersTypeAccount = new SqlParameter("@TypeAccount", SqlDbType.VarChar, 50)
            {
                Value = Convert.ToString(accountDTO.TypeAccount)
            };
            return SqlHelper.Instance.ExecuteNonQuery(commandText, CommandType.StoredProcedure, sqlParametersUsername, sqlParametersPass, sqlParametersTypeAccount);
        }
        public int DelteAccountByeUserName(string usernmae)
        {
            string commandText = "DeleteAccountByUsername";

            SqlParameter sqlParametersUsername = new SqlParameter("@Username", SqlDbType.VarChar, 50)
            {
                Value = Convert.ToString(usernmae)
            };

            return SqlHelper.Instance.ExecuteNonQuery(commandText, CommandType.StoredProcedure, sqlParametersUsername);
        }
        public DataTable GetAllAccount()
        {
            string commandText = "GetAllAccount";
            return SqlHelper.Instance.ExecuteSelectQueryPar(commandText, CommandType.StoredProcedure);

            //string cmdText = "select * from Accounts";
            // return SqlHelper.ExecuteSelectQueryPar(cmdText, CommandType.Text);

        }
        public static int UpdatePassByUsername(string Username, string pass)
        {
            string cmdtext = "UppdatePassbyUsername";
            SqlParameter sqlParametersUsername = new SqlParameter("@Username", SqlDbType.VarChar, 50)
            {
                Value = Convert.ToString(Username)
            };
            SqlParameter sqlParametersPass = new SqlParameter("@PassWord", SqlDbType.VarChar, 50)
            {
                Value = Convert.ToString(pass)
            };
            return SqlHelper.Instance.ExecuteNonQuery(cmdtext, CommandType.StoredProcedure, sqlParametersUsername,sqlParametersPass);
        }
    }
}
