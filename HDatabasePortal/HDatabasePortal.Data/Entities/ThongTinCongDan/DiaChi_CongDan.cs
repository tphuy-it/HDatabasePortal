using HDatabasePortal.Data.Entities.DiaPhuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.ThongTinCongDan
{
    public class DiaChi_CongDan
    {
        public string CongDan_SoDinhDanh { get; set; }
        public string XaPhuong_MaHanhChinh { get; set; }
        public string LoaiDiaChi_Ma { get; set; }
        public DateTime TuNgay { get; set; }
        public bool HienTai { get; set; }
        public string SoNhaTenDuong { get; set; }
        public string DayDu { get; set; }
        public CongDan CongDan { get; set; }
        public DanhMuc_XaPhuong XaPhuong { get; set; }
        public DanhMuc_LoaiDiaChi LoaiDiaChi { get; set; }
    }
}
