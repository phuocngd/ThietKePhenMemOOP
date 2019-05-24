using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class EmployeesDTO
    {
        private int _EmployeeCMND;
        private string _HovaTen;
        private DateTime _NgaySinh;
        private string _Username;
        private string _SDT;
        private string _Mail;
        private decimal _LuongCanBan;
        private bool _isPartTime;

        public int EmployeeCMND { get => _EmployeeCMND; set => _EmployeeCMND = value; }
        public string HovaTen { get => _HovaTen; set => _HovaTen = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string Username { get => _Username; set => _Username = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string Mail { get => _Mail; set => _Mail = value; }
        public decimal LuongCanBan { get => _LuongCanBan; set => _LuongCanBan = value; }
        public bool IsPartTime { get => _isPartTime; set => _isPartTime = value; }

        public EmployeesDTO(int employeeCMND, string hovaTen, DateTime ngaySinh, string username, string sDT, string mail, decimal luongCanBan, bool isPartTime)
        {
            EmployeeCMND = employeeCMND;
            HovaTen = hovaTen;
            NgaySinh = ngaySinh;
            Username = username;
            SDT = sDT;
            Mail = mail;
            LuongCanBan = luongCanBan;
            IsPartTime = isPartTime;
        }
    }
}
