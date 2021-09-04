using HDatabasePortal.Data.Entities.DanToc;
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
        public string DanToc_Ma { get; set; }
        public bool ChuHo { get; set; }
        public Guid? AspNetUser_ID { get; set; }
        public DanhMuc_GioiTinh GioiTinh { get; set; }
        public DanhMuc_DanToc DanToc { get; set; }
        public AspNetUser TaiKhoan { get; set; }
        public List<QuocTich_CongDan> DS_QuocTich { get; set; }
        public List<NgheNghiep_CongDan> DS_NgheNghiep { get; set; }
        public List<TinhTrangHonNhan_CongDan> DS_TinhTrangHonNhan { get; set; }
        public List<DiaChi_CongDan> DS_DiaChi { get; set; }
        public List<LoaiTrangThai_CongDan> DS_LoaiTrangThai { get; set; }
        public List<TonGiao_CongDan> DS_TonGiao { get; set; }
        public List<NguoiThan> DS_NguoiThan { get; set; }
    }
}
