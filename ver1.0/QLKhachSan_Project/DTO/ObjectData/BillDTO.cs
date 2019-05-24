using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class BillDTO
    {
        private string _IDBill;
        private decimal _TongTien;
        private string _IDCustomer;
        private DateTime _NgayLap;
        private string _NguoiLap;
        private string _CMNDnglap;

        public string IDBill { get => _IDBill; set => _IDBill = value; }
        public decimal TongTien { get => _TongTien; set => _TongTien = value; }
        public string IDCustomer { get => _IDCustomer; set => _IDCustomer = value; }
        public DateTime NgayLap { get => _NgayLap; set => _NgayLap = value; }
        public string NguoiLap { get => _NguoiLap; set => _NguoiLap = value; }
        public string CMNDnglap { get => _CMNDnglap; set => _CMNDnglap = value; }

        public BillDTO(string iDBill, decimal tongTien, string iDCustomer, DateTime ngayLap, string nguoiLap, string cMNDnglap)
        {
            IDBill = iDBill ?? throw new ArgumentNullException(nameof(iDBill));
            TongTien = tongTien;
            IDCustomer = iDCustomer;
            NgayLap = ngayLap;
            NguoiLap = nguoiLap;
            CMNDnglap = cMNDnglap;
        }
    }
}
