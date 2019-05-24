using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using System.Data;
using DTO;

namespace BLL
{
    public class ChooseTabbleFactory : AbstractFactoryThongTin
    {
        public override IThongTinFactory ChooseTable( string typeTTGet)
        {
            if (typeTTGet.Equals("PHONG"))
            {
                return new PhongTT();
            }
            else if (typeTTGet.Equals("ACCOUNT"))
            {
                return new AccountTT();
            }
            return null;
        }
    }
}
