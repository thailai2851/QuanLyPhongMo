﻿
namespace BenhVienPT
{
    partial class FormQuanLyPT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTaiKhoan = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMucDo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChieuCao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtYLenh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoaiBenh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaBA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LivDSBenhAn = new System.Windows.Forms.ListView();
            this.MaBenhAn = new System.Windows.Forms.ColumnHeader();
            this.TenBenhNhan = new System.Windows.Forms.ColumnHeader();
            this.IDNhanVien = new System.Windows.Forms.ColumnHeader();
            this.GhiChu = new System.Windows.Forms.ColumnHeader();
            this.TrangThai = new System.Windows.Forms.ColumnHeader();
            this.YLenh = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTaiKhoan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1844, 48);
            this.panel1.TabIndex = 0;
            // 
            // lbTaiKhoan
            // 
            this.lbTaiKhoan.AutoSize = true;
            this.lbTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbTaiKhoan.Location = new System.Drawing.Point(1720, 9);
            this.lbTaiKhoan.Name = "lbTaiKhoan";
            this.lbTaiKhoan.Size = new System.Drawing.Size(112, 26);
            this.lbTaiKhoan.TabIndex = 1;
            this.lbTaiKhoan.TabStop = true;
            this.lbTaiKhoan.Text = "Đăng xuất";
            this.lbTaiKhoan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbTaiKhoan_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(750, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LỊCH PHẪU THUẬT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1844, 639);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1836, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý bệnh án";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.LivDSBenhAn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1830, 522);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bệnh án";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMucDo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtChieuCao);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSDT);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtNgaySinh);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtCanNang);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtGioiTinh);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtYLenh);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtTrangThai);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtLoaiBenh);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtTenBN);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtGhiChu);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMaBA);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(814, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1013, 493);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // txtMucDo
            // 
            this.txtMucDo.Location = new System.Drawing.Point(647, 362);
            this.txtMucDo.Name = "txtMucDo";
            this.txtMucDo.Size = new System.Drawing.Size(347, 30);
            this.txtMucDo.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mức độ:";
            // 
            // txtChieuCao
            // 
            this.txtChieuCao.Location = new System.Drawing.Point(647, 298);
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Size = new System.Drawing.Size(347, 30);
            this.txtChieuCao.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(522, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Chiều cao:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(647, 170);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(347, 30);
            this.txtSDT.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(522, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "SĐT:";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(647, 106);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(347, 30);
            this.txtNgaySinh.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(522, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ngày sinh:";
            // 
            // txtCanNang
            // 
            this.txtCanNang.Location = new System.Drawing.Point(647, 234);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(347, 30);
            this.txtCanNang.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(522, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 22);
            this.label12.TabIndex = 15;
            this.label12.Text = "Cân nặng:";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(647, 42);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(347, 30);
            this.txtGioiTinh.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(522, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 22);
            this.label13.TabIndex = 13;
            this.label13.Text = "Giới tính:";
            // 
            // txtYLenh
            // 
            this.txtYLenh.Location = new System.Drawing.Point(131, 362);
            this.txtYLenh.Name = "txtYLenh";
            this.txtYLenh.Size = new System.Drawing.Size(347, 30);
            this.txtYLenh.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Y lệnh:";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(131, 298);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(347, 30);
            this.txtTrangThai.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Trạng thái:";
            // 
            // txtLoaiBenh
            // 
            this.txtLoaiBenh.Location = new System.Drawing.Point(131, 170);
            this.txtLoaiBenh.Name = "txtLoaiBenh";
            this.txtLoaiBenh.Size = new System.Drawing.Size(347, 30);
            this.txtLoaiBenh.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Loại bệnh:";
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(131, 106);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(347, 30);
            this.txtTenBN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên bệnh nhân:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(131, 234);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(347, 30);
            this.txtGhiChu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi chú:";
            // 
            // txtMaBA
            // 
            this.txtMaBA.Location = new System.Drawing.Point(131, 42);
            this.txtMaBA.Name = "txtMaBA";
            this.txtMaBA.Size = new System.Drawing.Size(347, 30);
            this.txtMaBA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã bệnh án:";
            // 
            // LivDSBenhAn
            // 
            this.LivDSBenhAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaBenhAn,
            this.TenBenhNhan,
            this.IDNhanVien,
            this.GhiChu,
            this.TrangThai,
            this.YLenh});
            this.LivDSBenhAn.Dock = System.Windows.Forms.DockStyle.Left;
            this.LivDSBenhAn.FullRowSelect = true;
            this.LivDSBenhAn.GridLines = true;
            this.LivDSBenhAn.HideSelection = false;
            this.LivDSBenhAn.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.LivDSBenhAn.Location = new System.Drawing.Point(3, 26);
            this.LivDSBenhAn.Name = "LivDSBenhAn";
            this.LivDSBenhAn.Size = new System.Drawing.Size(811, 493);
            this.LivDSBenhAn.TabIndex = 0;
            this.LivDSBenhAn.UseCompatibleStateImageBehavior = false;
            this.LivDSBenhAn.View = System.Windows.Forms.View.Details;
            this.LivDSBenhAn.SelectedIndexChanged += new System.EventHandler(this.LivDSBenhAn_SelectedIndexChanged);
            // 
            // MaBenhAn
            // 
            this.MaBenhAn.Text = "Mã bệnh án";
            this.MaBenhAn.Width = 120;
            // 
            // TenBenhNhan
            // 
            this.TenBenhNhan.Text = "Tên bệnh nhân";
            this.TenBenhNhan.Width = 130;
            // 
            // IDNhanVien
            // 
            this.IDNhanVien.Text = "Loại bệnh";
            this.IDNhanVien.Width = 170;
            // 
            // GhiChu
            // 
            this.GhiChu.Text = "Ghi chú";
            this.GhiChu.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.Text = "Trạng thái";
            this.TrangThai.Width = 100;
            // 
            // YLenh
            // 
            this.YLenh.Text = "Y lệnh";
            this.YLenh.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1830, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(934, 18);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(138, 50);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(99, 29);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(649, 30);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(1401, 20);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(113, 48);
            this.btnCapNhat.TabIndex = 12;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1836, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý ca mổ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormQuanLyPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 687);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormQuanLyPT";
            this.Text = "Form Quản Lý";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView LivDSBenhAn;
        private System.Windows.Forms.ColumnHeader MaBenhAn;
        private System.Windows.Forms.ColumnHeader TenBenhNhan;
        private System.Windows.Forms.ColumnHeader IDNhanVien;
        private System.Windows.Forms.ColumnHeader GhiChu;
        private System.Windows.Forms.ColumnHeader TrangThai;
        private System.Windows.Forms.ColumnHeader YLenh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaBA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYLenh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoaiBenh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lbTaiKhoan;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtMucDo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChieuCao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label13;
    }
}