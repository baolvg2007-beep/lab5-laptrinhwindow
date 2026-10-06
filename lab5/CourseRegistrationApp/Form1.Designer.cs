namespace lab5
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThongTinHocVien = new System.Windows.Forms.GroupBox();
            this.chkNhanEmail = new System.Windows.Forms.CheckBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.grpThongTinKhoaHoc = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTienTitle = new System.Windows.Forms.Label();
            this.numSoThang = new System.Windows.Forms.NumericUpDown();
            this.lblSoThang = new System.Windows.Forms.Label();
            this.radOffline = new System.Windows.Forms.RadioButton();
            this.radOnline = new System.Windows.Forms.RadioButton();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpThongTinHocVien.SuspendLayout();
            this.grpThongTinKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(640, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG KÝ KHÓA HỌC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTinHocVien
            // 
            this.grpThongTinHocVien.Controls.Add(this.chkNhanEmail);
            this.grpThongTinHocVien.Controls.Add(this.dtpNgaySinh);
            this.grpThongTinHocVien.Controls.Add(this.lblNgaySinh);
            this.grpThongTinHocVien.Controls.Add(this.txtSoDienThoai);
            this.grpThongTinHocVien.Controls.Add(this.lblSoDienThoai);
            this.grpThongTinHocVien.Controls.Add(this.txtHoTen);
            this.grpThongTinHocVien.Controls.Add(this.lblHoTen);
            this.grpThongTinHocVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinHocVien.Location = new System.Drawing.Point(20, 55);
            this.grpThongTinHocVien.Name = "grpThongTinHocVien";
            this.grpThongTinHocVien.Size = new System.Drawing.Size(600, 155);
            this.grpThongTinHocVien.TabIndex = 1;
            this.grpThongTinHocVien.TabStop = false;
            this.grpThongTinHocVien.Text = "Thông tin học viên";
            // 
            // chkNhanEmail
            // 
            this.chkNhanEmail.AutoSize = true;
            this.chkNhanEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNhanEmail.Location = new System.Drawing.Point(130, 115);
            this.chkNhanEmail.Name = "chkNhanEmail";
            this.chkNhanEmail.Size = new System.Drawing.Size(155, 21);
            this.chkNhanEmail.TabIndex = 6;
            this.chkNhanEmail.Text = "Nhận email thông báo";
            this.chkNhanEmail.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(420, 72);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 25);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(335, 75);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(69, 17);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(130, 72);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(180, 25);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(20, 75);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(88, 17);
            this.lblSoDienThoai.TabIndex = 2;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(130, 32);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(440, 25);
            this.txtHoTen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(20, 35);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(67, 17);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // grpThongTinKhoaHoc
            // 
            this.grpThongTinKhoaHoc.Controls.Add(this.lblTongTien);
            this.grpThongTinKhoaHoc.Controls.Add(this.lblTongTienTitle);
            this.grpThongTinKhoaHoc.Controls.Add(this.numSoThang);
            this.grpThongTinKhoaHoc.Controls.Add(this.lblSoThang);
            this.grpThongTinKhoaHoc.Controls.Add(this.radOffline);
            this.grpThongTinKhoaHoc.Controls.Add(this.radOnline);
            this.grpThongTinKhoaHoc.Controls.Add(this.lblHinhThuc);
            this.grpThongTinKhoaHoc.Controls.Add(this.cboKhoaHoc);
            this.grpThongTinKhoaHoc.Controls.Add(this.lblKhoaHoc);
            this.grpThongTinKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinKhoaHoc.Location = new System.Drawing.Point(20, 220);
            this.grpThongTinKhoaHoc.Name = "grpThongTinKhoaHoc";
            this.grpThongTinKhoaHoc.Size = new System.Drawing.Size(600, 165);
            this.grpThongTinKhoaHoc.TabIndex = 2;
            this.grpThongTinKhoaHoc.TabStop = false;
            this.grpThongTinKhoaHoc.Text = "Thông tin khóa học";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(130, 120);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(60, 21);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // lblTongTienTitle
            // 
            this.lblTongTienTitle.AutoSize = true;
            this.lblTongTienTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienTitle.Location = new System.Drawing.Point(20, 123);
            this.lblTongTienTitle.Name = "lblTongTienTitle";
            this.lblTongTienTitle.Size = new System.Drawing.Size(90, 17);
            this.lblTongTienTitle.TabIndex = 7;
            this.lblTongTienTitle.Text = "Tổng học phí:";
            // 
            // numSoThang
            // 
            this.numSoThang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoThang.Location = new System.Drawing.Point(420, 73);
            this.numSoThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numSoThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoThang.Name = "numSoThang";
            this.numSoThang.Size = new System.Drawing.Size(150, 25);
            this.numSoThang.TabIndex = 6;
            this.numSoThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoThang.ValueChanged += new System.EventHandler(this.numSoThang_ValueChanged);
            // 
            // lblSoThang
            // 
            this.lblSoThang.AutoSize = true;
            this.lblSoThang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoThang.Location = new System.Drawing.Point(335, 75);
            this.lblSoThang.Name = "lblSoThang";
            this.lblSoThang.Size = new System.Drawing.Size(63, 17);
            this.lblSoThang.TabIndex = 5;
            this.lblSoThang.Text = "Số tháng:";
            // 
            // radOffline
            // 
            this.radOffline.AutoSize = true;
            this.radOffline.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOffline.Location = new System.Drawing.Point(210, 73);
            this.radOffline.Name = "radOffline";
            this.radOffline.Size = new System.Drawing.Size(73, 21);
            this.radOffline.TabIndex = 4;
            this.radOffline.TabStop = true;
            this.radOffline.Text = "Trực tiếp";
            this.radOffline.UseVisualStyleBackColor = true;
            // 
            // radOnline
            // 
            this.radOnline.AutoSize = true;
            this.radOnline.Checked = true;
            this.radOnline.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOnline.Location = new System.Drawing.Point(130, 73);
            this.radOnline.Name = "radOnline";
            this.radOnline.Size = new System.Drawing.Size(63, 21);
            this.radOnline.TabIndex = 3;
            this.radOnline.TabStop = true;
            this.radOnline.Text = "Online";
            this.radOnline.UseVisualStyleBackColor = true;
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinhThuc.Location = new System.Drawing.Point(20, 75);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(92, 17);
            this.lblHinhThuc.TabIndex = 2;
            this.lblHinhThuc.Text = "Hình thức học:";
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoaHoc.FormattingEnabled = true;
            this.cboKhoaHoc.Location = new System.Drawing.Point(130, 32);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(440, 25);
            this.cboKhoaHoc.TabIndex = 1;
            this.cboKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cboKhoaHoc_SelectedIndexChanged);
            // 
            // lblKhoaHoc
            // 
            this.lblKhoaHoc.AutoSize = true;
            this.lblKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoaHoc.Location = new System.Drawing.Point(20, 35);
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.Size = new System.Drawing.Size(66, 17);
            this.lblKhoaHoc.TabIndex = 0;
            this.lblKhoaHoc.Text = "Khóa học:";
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(140, 400);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(110, 38);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(265, 400);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 38);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(390, 400);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 38);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDangKy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 460);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.grpThongTinKhoaHoc);
            this.Controls.Add(this.grpThongTinHocVien);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG KÝ KHÓA HỌC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpThongTinHocVien.ResumeLayout(false);
            this.grpThongTinHocVien.PerformLayout();
            this.grpThongTinKhoaHoc.ResumeLayout(false);
            this.grpThongTinKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTinHocVien;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.CheckBox chkNhanEmail;
        private System.Windows.Forms.GroupBox grpThongTinKhoaHoc;
        private System.Windows.Forms.Label lblKhoaHoc;
        private System.Windows.Forms.ComboBox cboKhoaHoc;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.RadioButton radOnline;
        private System.Windows.Forms.RadioButton radOffline;
        private System.Windows.Forms.Label lblSoThang;
        private System.Windows.Forms.NumericUpDown numSoThang;
        private System.Windows.Forms.Label lblTongTienTitle;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
    }
}
