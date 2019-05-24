using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using System.Data.SqlClient;
using DTO;

namespace GUI
{
    public partial class frmAdmin : UserControl
    {
        private string function = "add";
        
        private AccountBLL accountBLL;
        public frmAdmin()
        {
            InitializeComponent();
            accountBLL = new AccountBLL();
        }

        void FillAccountDataGridview()
        {
            DataTable dt = accountBLL.ViewAllAccount();
            myGridAccount.DataSource = dt;
            //metroGridAccount.Columns[0].Visible = false;
            //metroGridAccount.Columns[4].Visible = false;
            //metroGridAccount.Columns[5].Visible = false;
        }

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            pnlAadd.Visible = true;
            pnlBtnFuntion.Visible = false;
            function = "add";
            //AccountDTO accountDTO = new AccountDTO();
            //accountDTO.Username = txtUsername.Text;
            //string password = txtPassWord.Text;
            //accountDTO.TypeAccount = cbbTypeAccount.Text;
            //FrmAddAccount frmAddAccount = new FrmAddAccount();
            //frmAddAccount.Show();

            //  this.Hide();


            //accountBLL.AddAccount(accountDTO, password);
        }

        private void BtnReadAccount_Click(object sender, EventArgs e)
        {
            FillAccountDataGridview();
        }

        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            FillAccountDataGridview();
        }

        private void BtnUppdate_Click(object sender, EventArgs e)
        {
            pnlAadd.Visible = true;
            pnlBtnFuntion.Visible = false;
            txtUsername.ReadOnly = true;
            function = "update";

            txtUsername.Text = myGridAccount.CurrentRow.Cells[0].Value.ToString();
            txtPassWord.Text = myGridAccount.CurrentRow.Cells[1].Value.ToString();
            //if (accountBLL.UpdatePass(txtUsername.Text, txtPassWord.Text) == 1) MessageBox.Show("update thành công");
        }

        private void BtnDeleteAccount_Click(object sender, EventArgs e)
        {

            if (accountBLL.DelteAccountByeUserName(myGridAccount.CurrentRow.Cells[0].Value.ToString()) == 0)
                MetroFramework.MetroMessageBox.Show(this, "Không được xóa account Admin");
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Đã xóa thành công");
                FillAccountDataGridview();
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (function == "add")
            {
                if (cbbTypeAccount.Text != "" && txtUsername.Text != "" && txtPassWord.Text != "")
                {
                    AccountDTO accountDTO = new AccountDTO(txtUsername.Text, txtPassWord.Text, cbbTypeAccount.Text);
                    //string password = txtPassWord.Text;
                    //accountDTO.TypeAccount = cbbTypeAccount.Text;
                    AccountBLL accountBLL = new AccountBLL();
                    accountBLL.AddAccount(accountDTO);

                    
                }
            }
            else if (function == "update")
            {
                if (txtUsername.Text != "" && txtPassWord.Text != "")
                {
                    if (accountBLL.UpdatePass(txtUsername.Text, txtPassWord.Text) == 1)
                     MessageBox.Show("update thành công");
                }
            }
            txtUsername.ReadOnly = false;
            FillAccountDataGridview();
            pnlAadd.Visible = false;
            pnlBtnFuntion.Visible = true;
        }

        private void BtnCanCle_Click(object sender, EventArgs e)
        {
            pnlAadd.Visible = false;
            pnlBtnFuntion.Visible = true;
        }
    }
}
