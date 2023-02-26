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
    public partial class Form2 : Form
    {
        //kết nối 
        static String connString = @"Data Source=LAPTOP-VIEL6S6A\THAILAI;Initial Catalog=WebBenhVienPT;Integrated Security=True";
        //khai báo
        SqlConnection sqlconnection = new SqlConnection(connString);
        SqlCommand sqlcommand;
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
        public Form2(Models.TaiKhoan acc)
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
                sqlcommand.CommandText = "select BA.MaBenhAn, BN.TenBN, NV.TenNV, BA.GhiChu, BA.TrangThai, BA.YLenh from BenhAn as BA inner join BenhNhan as BN on BA.IDBenhNhan = BN.ID inner join NhanVien as NV on NV.ID = BA.IDNV";
                SqlDataReader reader = sqlcommand.ExecuteReader();
                LivDSBenhAn.Items.Clear();
                while (reader.Read())
                {
                    string MaBenhAn = reader.GetString(0);
                    string TenBenhNhan = reader.GetString(1);
                    string NVPhuTrach = reader.GetString(2);
                    string GhiChu = reader.GetString(3);
                    bool TrangThai = reader.GetBoolean(4);
                    string YLenh = reader.GetString(5);
                    ListViewItem lvi = new ListViewItem(MaBenhAn);
                    lvi.SubItems.Add(TenBenhNhan);
                    lvi.SubItems.Add(NVPhuTrach);
                    lvi.SubItems.Add(GhiChu);
                    lvi.SubItems.Add(TrangThai.ToString());
                    lvi.SubItems.Add(YLenh);
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
            if (LivDSBenhAn.SelectedItems.Count == 0) return;
            ListViewItem lvi = LivDSBenhAn.SelectedItems[0];
            txtMaBA.Text = lvi.SubItems[0].Text;
            txtTenBN.Text = lvi.SubItems[1].Text;
            txtNVPhuTrach.Text = lvi.SubItems[2].Text;
            txtGhiChu.Text = lvi.SubItems[3].Text;
            txtTrangThai.Text = lvi.SubItems[4].Text;
            txtYLenh.Text = lvi.SubItems[5].Text;
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
             
        }
    }
}

