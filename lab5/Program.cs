using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace lab5
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args != null && args.Length > 0 && args[0] == "/screenshot")
            {
                GenerateScreenshot();
                return;
            }

            Application.Run(new Form1());
        }

        private static void GenerateScreenshot()
        {
            int width = 640;
            int height = 460;
            using (Bitmap bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppRgb))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                    // Background
                    g.Clear(Color.FromArgb(240, 240, 240));

                    // Title
                    using (Font fontTitle = new Font("Segoe UI", 16, FontStyle.Bold))
                    using (Brush brushTitle = new SolidBrush(Color.Navy))
                    {
                        SizeF titleSize = g.MeasureString("ĐĂNG KÝ KHÓA HỌC", fontTitle);
                        g.DrawString("ĐĂNG KÝ KHÓA HỌC", fontTitle, brushTitle, (width - titleSize.Width) / 2, 12);
                    }

                    Font fontBold = new Font("Segoe UI", 9.75f, FontStyle.Bold);
                    Font fontRegular = new Font("Segoe UI", 9.75f, FontStyle.Regular);
                    Pen borderPen = new Pen(Color.FromArgb(180, 180, 180));
                    Pen boxBorderPen = new Pen(Color.FromArgb(160, 160, 160));

                    // --- GroupBox 1: Thông tin học viên ---
                    int g1X = 20, g1Y = 55, g1W = 600, g1H = 155;
                    g.DrawRectangle(borderPen, g1X, g1Y + 7, g1W, g1H - 7);
                    g.FillRectangle(new SolidBrush(Color.FromArgb(240, 240, 240)), g1X + 10, g1Y, 135, 18);
                    g.DrawString("Thông tin học viên", fontBold, Brushes.Black, g1X + 12, g1Y);

                    // Row 1: Họ và tên
                    g.DrawString("Họ và tên:", fontRegular, Brushes.Black, g1X + 20, g1Y + 35);
                    g.FillRectangle(Brushes.White, g1X + 130, g1Y + 32, 440, 25);
                    g.DrawRectangle(boxBorderPen, g1X + 130, g1Y + 32, 440, 25);
                    g.DrawString("Nguyễn Văn A", fontRegular, Brushes.Black, g1X + 135, g1Y + 35);

                    // Row 2: Số điện thoại & Ngày sinh
                    g.DrawString("Số điện thoại:", fontRegular, Brushes.Black, g1X + 20, g1Y + 75);
                    g.FillRectangle(Brushes.White, g1X + 130, g1Y + 72, 180, 25);
                    g.DrawRectangle(boxBorderPen, g1X + 130, g1Y + 72, 180, 25);
                    g.DrawString("0912345678", fontRegular, Brushes.Black, g1X + 135, g1Y + 75);

                    g.DrawString("Ngày sinh:", fontRegular, Brushes.Black, g1X + 335, g1Y + 75);
                    g.FillRectangle(Brushes.White, g1X + 420, g1Y + 72, 150, 25);
                    g.DrawRectangle(boxBorderPen, g1X + 420, g1Y + 72, 150, 25);
                    g.DrawString("05/10/2026", fontRegular, Brushes.Black, g1X + 425, g1Y + 75);

                    // Row 3: CheckBox
                    g.DrawRectangle(boxBorderPen, g1X + 130, g1Y + 117, 14, 14);
                    g.FillRectangle(Brushes.White, g1X + 130, g1Y + 117, 14, 14);
                    using (Font checkFont = new Font("Segoe UI", 9, FontStyle.Bold))
                        g.DrawString("v", checkFont, Brushes.DarkBlue, g1X + 132, g1Y + 115);
                    g.DrawString("Nhận email thông báo", fontRegular, Brushes.Black, g1X + 150, g1Y + 115);


                    // --- GroupBox 2: Thông tin khóa học ---
                    int g2X = 20, g2Y = 220, g2W = 600, g2H = 165;
                    g.DrawRectangle(borderPen, g2X, g2Y + 7, g2W, g2H - 7);
                    g.FillRectangle(new SolidBrush(Color.FromArgb(240, 240, 240)), g2X + 10, g2Y, 135, 18);
                    g.DrawString("Thông tin khóa học", fontBold, Brushes.Black, g2X + 12, g2Y);

                    // Row 1: Khóa học ComboBox
                    g.DrawString("Khóa học:", fontRegular, Brushes.Black, g2X + 20, g2Y + 35);
                    g.FillRectangle(Brushes.White, g2X + 130, g2Y + 32, 440, 25);
                    g.DrawRectangle(boxBorderPen, g2X + 130, g2Y + 32, 440, 25);
                    g.DrawString("C# WinForms cơ bản", fontRegular, Brushes.Black, g2X + 135, g2Y + 35);
                    g.DrawString("v", new Font("Segoe UI", 8), Brushes.Gray, g2X + 550, g2Y + 37);

                    // Row 2: RadioButtons & NumericUpDown
                    g.DrawString("Hình thức học:", fontRegular, Brushes.Black, g2X + 20, g2Y + 75);

                    // Radio 1: Online (Checked)
                    g.DrawEllipse(boxBorderPen, g2X + 130, g2Y + 77, 14, 14);
                    g.FillEllipse(Brushes.SkyBlue, g2X + 133, g2Y + 80, 8, 8);
                    g.DrawString("Online", fontRegular, Brushes.Black, g2X + 150, g2Y + 75);

                    // Radio 2: Trực tiếp
                    g.DrawEllipse(boxBorderPen, g2X + 210, g2Y + 77, 14, 14);
                    g.DrawString("Trực tiếp", fontRegular, Brushes.Black, g2X + 230, g2Y + 75);

                    // NumericUpDown
                    g.DrawString("Số tháng:", fontRegular, Brushes.Black, g2X + 335, g2Y + 75);
                    g.FillRectangle(Brushes.White, g2X + 420, g2Y + 73, 150, 25);
                    g.DrawRectangle(boxBorderPen, g2X + 420, g2Y + 73, 150, 25);
                    g.DrawString("1", fontRegular, Brushes.Black, g2X + 430, g2Y + 76);

                    // Row 3: Tổng tiền
                    g.DrawString("Tổng học phí:", fontRegular, Brushes.Black, g2X + 20, g2Y + 123);
                    using (Font fontPrice = new Font("Segoe UI", 12f, FontStyle.Bold))
                        g.DrawString("800.000 VNĐ", fontPrice, Brushes.Red, g2X + 130, g2Y + 120);

                    // --- Buttons ---
                    Rectangle b1Rect = new Rectangle(140, 400, 110, 38);
                    g.FillRectangle(new SolidBrush(Color.LightSkyBlue), b1Rect);
                    g.DrawRectangle(Pens.SteelBlue, b1Rect);
                    SizeF b1Size = g.MeasureString("Đăng ký", fontBold);
                    g.DrawString("Đăng ký", fontBold, Brushes.Black, b1Rect.X + (b1Rect.Width - b1Size.Width) / 2, b1Rect.Y + (b1Rect.Height - b1Size.Height) / 2);

                    Rectangle b2Rect = new Rectangle(265, 400, 110, 38);
                    g.FillRectangle(new SolidBrush(Color.WhiteSmoke), b2Rect);
                    g.DrawRectangle(boxBorderPen, b2Rect);
                    SizeF b2Size = g.MeasureString("Làm mới", fontRegular);
                    g.DrawString("Làm mới", fontRegular, Brushes.Black, b2Rect.X + (b2Rect.Width - b2Size.Width) / 2, b2Rect.Y + (b2Rect.Height - b2Size.Height) / 2);

                    Rectangle b3Rect = new Rectangle(390, 400, 110, 38);
                    g.FillRectangle(new SolidBrush(Color.WhiteSmoke), b3Rect);
                    g.DrawRectangle(boxBorderPen, b3Rect);
                    SizeF b3Size = g.MeasureString("Thoát", fontRegular);
                    g.DrawString("Thoát", fontRegular, Brushes.Black, b3Rect.X + (b3Rect.Width - b3Size.Width) / 2, b3Rect.Y + (b3Rect.Height - b3Size.Height) / 2);
                }

                bmp.Save("GiaoDien_FormChinh.png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
