using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DA;
using BLL;

namespace GUI.Control
{
    public partial class sodoKhachSan : UserControl
    {
        public sodoKhachSan()
        {
            InitializeComponent();
            Loaddata();
        }
        private List<string> a = new List<string>();
        void LoadPhong()
        {
            foreach (var i in a)
            {
                usPhong btn = new usPhong(i);
                flowLayoutPanel1.Controls.Add(btn);
                
            }
        }
        void Addphong(string text)
        {
            a.Add((text));
        }
        void Deletephong()
        {
            int index = a.Count() - 1;
            a.RemoveAt(index);
            flowLayoutPanel1.Controls.RemoveAt(index);
        }

        private void Loaddata()
        {
          //  List<Phong> a = PhongBL.GetPhongs();

            //var bindinglist = new BindingList<Phong>(PhongBL.GetPhongs());
            //metroGrid1.DataSource = bindinglist;
            metroGrid1.DataSource = PhongBL.GetAllPhong();
        }
        private void SodoKhachSan_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Addphong(textBox1.Text);
            flowLayoutPanel1.Controls.Clear();
            LoadPhong();
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Deletephong();
            flowLayoutPanel1.Controls.Clear();
            LoadPhong();
        }
    }
}
