using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Control
{
    public partial class usPhong : UserControl
    {
        public usPhong(string tenphong)
        {
            InitializeComponent();
            metroButton1.Text = tenphong;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(metroButton1, 0, metroButton1.Height);
        }

        private void ĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            a.Show();
        }

        private void TrảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
