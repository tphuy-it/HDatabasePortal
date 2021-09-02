using HDatabasePortal.Data.Entities.NgheNghiep;
using HDatabasePortal.Data.Entities.NguoiDung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.ThongTinCongDan
{
    public class CongDan
    {
        public string SoDinhDanh { get; set; }
        public string SoChungMinhNhanDan { get; set; }
        public string Ho { get; set; }
        public string ChuDem { get; set; }
        public string Ten { get; set; }
        public DateTime? NgayThangNamSinh { get; set; }
        public int NamSinh { get; set; }
        public int GioiTinh_Ma { get; set; }
        public Guid? AspNetUser_ID { get; set; }
        public string NgheNghiepCap5_Ma { get; set; }
        public DanhMuc_GioiTinh GioiTinh { get; set; }
        public DanhMuc_NgheNghiepCap5 NgheNghiepCap5 { get; set; }
        public AspNetUser TaiKhoan { get; set; }
    }
}
