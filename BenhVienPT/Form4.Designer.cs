
namespace BenhVienPT
{
    partial class Form4
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.tabCtrlHT = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.liVPhongHT = new System.Windows.Forms.ListView();
            this.MaPhongHT = new System.Windows.Forms.ColumnHeader();
            this.TenPhong = new System.Windows.Forms.ColumnHeader();
            this.TrangThai = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.liVlichLV = new System.Windows.Forms.ListView();
            this.MaLich = new System.Windows.Forms.ColumnHeader();
            this.NgayTruc = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TenTGMo = new System.Windows.Forms.ColumnHeader();
            this.tabCtrlHT.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlHT
            // 
            this.tabCtrlHT.Controls.Add(this.tabPage1);
            this.tabCtrlHT.Controls.Add(this.tabPage2);
            this.tabCtrlHT.Location = new System.Drawing.Point(4, 52);
            this.tabCtrlHT.Name = "tabCtrlHT";
            this.tabCtrlHT.SelectedIndex = 0;
            this.tabCtrlHT.Size = new System.Drawing.Size(1150, 636);
            this.tabCtrlHT.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1142, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bệnh án";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.liVPhongHT);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 494);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // liVPhongHT
            // 
            this.liVPhongHT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaPhongHT,
            this.TenPhong,
            this.TrangThai});
            this.liVPhongHT.FullRowSelect = true;
            this.liVPhongHT.GridLines = true;
            this.liVPhongHT.HideSelection = false;
            this.liVPhongHT.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.liVPhongHT.Location = new System.Drawing.Point(1, 26);
            this.liVPhongHT.Name = "liVPhongHT";
            this.liVPhongHT.Size = new System.Drawing.Size(778, 453);
            this.liVPhongHT.TabIndex = 2;
            this.liVPhongHT.UseCompatibleStateImageBehavior = false;
            this.liVPhongHT.View = System.Windows.Forms.View.Details;
            // 
            // MaPhongHT
            // 
            this.MaPhongHT.Text = "Mã phòng";
            this.MaPhongHT.Width = 120;
            // 
            // TenPhong
            // 
            this.TenPhong.Text = "Tên Phòng";
            this.TenPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TenPhong.Width = 120;
            // 
            // TrangThai
            // 
            this.TrangThai.Text = "Trạng Thái";
            this.TrangThai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TrangThai.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(785, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 453);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.liVlichLV);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1142, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lịch làm việc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // liVlichLV
            // 
            this.liVlichLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaLich,
            this.NgayTruc,
            this.TenTGMo});
            this.liVlichLV.GridLines = true;
            this.liVlichLV.HideSelection = false;
            this.liVlichLV.Location = new System.Drawing.Point(4, 6);
            this.liVlichLV.Name = "liVlichLV";
            this.liVlichLV.Size = new System.Drawing.Size(1132, 591);
            this.liVlichLV.TabIndex = 0;
            this.liVlichLV.UseCompatibleStateImageBehavior = false;
            this.liVlichLV.View = System.Windows.Forms.View.Details;
            // 
            // MaLich
            // 
            this.MaLich.Text = "Mã Lịch";
            this.MaLich.Width = 500;
            // 
            // NgayTruc
            // 
            this.NgayTruc.Text = "Ngày Trực";
            this.NgayTruc.Width = 500;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(398, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "BỆNH ÁN SAU PHẨU THUẬT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 45);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // TenTGMo
            // 
            this.TenTGMo.Text = "Ca trực";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 686);
            this.Controls.Add(this.tabCtrlHT);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load_1);
            this.tabCtrlHT.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlHT;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView liVlichLV;
        private System.Windows.Forms.ColumnHeader MaLich;
        private System.Windows.Forms.ColumnHeader NgayTruc;
        private System.Windows.Forms.ListView liVPhongHT;
        private System.Windows.Forms.ColumnHeader MaPhongHT;
        private System.Windows.Forms.ColumnHeader TenPhong;
        private System.Windows.Forms.ColumnHeader TrangThai;
        private System.Windows.Forms.ColumnHeader TenTGMo;
    }
}