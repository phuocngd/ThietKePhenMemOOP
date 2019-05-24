using DA;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BLL
{
    public class PhongBL
    {
        public static List<RoomsDTO> GetPhongs()
        {
            List<RoomsDTO> phong = PhongDA.Instance.LoadPhongList();
            return phong;
        }
        public static DataTable GetAllPhong()
        {
            return PhongDA.Instance.GetAllPhong();
        }
    }
}
