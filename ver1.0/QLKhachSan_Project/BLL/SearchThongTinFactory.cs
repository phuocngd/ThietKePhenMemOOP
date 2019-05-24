using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using DTO;

namespace BLL
{
    public class SearchThongTinFactory : AbstractFactoryThongTin
    {
        public override IThongTinFactory ChooseTable( string typeTTGet)
        {
            throw new NotImplementedException();
        }
    }
}
