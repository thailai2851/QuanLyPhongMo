using BenhVienPT.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BenhVienPT
{
    public partial class FormQuanLyPT : Form
    {
        //kết nối 
        static String connString = @"Data Source=LAPTOP-VIEL6S6A\THAILAI;Initial Catalog=WebBenhVienPT;Integrated Security=True";
        //khai báo
        SqlConnection sqlconnection = new SqlConnection(connString);
        SqlCommand sqlcommand;
        private TaiKhoan acc;

        //Mở kết nối
        private void Openconn()
        {
            if (sqlconnection == null)
            {
                sqlconnection = new SqlConnection(connString);
            }
            if (sqlconnection.State == ConnectionState.Closed)
            {
                sqlconnection.Open();
            }
        }
        //Đóng kết nối
        private void Closeconn()
        {
            if (sqlconnection.State == ConnectionState.Open && sqlconnection != null)
            {
                sqlconnection.Close();
            }
        }
        public FormQuanLyPT(Models.TaiKhoan acc)
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HienThiDSBenhAn();
        }

        private void HienThiDSBenhAn()
        {
            try
            {
                Openconn();
                sqlcommand = sqlconnection.CreateCommand();
                sqlcommand.CommandText = "select BA.MaBenhAn, BN.TenBN,B.TenBenh ,BA.GhiChu, BA.TrangThai, BA.YLenh, BN.GioiTinh, BN.NgaySinh, BN.SDT, BN.ChieuCao, BN.CanNang, B.MucDo  from BenhAn as BA inner join BenhNhan as BN on BA.IDBenhNhan = BN.ID inner join ChiTietBenhAn as CTBA on CTBA.ID = BA.ID inner join Benh as B on B.ID = CTBA.ID";
                SqlDataReader reader = sqlcommand.ExecuteReader();
                LivDSBenhAn.Items.Clear();
                while (reader.Read())
                {
                    string MaBenhAn = reader.GetString(0);
                    string TenBenhNhan = reader.GetString(1);
                    string LoaiBenh = reader.GetString(2);
                    string GhiChu = reader.GetString(3);
                    bool TrangThai = reader.GetBoolean(4);
                    string YLenh = reader.GetString(5);
                    string GioiTinh = reader.GetString(6);
                    DateTime NgaySinh = reader.GetDateTime(7);
                    string SDT = reader.GetString(8);
                    string chieuCao = reader.GetString(9);
                    string canNang = reader.GetString(10);
                    int mucDo = reader.GetInt32(11);
                    ListViewItem lvi = new ListViewItem(MaBenhAn);
                    lvi.SubItems.Add(TenBenhNhan);
                    lvi.SubItems.Add(LoaiBenh);
                    lvi.SubItems.Add(GhiChu);
                    lvi.SubItems.Add(TrangThai.ToString());
                    lvi.SubItems.Add(YLenh);
                    lvi.SubItems.Add(GioiTinh);
                    lvi.SubItems.Add(NgaySinh.ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(SDT);
                    lvi.SubItems.Add(chieuCao);
                    lvi.SubItems.Add(canNang);
                    lvi.SubItems.Add(mucDo.ToString());

                    LivDSBenhAn.Items.Add(lvi);
                }
                reader.Close();

            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HienThiDSBenhAn();
        }

        private void LivDSBenhAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaBA.ReadOnly = true;
            txtMaBA.ReadOnly = true;
            txtTenBN.ReadOnly = true;
            txtLoaiBenh.ReadOnly = true;
            txtTrangThai.ReadOnly = true;
            txtGioiTinh.ReadOnly = true;
            txtNgaySinh.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtChieuCao.ReadOnly = true;
            txtCanNang.ReadOnly = true;
            txtMucDo.ReadOnly = true;
            if (LivDSBenhAn.SelectedItems.Count == 0) return;
            ListViewItem lvi = LivDSBenhAn.SelectedItems[0];
            txtMaBA.Text = lvi.SubItems[0].Text;
            txtTenBN.Text = lvi.SubItems[1].Text;
            txtLoaiBenh.Text = lvi.SubItems[2].Text;
            txtGhiChu.Text = lvi.SubItems[3].Text;
            txtTrangThai.Text = lvi.SubItems[4].Text;
            txtYLenh.Text = lvi.SubItems[5].Text;
            txtGioiTinh.Text = lvi.SubItems[6].Text;
            txtNgaySinh.Text = lvi.SubItems[7].Text;
            txtSDT.Text = lvi.SubItems[8].Text;
            txtChieuCao.Text = lvi.SubItems[9].Text;
            txtCanNang.Text = lvi.SubItems[10].Text;
            txtMucDo.Text = lvi.SubItems[11].Text;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            if (txtTimKiem.Text != "")
            {
                // Tạo danh sách tạm thời chứa các mục thỏa mãn điều kiện tìm kiếm
                List<ListViewItem> matchingItems = new List<ListViewItem>();

                foreach (ListViewItem item in LivDSBenhAn.Items)
                {
                    if (item.SubItems[0].Text.ToLower().Contains(txtTimKiem.Text.ToLower()) ||
                        item.SubItems[1].Text.ToLower().Contains(txtTimKiem.Text.ToLower()) ||
                        item.SubItems[2].Text.ToLower().Contains(txtTimKiem.Text.ToLower()) )
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                        matchingItems.Add(item);
                    }
                }

                // Loại bỏ các mục không thỏa mãn khỏi danh sách
                LivDSBenhAn.Items.Clear();
                LivDSBenhAn.Items.AddRange(matchingItems.ToArray());

                if (LivDSBenhAn.SelectedItems.Count == 1)
                {
                    LivDSBenhAn.Focus();
                }
            

        }
            else
            {
                RefreshAll();
            }         

        }

        private void RefreshAll()
        {
            HienThiDSBenhAn();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (LivDSBenhAn.SelectedItems.Count>0)
            {
            //    string MaBA = LivDSBenhAn.SelectedItems[0].SubItems[0].Text;
            //    string TenBN = LivDSBenhAn.SelectedItems[0].SubItems[1].Text;
            //    string GioiTinh = LivDSBenhAn.SelectedItems[0].SubItems[2].Text;
            //    //DateTime NgaySinh = Convert.ToDateTime(LivDSBenhAn.SelectedItems[0].SubItems[3].Text);
            //    //string DiaChi = LivDSBenhAn.SelectedItems[0].SubItems[4].Text;
            //    //string SDT = LivDSBenhAn.SelectedItems[0].SubItems[5].Text;
            //    //string ChieuCao = LivDSBenhAn.SelectedItems[0].SubItems[6].Text;
            //    //string CanNang = LivDSBenhAn.SelectedItems[0].SubItems[7].Text;
            //    //string TenBenh = LivDSBenhAn.SelectedItems[0].SubItems[8].Text;
            //    //int MucDo = Convert.ToInt32(LivDSBenhAn.SelectedItems[0].SubItems[9].Text);
            //    //string GhiChu = LivDSBenhAn.SelectedItems[0].SubItems[10].Text;
            //    //bool TrangThai = Convert.ToBoolean(LivDSBenhAn.SelectedItems[0].SubItems[11].Text);
            //    //string YLenh = LivDSBenhAn.SelectedItems[0].SubItems[12].Text;

                FormChiTiet formct = new FormChiTiet(acc);
                formct.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chọn bệnh án cần xem chi tiết!");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Openconn();
                sqlcommand = sqlconnection.CreateCommand();
                sqlcommand.CommandText = sqlcommand.CommandText = "update BenhAn set GhiChu = '" + txtGhiChu.Text + "', YLenh = '" + txtYLenh.Text + "' where MaBenhAn='" + txtMaBA.Text + "'";
                int kq = sqlcommand.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Cập nhật thành công !");
                    HienThiDSBenhAn();
                    txtGhiChu.Clear();
                    txtYLenh.Clear();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          DialogResult y =  MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (y == DialogResult.Yes)
            {
                MessageBox.Show("Đăng xuất thành công!");
                this.Hide();
                FormDangNhap logout = new FormDangNhap();
                logout.ShowDialog();
                this.Close();
            }
        }
    }
}

