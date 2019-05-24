using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Salarys
    {
        private string _IDEmployee;
        private decimal _Luong;
        private DateTime _Ngaythang;

        public string IDEmployee { get => _IDEmployee; set => _IDEmployee = value; }
        public decimal Luong { get => _Luong; set => _Luong = value; }
        public DateTime Ngaythang { get => _Ngaythang; set => _Ngaythang = value; }

        public Salarys(string iDEmployee, decimal luong, DateTime ngaythang)
        {
            IDEmployee = iDEmployee ?? throw new ArgumentNullException(nameof(iDEmployee));
            Luong = luong;
            Ngaythang = ngaythang;
        }
    }
}
