using DA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public abstract class AbstractFactoryThongTin
    {
        public abstract IThongTinFactory ChooseTable( string typeTTGet);

    }
}
