using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using BenhVienPT.Models;

namespace BenhVienPT
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult y = MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(y == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            WebBenhVienPTContext context = new WebBenhVienPTContext();
            string taiKhoan = txtName.Text;
            string matKhau = txtPass.Text;

            var acc = context.TaiKhoan
                .Include(x => x.IdvaiTroNavigation)
                .Where(x => x.TaiKhoan1.Equals(taiKhoan) && x.MatKhau.Equals(matKhau)).FirstOrDefault();

            if(acc == null)
            {
                MessageBox.Show("Đăng nhập thất bại!", "Lỗi đăng nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(acc.IdvaiTro == 1)
                {
                    Form2 form = new Form2(acc);
                    form.ShowDialog();
                }
                if(acc.IdvaiTro == 2)
                {
                    Form3 form1 = new Form3(acc);
                    form1.ShowDialog();
                }
            }
        }

       
    }
    
}
