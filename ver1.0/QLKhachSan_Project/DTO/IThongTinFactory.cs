using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public interface IThongTinFactory
    {
        DataTable GetData();
        DataTable SearchData(string dieukien);
        int Adddata(object a);

    }
}
