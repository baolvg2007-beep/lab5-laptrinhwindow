using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nạp danh sách khóa học vào ComboBox
            List<KhoaHoc> dsKhoaHoc = new List<KhoaHoc>
            {
                new KhoaHoc("C# WinForms cơ bản", 800000m),
                new KhoaHoc("SQL Server cơ bản", 700000m),
                new KhoaHoc("Web Frontend cơ bản", 750000m),
                new KhoaHoc("Lập trình Python cơ bản", 650000m)
            };

            cboKhoaHoc.DataSource = dsKhoaHoc;
            cboKhoaHoc.DisplayMember = "TenKhoaHoc";
            cboKhoaHoc.ValueMember = "HocPhiThang";

            // Chọn mặc định khóa học đầu tiên
            if (cboKhoaHoc.Items.Count > 0)
            {
                cboKhoaHoc.SelectedIndex = 0;
            }

            // Chọn mặc định hình thức Online
            radOnline.Checked = true;

            // Thiết lập số tháng tối thiểu là 1, tối đa là 12
            numSoThang.Minimum = 1;
            numSoThang.Maximum = 12;
            numSoThang.Value = 1;

            // Hiển thị tổng học phí ban đầu
            TinhTongTien();
        }

        private void TinhTongTien()
        {
            if (cboKhoaHoc.SelectedItem is KhoaHoc kh)
            {
                decimal tongTien = kh.HocPhiThang * numSoThang.Value;
                lblTongTien.Text = string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:N0} VNĐ", tongTien);
            }
            else
            {
                lblTongTien.Text = "0 VNĐ";
            }
        }

        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void numSoThang_ValueChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra họ tên không được rỗng
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // Kiểm tra số điện thoại không được rỗng
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            // Kiểm tra phải chọn khóa học
            if (cboKhoaHoc.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhoaHoc.Focus();
                return;
            }

            // Lấy thông tin
            KhoaHoc kh = (KhoaHoc)cboKhoaHoc.SelectedItem;
            decimal tongTien = kh.HocPhiThang * numSoThang.Value;
            string strTongTien = string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:N0} VNĐ", tongTien);
            string hinhThuc = radOnline.Checked ? "Online" : "Trực tiếp";
            string nhanEmail = chkNhanEmail.Checked ? "Có" : "Không";

            // Hiển thị phiếu đăng ký
            string thongTin = $"--- PHIẾU ĐĂNG KÝ KHÓA HỌC ---\n\n" +
                              $"Họ và tên: {txtHoTen.Text.Trim()}\n" +
                              $"Số điện thoại: {txtSoDienThoai.Text.Trim()}\n" +
                              $"Ngày sinh: {dtpNgaySinh.Value:dd/MM/yyyy}\n" +
                              $"Khóa học: {kh.TenKhoaHoc}\n" +
                              $"Hình thức học: {hinhThuc}\n" +
                              $"Số tháng đăng ký: {numSoThang.Value} tháng\n" +
                              $"Tổng học phí: {strTongTien}\n" +
                              $"Nhận email thông báo: {nhanEmail}";

            MessageBox.Show(thongTin, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            chkNhanEmail.Checked = false;

            if (cboKhoaHoc.Items.Count > 0)
            {
                cboKhoaHoc.SelectedIndex = 0;
            }

            radOnline.Checked = true;
            numSoThang.Value = 1;
            txtHoTen.Focus();

            TinhTongTien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
