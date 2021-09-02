using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.DiaPhuong
{
    public class DanhMuc_TinhThanh
    {
        public string MaHanhChinh { get; set; }
        public string Ten { get; set; }
        public string MaVungDienThoai { get; set; }
        public string MaBuuChinh { get; set; }
        public string TenKhac { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public string MoTa { get; set; }
        public string KhuVucTinhThanhCap2_Ma { get; set; }
        public string CapTinhThanh_Ma { get; set; }
        public DanhMuc_KhuVucTinhThanhCap2 KhuVucTinhThanhCap2 { get; set; }
        public DanhMuc_CapTinhThanh CapTinhThanh { get; set; }
        public List<DanhMuc_QuanHuyen> DS_QuanHuyen { get; set; }
    }
}
