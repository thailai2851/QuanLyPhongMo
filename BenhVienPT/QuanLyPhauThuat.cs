using BenhVienPT.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            this.acc = acc;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HienThiDSBenhAn();

            //  HienThiDSLichTruc();
            HienThiDSCaMo();
            LoadLichLam("");

        }

        private void HienThiDSCaMo()
        {
            try
            {
                Openconn();
                sqlcommand = sqlconnection.CreateCommand();
                sqlcommand.CommandText = "SELECT distinct bh.mabenhan, bn.TenBN, b.tenbenh, b.mucdo, bh.trangthai, b.id as idBenh, bh.id as idBenhAn, cm.id as idCaMo,lm.Ngay " +
        "FROM benhan bh " +
        "inner join CaMo cm on cm.IDBenhAn = bh.ID " +
        "INNER JOIN BenhNhan bn ON bn.ID = bh.IDBenhNhan " +
        "INNER JOIN chitietbenhan cb ON bh.id = cb.idbenhan " +
        "INNER JOIN benh b ON cb.idbenh = b.id " +
        "inner join LichMo lm on lm.IDCM = cm.id " +
        "INNER JOIN ( " +
        "SELECT cb.idbenhan, MAX(b.mucdo) AS max_mucdo " +
        "FROM chitietbenhan cb " +
        "INNER JOIN benh b ON cb.idbenh = b.id " +
        "GROUP BY cb.idbenhan " +
        ") max_benh ON cb.idbenhan = max_benh.idbenhan AND b.mucdo = max_benh.max_mucdo " +
        "WHERE bh.trangthai = 1 " +
        "ORDER BY b.mucdo DESC";
                SqlDataReader reader = sqlcommand.ExecuteReader();
                livCaMo.Items.Clear();
                while (reader.Read())
                {
                    string MaBenhAn = reader.GetString(0);
                    string TenBenhNhan = reader.GetString(1);
                    string LoaiBenh = reader.GetString(2);
                    int mucDo = reader.GetInt32(3);
                    bool TrangThai = reader.GetBoolean(4);
                    int id = reader.GetInt32(5);
                    int idba = reader.GetInt32(6);
                    int idCaMo = reader.GetInt32(7);
                    DateTime ngay = reader.GetDateTime(8);



                    ListViewItem lvi = new ListViewItem(MaBenhAn);
                    lvi.SubItems.Add(TenBenhNhan);
                    lvi.SubItems.Add(LoaiBenh);
                    lvi.SubItems.Add(mucDo.ToString());
                    lvi.SubItems.Add(TrangThai.ToString());
                    lvi.SubItems.Add(id.ToString());
                    lvi.SubItems.Add(idba.ToString());
                    lvi.SubItems.Add(idCaMo.ToString());
                    lvi.SubItems.Add(ngay.ToString("yyyy/MM/dd"));


                    livCaMo.Items.Add(lvi);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HienThiDSBenhAn()
        {
            try
            {
                Openconn();
                sqlcommand = sqlconnection.CreateCommand();
                sqlcommand.CommandText = "select BA.MaBenhAn, BN.TenBN, B.TenBenh, B.MucDo, BA.TrangThai, BA.GhiChu, BA.YLenh, BN.GioiTinh, BN.NgaySinh, BN.SDT  from BenhAn as BA inner join BenhNhan as BN on BA.IDBenhNhan = BN.ID inner join ChiTietBenhAn as CTBA on CTBA.IDBenhAn = BA.ID inner join Benh as B on B.ID = CTBA.IDBenh";
                SqlDataReader reader = sqlcommand.ExecuteReader();
                LivDSBenhAn.Items.Clear();
                while (reader.Read())
                {
                    string MaBenhAn = reader.GetString(0);
                    string TenBenhNhan = reader.GetString(1);
                    string LoaiBenh = reader.GetString(2);
                    int mucDo = reader.GetInt32(3);
                    bool TrangThai = reader.GetBoolean(4);
                    string GhiChu = reader.GetString(5);
                    string YLenh = reader.GetString(6);
                    string GioiTinh = reader.GetString(7);
                    DateTime NgaySinh = reader.GetDateTime(8);
                    string SDT = reader.GetString(9);          
           
                    ListViewItem lvi = new ListViewItem(MaBenhAn);
                    lvi.SubItems.Add(TenBenhNhan);
                    lvi.SubItems.Add(LoaiBenh);
                    lvi.SubItems.Add(mucDo.ToString());
                    lvi.SubItems.Add(TrangThai.ToString());
                    lvi.SubItems.Add(GhiChu);
                    lvi.SubItems.Add(YLenh);
                    lvi.SubItems.Add(GioiTinh);
                    lvi.SubItems.Add(NgaySinh.ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(SDT);       

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
            txtMucDo.ReadOnly = true;
            txtGhiChu.ReadOnly = true;
            txtYLenh.ReadOnly = true;
            if (LivDSBenhAn.SelectedItems.Count == 0) return;
            ListViewItem lvi = LivDSBenhAn.SelectedItems[0];
            txtMaBA.Text = lvi.SubItems[0].Text;
            txtTenBN.Text = lvi.SubItems[1].Text;
            txtLoaiBenh.Text = lvi.SubItems[2].Text;
            txtMucDo.Text = lvi.SubItems[3].Text;
            txtTrangThai.Text = lvi.SubItems[4].Text;
            txtGhiChu.Text = lvi.SubItems[5].Text;
            txtYLenh.Text = lvi.SubItems[6].Text;
            txtGioiTinh.Text = lvi.SubItems[7].Text;
            txtNgaySinh.Text = lvi.SubItems[8].Text;
            txtSDT.Text = lvi.SubItems[9].Text;
    
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
                        item.SubItems[2].Text.ToLower().Contains(txtTimKiem.Text.ToLower()) ||
                         item.SubItems[3].Text.ToLower().Contains(txtTimKiem.Text.ToLower()))
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

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDatLich formdatlich = new FormDatLich(acc);
            formdatlich.ShowDialog();
            this.Close();
        }

        private void txtTimKiemCaMo_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemCaMo.Text != "")
            {
                // Tạo danh sách tạm thời chứa các mục thỏa mãn điều kiện tìm kiếm
                List<ListViewItem> matchingItems = new List<ListViewItem>();

                foreach (ListViewItem item in livCaMo.Items)
                {
                    if (item.SubItems[0].Text.ToLower().Contains(txtTimKiemCaMo.Text.ToLower()) ||
                        item.SubItems[1].Text.ToLower().Contains(txtTimKiemCaMo.Text.ToLower()) ||
                        item.SubItems[2].Text.ToLower().Contains(txtTimKiemCaMo.Text.ToLower()) ||
                         item.SubItems[3].Text.ToLower().Contains(txtTimKiemCaMo.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                        matchingItems.Add(item);
                    }
                }

                // Loại bỏ các mục không thỏa mãn khỏi danh sách
                livCaMo.Items.Clear();
                livCaMo.Items.AddRange(matchingItems.ToArray());

                if (livCaMo.SelectedItems.Count == 1)
                {
                    livCaMo.Focus();
                }


            }
            else
            {
                RefreshAll1();
            }

        }

        private void RefreshAll1()
        {
            HienThiDSCaMo();
        }

        private void livCaMo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cklBacSiCM.Items.Clear();
            cklYtaCM.Items.Clear();
            if (livCaMo.SelectedItems.Count == 0) return;
            ListViewItem lvi = livCaMo.SelectedItems[0];
            txtMaBACM.Text = lvi.SubItems[0].Text;
            txtTenBNCaMo.Text = lvi.SubItems[1].Text;

            string idCaMo = livCaMo.SelectedItems[0].SubItems[7].Text;
            string idb = livCaMo.SelectedItems[0].SubItems[5].Text;
            string dinhdang = livCaMo.SelectedItems[0].SubItems[8].Text;

            

            HienThiThongTinCaMo(Convert.ToInt32(idCaMo));
            HienThiBS(Convert.ToInt32(idCaMo));
            HienThiYTa(Convert.ToInt32(idCaMo));
            HienThiDSPhongMo(idb,dinhdang);


        }

        private void HienThiThongTinCaMo(int idCaMo)
        {
            Openconn();
            string query = "SELECT DISTINCT lm.Ngay, lm.CaMo, pm.id, pm.TenPhongMo, tg.TenTGMo, pht.TenPhong " +
"FROM LichMo as lm " +
"INNER JOIN CaMo cm ON cm.ID = lm.IDCM " +
"INNER JOIN PhongMo pm ON pm.ID = cm.IDPhongMo " +
"INNER JOIN TGMo tg ON tg.id = lm.CaMo " +
"inner join PhongHoiTinh pht on pht.ID = cm.IDPhongHoiTinh " +
"WHERE cm.ID = @idCaMo"; 
            SqlCommand command = new SqlCommand(query, sqlconnection);
            command.Parameters.AddWithValue("@idCaMo", idCaMo);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            DateTime ngay = reader.GetDateTime(0);
            dtpTGCaMo.Value = ngay;

            cbxCaMoCM.Items.Clear();
            cbxPhongMoCM.Items.Clear();
            cbxPhongHoiTinh.Items.Clear();
            cbxPhongMoCM.Text = reader.GetString(3);
            cbxCaMoCM.Text = reader.GetString(4);
            cbxPhongHoiTinh.Text = reader.GetString(5);
            Closeconn();

            
        }
        private void HienThiBS(int idcamo)
        {
            Openconn();
            string query1 = "select distinct nv.tennv from lichmo as lm " +
                            "inner join camo cm on cm.id = lm.idcm " +
                            "inner join nhanvien nv on nv.id = lm.idnv " +
                            "inner join taikhoan tk on tk.id = nv.idtaikhoan " +
                            "inner join vaitro vt on vt.id = tk.idvaitro " +
                            "where cm.id = @idcamo and vt.id = 4";

            SqlCommand command1 = new SqlCommand(query1, sqlconnection);
            command1.Parameters.AddWithValue("@idcamo", idcamo);
            SqlDataReader reader1 = command1.ExecuteReader();
            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    // assuming you have a checked list box named 'cklbacsicm'
                    cklBacSiCM.Items.Add(reader1["tennv"], true);
                }
            }
            reader1.Close();
        }

        private void HienThiYTa(int idcamo)
        {
            Openconn();
            string query1 = "select distinct nv.tennv from lichmo as lm " +
                            "inner join camo cm on cm.id = lm.idcm " +
                            "inner join nhanvien nv on nv.id = lm.idnv " +
                            "inner join taikhoan tk on tk.id = nv.idtaikhoan " +
                            "inner join vaitro vt on vt.id = tk.idvaitro " +
                            "where cm.id = @idcamo and vt.id = 2";

            SqlCommand command1 = new SqlCommand(query1, sqlconnection);
            command1.Parameters.AddWithValue("@idcamo", idcamo);
            SqlDataReader reader1 = command1.ExecuteReader();
            if (reader1.HasRows)
            {
                while (reader1.Read())
                {
                    // assuming you have a checked list box named 'cklbacsicm'
                    cklYtaCM.Items.Add(reader1["tennv"], true);
                }
            }
            reader1.Close();
        }
        private void HienThiDSPhongMo(string maBenh, string ngay)
        {
            Openconn();

            string query = "SELECT DISTINCT ctpm.IDPM, PM.TenPhongMo as Display FROM PhongMo as PM " +
                  "INNER JOIN ChiTietPhongBenh as CTPB ON CTPB.IDPM = PM.ID " +
                  "INNER JOIN Benh as B ON B.ID = CTPB.IDB " +
                  "INNER JOIN ChiTietPhongMo as ctpm on ctpm.IDPM = pm.id " +
                  "WHERE b.id = '" + maBenh + "' and ctpm.ngay = '" + ngay + "' and ctpm.TrangThai = 'false'";
            SqlCommand command = new SqlCommand(query, sqlconnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);



            if (table.Rows.Count > 0)
            {
                cbxPhongMoCM.DataSource = table;
                cbxPhongMoCM.ValueMember = "IDPM";
                cbxPhongMoCM.DisplayMember = "Display";
            }
            else
            {
                cbxPhongMoCM.DataSource = null;
            }


            // Đọc kết quả truy vấn và thêm các phòng còn trống vào ComboBox

        }
        private void HienThiDSCaMo(int maPM, string TGDatLich)
        {
            Openconn();

            string query = "SELECT CTPM.IDtgm as ID, TGM.TenTGMo FROM PhongMo as PM  INNER JOIN ChiTietPhongMo as CTPM ON CTPM.IDPM = PM.ID INNER JOIN TGMo as TGM ON TGM.ID = CTPM.IDTGM where CTPM.Ngay = '" + TGDatLich + "' and CTPM.TrangThai = 0 and PM.id = '" + maPM + "'";
            SqlCommand command = new SqlCommand(query, sqlconnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            cbxCaMoCM.DataSource = table;
            cbxCaMoCM.ValueMember = "ID";
            cbxCaMoCM.DisplayMember = "TenTGMo";
        }

        private void cbxPhongMoCM_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime TGDatLich1 = dtpTGCaMo.Value.Date;
            string dinhdang = TGDatLich1.ToString("yyyy-MM-dd");
            int selectedID = 0;
            object selectedItem = cbxPhongMoCM.SelectedItem;
            if (selectedItem != null)
            {
                DataRowView row = (DataRowView)selectedItem;
                selectedID = Convert.ToInt32(row["IDPM"]);
                HienThiDSCaMo(selectedID, dinhdang);
            }
        }

        private void dtpChonNgayLT_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpChonNgayLT.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");
            LoadLichLam(formattedDate);
        }

        private void LoadLichLam(string day)
        {
            try
            {
                Openconn();
                int idnv = NhanVien.GetIdNV(acc.Id).Id;
                sqlcommand = sqlconnection.CreateCommand();
                if (day == "")
                {

                    sqlcommand.CommandText = "SELECT  LT.NgayTruc, TGM.TenTGMo FROM LichTruc as LT  inner join TGMo as TGM  on lt.IDTGMo = tgm.ID where IDNV = @idnv AND NgayTruc >= CONVERT(varchar, GETDATE(), 111)";
                }
                else
                {
                    sqlcommand.CommandText = "SELECT  LT.NgayTruc, TGM.TenTGMo FROM LichTruc as LT join TGMo as TGM  on LT.IDTGMo = TGM.ID where IDNV = @idnv AND NgayTruc = '" + day + "'";
                }
                sqlcommand.Parameters.AddWithValue("@idnv", idnv);
                SqlDataReader reader = sqlcommand.ExecuteReader();
                livLichTruc.Items.Clear();
                while (reader.Read())
                {

                    DateTime NgayTruc = reader.GetDateTime(0);
                    string thu = NgayTruc.ToString("dddd", new CultureInfo("vi-VN")); // Lấy tên của ngày trong tuần từ cột NgayTruc
                    string TenTGMo = reader.GetString(1);
                    ListViewItem lvi = new ListViewItem(NgayTruc.ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(thu); // Thêm giá trị của cột mới "Ngày trong tuần"
                    lvi.SubItems.Add(TenTGMo);
                    livLichTruc.Items.Add(lvi);
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

