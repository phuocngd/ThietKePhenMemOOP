using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using DTO;
namespace DA
{
    public class PhongDA
    {
        private static PhongDA instance;
        public static PhongDA Instance
        {
            get { if (instance == null) instance = new PhongDA(); return instance; }
            private set { PhongDA.instance = value; }
        }
        private PhongDA() { }
        public List<RoomsDTO> LoadPhongList()
        {
            List<RoomsDTO> phonglist = new List<RoomsDTO>();
            DataTable table = SqlHelper.Instance.ExecuteSelectQueryPar("getAllPhong", CommandType.StoredProcedure);
            foreach(DataRow item in table.Rows)
            {
               // RoomsDTO phong = new RoomsDTO(item);
                phonglist.Add(phong);
            }
            return phonglist;
        }
        public DataTable GetAllPhong()
        {
            return SqlHelper.Instance.ExecuteSelectQueryPar("getAllPhong", CommandType.StoredProcedure);
        }
    }
}
