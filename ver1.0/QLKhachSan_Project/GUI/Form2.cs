using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using DA;
namespace GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //LoadData();
            getTime();
        }
        void LoadData()
        {
            AbstractFactoryThongTin FactoryThongTin = FactoryProducerThongTin.GetFactory(0);
            DataTable table = new DataTable();

            IThongTinFactory thongTin2 = FactoryThongTin.ChooseTable("ACCOUNT");
            //table = thongTin2.GetData();
           AccountDTO a = new AccountDTO("account", "2222", "bbbb");
           // Phong b = new Phong("Phong", 15000, false, 12);
            thongTin2.Adddata(a);
          //  thongTin2.adddata(a);
            //metroGrid1.DataSource = table;


        }
        void getTime()
        {
            string commandText = "Select * from CaTruc";
            DataTable a = SqlHelper.Instance.ExecuteSelectQueryPar(commandText, CommandType.Text);
            metroGrid1.DataSource = a;
            float fnum = 0.1111f;

           // textBox1.Text = a.Rows[0][1].ToString();
          //  DateTime.Today.TimeOfDay.Subtract(a.Rows[0][1].ToString());
            //TimeSpan.Compare(a.Rows[0][1], DateTime.Today.TimeOfDay);
           // textBox1.Text= a.Rows[0][1].GetType().ToString();
          
            //textBox1.Text = ((TimeSpan)DateTime.Now.TimeOfDay).ToString();

            // lấy giờ , so sánh với hiện tại, xog rồi ghi xuông trễ, cộng dồn
            // mình đang lấy giờ check in, và so sánh với giờ làm, nếu lớn hơn thì cộng giờ trễ... nếu nhỏ hơn thì....
            textBox1.Text = (((TimeSpan)DateTime.Now.TimeOfDay).Subtract((TimeSpan)a.Rows[0][1]).TotalHours).ToString();
            decimal luong = 1400 * (decimal)(((TimeSpan)DateTime.Now.TimeOfDay).Subtract((TimeSpan)a.Rows[0][1]).TotalHours);
            luong= Math.Round(luong,0 );
            textBox2.Text = luong.ToString();
 
            //SqlHelper.Instance.ExecuteNonQuery("insert ")
        }
    }
}
