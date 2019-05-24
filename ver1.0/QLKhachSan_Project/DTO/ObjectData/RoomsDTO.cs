using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoomsDTO
    {
        private string _IDRoom;
        private string _Name;
        private decimal _Price;
        private bool _Statuss;
        private string _cmndKhach;
        private string _hovaten;
        private string _sdt;
        private DateTime _checkin;
        private DateTime _checkout;

        public string IDRoom { get => _IDRoom; set => _IDRoom = value; }
        public string Name { get => _Name; set => _Name = value; }
        public decimal Price { get => _Price; set => _Price = value; }
        public bool Statuss { get => _Statuss; set => _Statuss = value; }
        public string CmndKhach { get => _cmndKhach; set => _cmndKhach = value; }
        public string Hovaten { get => _hovaten; set => _hovaten = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public DateTime Checkin { get => _checkin; set => _checkin = value; }
        public DateTime Checkout { get => _checkout; set => _checkout = value; }

        public RoomsDTO(string iDRoom, string name, decimal price, bool statuss)
        {
            IDRoom = iDRoom;
            Name = name;
            Price = price;
            Statuss = statuss;
            CmndKhach = null;
            Hovaten = null;
            Sdt = null;
        }

        //public Phong(DataRow row)
        //{
        //    Idroom = (int)row["IDRoom"];
        //    Name = row["Name"].ToString();
        //    Price = (decimal)row["Price"];
        //    Isbooking = (bool)row["Statuss"];
        //}

    }
}
