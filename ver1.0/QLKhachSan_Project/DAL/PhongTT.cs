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
    public class PhongTT : IThongTinFactory
    {
        public int Adddata(object a)
        {
            RoomsDTO c = a as RoomsDTO;
            RoomsDTO b = new RoomsDTO(c.Name, c.Price, c.Isbooking, c.Idroom);

            string commandText = "AddRooms";
            SqlParameter sqlParametersIDRoom = new SqlParameter("@IDRoom", SqlDbType.Int)
            {
                Value = b.Idroom
            };

            SqlParameter sqlParametersName = new SqlParameter("@Name", SqlDbType.NVarChar, 50)
            {
                Value = Convert.ToString(b.Name)
            };

            SqlParameter sqlParametersTypePrice = new SqlParameter("@Price", SqlDbType.Decimal)
            {
                Value = (b.Price)
            };
            SqlParameter sqlParametersTypeStatuss = new SqlParameter("@Statuss", SqlDbType.Bit)
            {
                Value = b.Isbooking
            };
            return SqlHelper.Instance.ExecuteNonQuery(commandText, CommandType.StoredProcedure, sqlParametersIDRoom, sqlParametersName, sqlParametersTypePrice, sqlParametersTypeStatuss);
        }
        public DataTable GetData()
        {
            return SqlHelper.Instance.ExecuteSelectQueryPar("getAllPhong", CommandType.StoredProcedure);
        }
        public DataTable SearchData(string dieukien)
        {
            throw new NotImplementedException();
        }     
    }
}
