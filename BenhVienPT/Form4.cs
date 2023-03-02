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
    public partial class Form4 : Form
    {
        //kết nối 
        static String connString = @"Data Source=DESKTOP-K2D95L4\ANHLOC;Initial Catalog=WebBenhVienPT;User ID=sa;Password=123456";
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
        public Form4(Models.TaiKhoan acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            HienThiDSphongHT();
            LoadLichLam();
        }

        private void HienThiDSphongHT()
        {
            try
            {
                Openconn();
                sqlcommand = sqlconnection.CreateCommand();
                sqlcommand.CommandText = "select MaPhongHT, TenPhong, TrangThai from PhongHoiTinh";
                SqlDataReader reader = sqlcommand.ExecuteReader();
                liVPhongHT.Items.Clear();
                while (reader.Read())
                {
                    string MaPhongHT = reader.GetString(0);
                    string TenPhong = reader.GetString(1);
                    bool TrangThai = reader.GetBoolean(2);
           
                    ListViewItem lvi = new ListViewItem(MaPhongHT);
                                lvi.SubItems.Add(TenPhong);
                                lvi.SubItems.Add(TrangThai.ToString());
                
                    liVPhongHT.Items.Add(lvi);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadLichLam()
        {
            try
            {

                Openconn();
                int idnv = NhanVien.GetIdNV(acc.Id).Id;
                sqlcommand = sqlconnection.CreateCommand();
                sqlcommand.CommandText = "SELECT  LT.NgayTruc, TGM.TenTGMo FROM LichTruc as LT join TGMo as TGM  on LT.MaTGMo = TGM.ID where IDNV = @idnv AND NgayTruc >= GETDATE()";
                sqlcommand.Parameters.AddWithValue("@idnv", idnv);
                SqlDataReader reader = sqlcommand.ExecuteReader();
                liVlichLV.Items.Clear();
                while (reader.Read())
                {
                    
                    DateTime NgayTruc = reader.GetDateTime(0);
                    string TenTGMo = reader.GetString(1);
                    ListViewItem lvi = new ListViewItem(NgayTruc.ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(TenTGMo);
                    liVlichLV.Items.Add(lvi);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
