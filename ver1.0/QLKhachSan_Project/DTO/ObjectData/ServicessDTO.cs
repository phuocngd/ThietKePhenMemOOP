using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ServicessDTO
    {
        private string _IDservice;
        private string _Name;
        private string _TypeService;
        private string _Price;

        public string IDservice { get => _IDservice; set => _IDservice = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string TypeService { get => _TypeService; set => _TypeService = value; }
        public string Price { get => _Price; set => _Price = value; }

        public ServicessDTO(string dservice, string name, string typeService, string price)
        {
            IDservice = dservice ?? throw new ArgumentNullException(nameof(dservice));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            TypeService = typeService;
            Price = price ?? throw new ArgumentNullException(nameof(price));
        }
    }
}
