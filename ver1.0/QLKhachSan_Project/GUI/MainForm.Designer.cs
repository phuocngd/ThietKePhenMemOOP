namespace GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.addressBox1 = new Awesomium.Windows.Forms.AddressBox();
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabpCauHinhHeThong = new System.Windows.Forms.TabPage();
            this.tabviewAdmin = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPageHom = new System.Windows.Forms.TabPage();
            this.metroContextMenu3 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.áToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sodoKhachSan1 = new GUI.Control.sodoKhachSan();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPageDoanhThu = new System.Windows.Forms.TabPage();
            this.tabView.SuspendLayout();
            this.tabpCauHinhHeThong.SuspendLayout();
            this.tabviewAdmin.SuspendLayout();
            this.tabPageHom.SuspendLayout();
            this.metroContextMenu3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressBox1
            // 
            this.addressBox1.AcceptsReturn = true;
            this.addressBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addressBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.addressBox1.Location = new System.Drawing.Point(0, 0);
            this.addressBox1.Name = "addressBox1";
            this.addressBox1.Size = new System.Drawing.Size(100, 22);
            this.addressBox1.TabIndex = 0;
            this.addressBox1.URL = null;
            this.addressBox1.WebControl = null;
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tabpCauHinhHeThong);
            this.tabView.Controls.Add(this.tabPageHom);
            this.tabView.Controls.Add(this.tabPageDoanhThu);
            this.tabView.Location = new System.Drawing.Point(23, 63);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(1707, 706);
            this.tabView.TabIndex = 4;
            // 
            // tabpCauHinhHeThong
            // 
            this.tabpCauHinhHeThong.Controls.Add(this.tabviewAdmin);
            this.tabpCauHinhHeThong.Location = new System.Drawing.Point(4, 25);
            this.tabpCauHinhHeThong.Name = "tabpCauHinhHeThong";
            this.tabpCauHinhHeThong.Padding = new System.Windows.Forms.Padding(3);
            this.tabpCauHinhHeThong.Size = new System.Drawing.Size(1699, 677);
            this.tabpCauHinhHeThong.TabIndex = 0;
            this.tabpCauHinhHeThong.Text = "Cấu Hình Hệ Thống";
            this.tabpCauHinhHeThong.UseVisualStyleBackColor = true;
            // 
            // tabviewAdmin
            // 
            this.tabviewAdmin.Controls.Add(this.tabPage3);
            this.tabviewAdmin.Controls.Add(this.tabPage4);
            this.tabviewAdmin.Controls.Add(this.tabPage1);
            this.tabviewAdmin.Controls.Add(this.tabPage2);
            this.tabviewAdmin.Location = new System.Drawing.Point(6, 6);
            this.tabviewAdmin.Name = "tabviewAdmin";
            this.tabviewAdmin.SelectedIndex = 0;
            this.tabviewAdmin.Size = new System.Drawing.Size(1406, 565);
            this.tabviewAdmin.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1398, 536);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Quản Lý Nhân Viên";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1398, 536);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Quản Lý Phòng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPageHom
            // 
            this.tabPageHom.Controls.Add(this.sodoKhachSan1);
            this.tabPageHom.Location = new System.Drawing.Point(4, 25);
            this.tabPageHom.Name = "tabPageHom";
            this.tabPageHom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHom.Size = new System.Drawing.Size(1699, 677);
            this.tabPageHom.TabIndex = 1;
            this.tabPageHom.Text = "Home";
            this.tabPageHom.UseVisualStyleBackColor = true;
            // 
            // metroContextMenu3
            // 
            this.metroContextMenu3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.aToolStripMenuItem1,
            this.aToolStripMenuItem2,
            this.aToolStripMenuItem3});
            this.metroContextMenu3.Name = "metroContextMenu3";
            this.metroContextMenu3.Size = new System.Drawing.Size(87, 100);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.aToolStripMenuItem.Text = "a";
            // 
            // aToolStripMenuItem1
            // 
            this.aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            this.aToolStripMenuItem1.Size = new System.Drawing.Size(86, 24);
            this.aToolStripMenuItem1.Text = "a";
            // 
            // aToolStripMenuItem2
            // 
            this.aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            this.aToolStripMenuItem2.Size = new System.Drawing.Size(86, 24);
            this.aToolStripMenuItem2.Text = "a";
            // 
            // aToolStripMenuItem3
            // 
            this.aToolStripMenuItem3.Name = "aToolStripMenuItem3";
            this.aToolStripMenuItem3.Size = new System.Drawing.Size(86, 24);
            this.aToolStripMenuItem3.Text = "a";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.áToolStripMenuItem,
            this.ssToolStripMenuItem,
            this.ssToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(91, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // áToolStripMenuItem
            // 
            this.áToolStripMenuItem.Name = "áToolStripMenuItem";
            this.áToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.áToolStripMenuItem.Text = "á";
            // 
            // ssToolStripMenuItem
            // 
            this.ssToolStripMenuItem.Name = "ssToolStripMenuItem";
            this.ssToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.ssToolStripMenuItem.Text = "ss";
            // 
            // ssToolStripMenuItem1
            // 
            this.ssToolStripMenuItem1.Name = "ssToolStripMenuItem1";
            this.ssToolStripMenuItem1.Size = new System.Drawing.Size(90, 24);
            this.ssToolStripMenuItem1.Text = "ss";
            // 
            // sodoKhachSan1
            // 
            this.sodoKhachSan1.Location = new System.Drawing.Point(25, 30);
            this.sodoKhachSan1.Name = "sodoKhachSan1";
            this.sodoKhachSan1.Size = new System.Drawing.Size(1182, 598);
            this.sodoKhachSan1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1398, 536);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Quản Lý Tài Khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1398, 536);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Quản Lý Kho";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPageDoanhThu
            // 
            this.tabPageDoanhThu.Location = new System.Drawing.Point(4, 25);
            this.tabPageDoanhThu.Name = "tabPageDoanhThu";
            this.tabPageDoanhThu.Size = new System.Drawing.Size(1699, 677);
            this.tabPageDoanhThu.TabIndex = 2;
            this.tabPageDoanhThu.Text = "Doanh Thu";
            this.tabPageDoanhThu.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 792);
            this.Controls.Add(this.tabView);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Quản Lý Khách Sạn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabView.ResumeLayout(false);
            this.tabpCauHinhHeThong.ResumeLayout(false);
            this.tabviewAdmin.ResumeLayout(false);
            this.tabPageHom.ResumeLayout(false);
            this.metroContextMenu3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Awesomium.Windows.Forms.AddressBox addressBox1;
        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage tabpCauHinhHeThong;
        private System.Windows.Forms.TabControl tabviewAdmin;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPageHom;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu3;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem áToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ssToolStripMenuItem1;
        private Control.usPhong usPhong3;
        private Control.usPhong usPhong2;
        private Control.usPhong usPhong1;
        private Control.sodoKhachSan sodoKhachSan1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPageDoanhThu;
    }
}