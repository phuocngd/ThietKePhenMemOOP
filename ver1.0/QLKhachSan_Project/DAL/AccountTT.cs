using DA;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public class AccountTT : IThongTinFactory
    {

        public DataTable GetData()
        {
            string commandText = "GetAllAccount";
            return  SqlHelper.Instance.ExecuteSelectQueryPar(commandText, CommandType.StoredProcedure);
        }
        public DataTable SearchData(string dieukien)
        {
            throw new NotImplementedException();
        }
        public int Addata(AccountDTO accountDTO, string pass)
        {
            string commandText = "AddAccount";
            SqlParameter sqlParametersUsername = new SqlParameter("@Username", SqlDbType.VarChar, 50)
            {
                Value = Convert.ToString(accountDTO.Username)
            };

            SqlParameter sqlParametersPass = new SqlParameter("@Pass", SqlDbType.VarChar, 50)
            {
                Value = Convert.ToString(pass)
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
            return SqlHelper.Instance.ExecuteNonQuery(cmdtext, CommandType.StoredProcedure, sqlParametersUsername, sqlParametersPass);
        }
        public int Adddata(object a)
        {
            AccountDTO c = a as AccountDTO;
            AccountDTO b = new AccountDTO(c.Username, c.Pass, c.TypeAccount);

            string commandText = "AddAccount";
            SqlParameter sqlParametersUsername = new SqlParameter("@Username", SqlDbType.VarChar, 50)
            {
                Value = Convert.ToString(b.Username)
            };

            SqlParameter sqlParametersPass = new SqlParameter("@Pass", SqlDbType.VarChar, 50)
            {
                Value = Convert.ToString(b.Pass)
            };

            SqlParameter sqlParametersTypeAccount = new SqlParameter("@TypeAccount", SqlDbType.VarChar, 50)
            {
                Value = Convert.ToString(b.TypeAccount)
            };
            return SqlHelper.Instance.ExecuteNonQuery(commandText, CommandType.StoredProcedure, sqlParametersUsername, sqlParametersPass, sqlParametersTypeAccount);
        }
    }
}
