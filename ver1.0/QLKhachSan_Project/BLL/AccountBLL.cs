using DA;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class AccountBLL
    {
        private AccountDAL accountDAL;

        /// <constructor>
        /// Constructor UserLoginBLL
        /// </constructor>
        public AccountBLL()
        {
            accountDAL = new AccountDAL();
        }
        
        public string GetTypeAccount(string username, string pass)
        {
            return accountDAL.SearchTypeAccountByUsername_Pass(username,pass);
        }
        public int AddAccount(AccountDTO accountDTO)
        {
            return accountDAL.AddAccount(accountDTO);
        }
        public int DelteAccountByeUserName(string username)
        {
            if (username != "admin")
                return accountDAL.DelteAccountByeUserName(username);
            return 0;
        }
        public DataTable ViewAllAccount()
        {
            return accountDAL.GetAllAccount();
        }
        public int UpdatePass(string username, string pass)
        {
          return  AccountDAL.UpdatePassByUsername(username, pass);
        }
     
    }
}
