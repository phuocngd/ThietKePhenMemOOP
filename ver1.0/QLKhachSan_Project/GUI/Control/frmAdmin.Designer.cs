namespace GUI
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myGridAccount = new MetroFramework.Controls.MetroGrid();
            this.dgvtxtUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTypeAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadAccount = new MetroFramework.Controls.MetroButton();
            this.btnAddAccount = new MetroFramework.Controls.MetroButton();
            this.btnUppdate = new MetroFramework.Controls.MetroButton();
            this.btnDeleteAccount = new MetroFramework.Controls.MetroButton();
            this.pnlAadd = new System.Windows.Forms.Panel();
            this.btnCanCle = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.pnlAddacount = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.cbbTypeAccount = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPassWord = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pnlBtnFuntion = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.myGridAccount)).BeginInit();
            this.pnlAadd.SuspendLayout();
            this.pnlAddacount.SuspendLayout();
            this.pnlBtnFuntion.SuspendLayout();
            this.SuspendLayout();
            // 
            // myGridAccount
            // 
            this.myGridAccount.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGridAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.myGridAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.myGridAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myGridAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.myGridAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myGridAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.myGridAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGridAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtUserName,
            this.dgvtxtPassword,
            this.dgvtxtTypeAccount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.myGridAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.myGridAccount.EnableHeadersVisualStyles = false;
            this.myGridAccount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.myGridAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.myGridAccount.Location = new System.Drawing.Point(29, 324);
            this.myGridAccount.Name = "myGridAccount";
            this.myGridAccount.ReadOnly = true;
            this.myGridAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myGridAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.myGridAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.myGridAccount.RowTemplate.Height = 24;
            this.myGridAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.myGridAccount.Size = new System.Drawing.Size(497, 150);
            this.myGridAccount.TabIndex = 0;
            // 
            // dgvtxtUserName
            // 
            this.dgvtxtUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtUserName.DataPropertyName = "UserName";
            this.dgvtxtUserName.HeaderText = "UserName";
            this.dgvtxtUserName.Name = "dgvtxtUserName";
            this.dgvtxtUserName.ReadOnly = true;
            // 
            // dgvtxtPassword
            // 
            this.dgvtxtPassword.DataPropertyName = "Passwords";
            this.dgvtxtPassword.HeaderText = "Password";
            this.dgvtxtPassword.Name = "dgvtxtPassword";
            this.dgvtxtPassword.ReadOnly = true;
            this.dgvtxtPassword.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtPassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtTypeAccount
            // 
            this.dgvtxtTypeAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvtxtTypeAccount.DataPropertyName = "TypeAccount";
            this.dgvtxtTypeAccount.HeaderText = "TypeAccount";
            this.dgvtxtTypeAccount.Name = "dgvtxtTypeAccount";
            this.dgvtxtTypeAccount.ReadOnly = true;
            this.dgvtxtTypeAccount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtTypeAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtTypeAccount.Width = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách Account";
            // 
            // btnReadAccount
            // 
            this.btnReadAccount.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReadAccount.Location = new System.Drawing.Point(3, 15);
            this.btnReadAccount.Name = "btnReadAccount";
            this.btnReadAccount.Size = new System.Drawing.Size(99, 38);
            this.btnReadAccount.TabIndex = 2;
            this.btnReadAccount.Text = "Xem";
            this.btnReadAccount.UseSelectable = true;
            this.btnReadAccount.Click += new System.EventHandler(this.BtnReadAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(133, 15);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(99, 38);
            this.btnAddAccount.TabIndex = 3;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseSelectable = true;
            this.btnAddAccount.Click += new System.EventHandler(this.BtnAddAccount_Click);
            // 
            // btnUppdate
            // 
            this.btnUppdate.Location = new System.Drawing.Point(269, 15);
            this.btnUppdate.Name = "btnUppdate";
            this.btnUppdate.Size = new System.Drawing.Size(99, 38);
            this.btnUppdate.TabIndex = 4;
            this.btnUppdate.Text = "Sửa";
            this.btnUppdate.UseSelectable = true;
            this.btnUppdate.Click += new System.EventHandler(this.BtnUppdate_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(395, 15);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(99, 38);
            this.btnDeleteAccount.TabIndex = 5;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseSelectable = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // pnlAadd
            // 
            this.pnlAadd.Controls.Add(this.btnCanCle);
            this.pnlAadd.Controls.Add(this.btnSave);
            this.pnlAadd.Controls.Add(this.pnlAddacount);
            this.pnlAadd.Location = new System.Drawing.Point(32, 63);
            this.pnlAadd.Name = "pnlAadd";
            this.pnlAadd.Size = new System.Drawing.Size(494, 170);
            this.pnlAadd.TabIndex = 6;
            this.pnlAadd.Visible = false;
            // 
            // btnCanCle
            // 
            this.btnCanCle.Location = new System.Drawing.Point(266, 78);
            this.btnCanCle.Name = "btnCanCle";
            this.btnCanCle.Size = new System.Drawing.Size(75, 34);
            this.btnCanCle.TabIndex = 17;
            this.btnCanCle.Text = "Cancle";
            this.btnCanCle.UseSelectable = true;
            this.btnCanCle.Click += new System.EventHandler(this.BtnCanCle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(266, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pnlAddacount
            // 
            this.pnlAddacount.Controls.Add(this.metroLabel1);
            this.pnlAddacount.Controls.Add(this.txtUsername);
            this.pnlAddacount.Controls.Add(this.cbbTypeAccount);
            this.pnlAddacount.Controls.Add(this.metroLabel3);
            this.pnlAddacount.Controls.Add(this.txtPassWord);
            this.pnlAddacount.Controls.Add(this.metroLabel2);
            this.pnlAddacount.Location = new System.Drawing.Point(3, 12);
            this.pnlAddacount.Name = "pnlAddacount";
            this.pnlAddacount.Size = new System.Drawing.Size(257, 146);
            this.pnlAddacount.TabIndex = 15;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 20);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Username";
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(93, 2);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(105, 7);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(121, 30);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbbTypeAccount
            // 
            this.cbbTypeAccount.FormattingEnabled = true;
            this.cbbTypeAccount.ItemHeight = 24;
            this.cbbTypeAccount.Items.AddRange(new object[] {
            "QuanLyKhachSan",
            "TiepTan",
            "Phong"});
            this.cbbTypeAccount.Location = new System.Drawing.Point(105, 98);
            this.cbbTypeAccount.Name = "cbbTypeAccount";
            this.cbbTypeAccount.Size = new System.Drawing.Size(126, 30);
            this.cbbTypeAccount.TabIndex = 12;
            this.cbbTypeAccount.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(11, 98);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 20);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Loại Account";
            // 
            // txtPassWord
            // 
            // 
            // 
            // 
            this.txtPassWord.CustomButton.Image = null;
            this.txtPassWord.CustomButton.Location = new System.Drawing.Point(93, 2);
            this.txtPassWord.CustomButton.Name = "";
            this.txtPassWord.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPassWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassWord.CustomButton.TabIndex = 1;
            this.txtPassWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassWord.CustomButton.UseSelectable = true;
            this.txtPassWord.CustomButton.Visible = false;
            this.txtPassWord.Lines = new string[0];
            this.txtPassWord.Location = new System.Drawing.Point(105, 50);
            this.txtPassWord.MaxLength = 32767;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '\0';
            this.txtPassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.SelectionLength = 0;
            this.txtPassWord.SelectionStart = 0;
            this.txtPassWord.ShortcutsEnabled = true;
            this.txtPassWord.Size = new System.Drawing.Size(121, 30);
            this.txtPassWord.TabIndex = 10;
            this.txtPassWord.UseSelectable = true;
            this.txtPassWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 20);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Passwords";
            // 
            // pnlBtnFuntion
            // 
            this.pnlBtnFuntion.Controls.Add(this.btnDeleteAccount);
            this.pnlBtnFuntion.Controls.Add(this.btnUppdate);
            this.pnlBtnFuntion.Controls.Add(this.btnReadAccount);
            this.pnlBtnFuntion.Controls.Add(this.btnAddAccount);
            this.pnlBtnFuntion.Location = new System.Drawing.Point(29, 243);
            this.pnlBtnFuntion.Name = "pnlBtnFuntion";
            this.pnlBtnFuntion.Size = new System.Drawing.Size(497, 56);
            this.pnlBtnFuntion.TabIndex = 7;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 564);
            this.Controls.Add(this.pnlBtnFuntion);
            this.Controls.Add(this.pnlAadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myGridAccount);

            this.MinimumSize = new System.Drawing.Size(553, 445);
            this.Name = "frmAdmin";
            this.Text = "Quản Lý Account";

            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGridAccount)).EndInit();
            this.pnlAadd.ResumeLayout(false);
            this.pnlAddacount.ResumeLayout(false);
            this.pnlAddacount.PerformLayout();
            this.pnlBtnFuntion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid myGridAccount;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnReadAccount;
        private MetroFramework.Controls.MetroButton btnAddAccount;
        private MetroFramework.Controls.MetroButton btnUppdate;
        private MetroFramework.Controls.MetroButton btnDeleteAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTypeAccount;
        private System.Windows.Forms.Panel pnlAadd;
        private System.Windows.Forms.Panel pnlAddacount;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroComboBox cbbTypeAccount;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPassWord;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnCanCle;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Panel pnlBtnFuntion;
    }
}