using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DA
{
   public class CaTrucDA
    {
        public static DataTable GetAllCaTruc()
        {
                string commandText = "getAllCaTruc";
                return SqlHelper.Instance.ExecuteSelectQueryPar(commandText, CommandType.StoredProcedure);

                //string cmdText = "select * from Accounts";
                // return SqlHelper.ExecuteSelectQueryPar(cmdText, CommandType.Text);
        }
    }
}
