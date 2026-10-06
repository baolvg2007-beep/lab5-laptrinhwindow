using System;

namespace lab5
{
    public class KhoaHoc
    {
        public string TenKhoaHoc { get; set; }
        public decimal HocPhiThang { get; set; }

        public KhoaHoc(string tenKhoaHoc, decimal hocPhiThang)
        {
            TenKhoaHoc = tenKhoaHoc;
            HocPhiThang = hocPhiThang;
        }

        public override string ToString()
        {
            return TenKhoaHoc;
        }
    }
}
