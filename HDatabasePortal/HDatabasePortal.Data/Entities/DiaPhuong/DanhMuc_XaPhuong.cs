using HDatabasePortal.Data.Entities.ThongTinCongDan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.DiaPhuong
{
    public class DanhMuc_XaPhuong
    {
        public string MaHanhChinh { get; set; }
        public string Ten { get; set; }
        public string MaBuuChinh { get; set; }
        public string TenKhac { get; set; }
        public string CapXaPhuong_Ma { get; set; }
        public string QuanHuyen_MaHanhChinh { get; set; }
        public DanhMuc_CapXaPhuong CapXaPhuong { get; set; }
        public DanhMuc_QuanHuyen QuanHuyen { get; set; }
        public List<DiaChi_CongDan> DS_DiaChi_CongDan { get; set; }
    }
}
