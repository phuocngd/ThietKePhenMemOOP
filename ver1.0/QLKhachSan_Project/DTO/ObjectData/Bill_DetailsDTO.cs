using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Bill_DetailsDTO
    {
        private decimal _IDBill;
        private string _IDElements;
        private decimal _Price;
        private int _SoLuong;

        public decimal IDBill { get => _IDBill; set => _IDBill = value; }
        public string IDElements { get => _IDElements; set => _IDElements = value; }
        public decimal Price { get => _Price; set => _Price = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }

        public Bill_DetailsDTO(decimal iDBill, string iDElements, decimal price, int soLuong)
        {
            IDBill = iDBill;
            IDElements = iDElements;
            Price = price;
            SoLuong = soLuong;
        }
    }
}
