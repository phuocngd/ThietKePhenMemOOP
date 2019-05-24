using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        private AccountBLL accountBLL;
        public Login()
        {
            InitializeComponent();
            accountBLL = new AccountBLL();

            //txtUserName.Text = DateTime.Now.ToString("HH:mm:ss");
            
            //System.DateTime date2 = new System.DateTime(1996, 12, 6, 21, 50, 0);
            //txtUserName.Text = DateTime.Now.TimeOfDay.Subtract(date2.TimeOfDay).ToString();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string typeAccount = accountBLL.GetTypeAccount(txtUserName.Text, txtPasswords.Text);
            if (typeAccount == "")
            {
                MetroFramework.MetroMessageBox.Show(this,"username không tồn tại hoặc password ko đúng","Cảnh báo");
            }
           
            else if(typeAccount =="admin")
            {
               // MessageBox.Show("Bạn có các quyền: " + typeAccount + "\nQuyền đặc biệt: " );
                //AccountDTO account = new AccountDTO();
                //account.Username = "aaa";
                //account.TypeAccount = "ccc";
                //string pass = "2222";
                //accountBLL.AddAccount(account, pass);

                //AccountDTO account2 = new AccountDTO();
                //account2.Username = "aaa2";
                //account2.TypeAccount = "ccc2";
                //string pass2 = "22222";
                //accountBLL.AddAccount(account2, pass2);

               //accountBLL.DelteAccountByeUserName("aaa2");
                MainForm mainForm = new MainForm();
                mainForm.Show();
               this.Hide();

            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
           // System.Windows.Forms.Application.Exit();
        }
    }
}
