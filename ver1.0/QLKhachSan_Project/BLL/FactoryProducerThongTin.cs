using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class FactoryProducerThongTin
    {
        public static AbstractFactoryThongTin GetFactory(int typeFacetory)
        {
            if (typeFacetory == 0) // 0 là getthongtin // 1 là search thong tin
                return new ChooseTabbleFactory();
            else return new SearchThongTinFactory();
        }
    }
}
