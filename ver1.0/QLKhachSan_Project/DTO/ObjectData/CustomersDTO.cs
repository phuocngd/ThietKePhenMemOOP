using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class CustomersDTO
    {
        private string _CustomerCMND;
        private string _HoTenlot;
        private string _Ten;
        private DateTime _NgaySinh;
        private string _SDT;

        public string CustomerCMND { get => _CustomerCMND; set => _CustomerCMND = value; }
        public string HoTenlot { get => _HoTenlot; set => _HoTenlot = value; }
        public string Ten { get => _Ten; set => _Ten = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string SDT { get => _SDT; set => _SDT = value; }

        public CustomersDTO(string customerCMND, string hoTenlot, string ten, DateTime ngaySinh, string sDT)
        {
            CustomerCMND = customerCMND ?? throw new ArgumentNullException(nameof(customerCMND));
            HoTenlot = hoTenlot; 
            Ten = ten ?? throw new ArgumentNullException(nameof(ten));
            NgaySinh = ngaySinh;
            SDT = sDT; 
        }
    }
}
