using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.DiaPhuong
{
   public class DanhMuc_QuanHuyen
    {
        public string MaHanhChinh { get; set; }
        public string Ten { get; set; }
        public string TenKhac { get; set; }
        public string MaBuuChinh { get; set; }
        public string TinhThanh_MaHanhChinh { get; set; }
        public string CapQuanHuyen_Ma { get; set; }
        public DanhMuc_TinhThanh TinhThanh { get; set; }
        public DanhMuc_CapQuanHuyen CapQuanHuyen { get; set; }
        public List<DanhMuc_XaPhuong> DS_XaPhuong { get; set; }
    }
}
