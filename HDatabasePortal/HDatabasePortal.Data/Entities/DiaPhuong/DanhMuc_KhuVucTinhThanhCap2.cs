using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.DiaPhuong
{
    public class DanhMuc_KhuVucTinhThanhCap2
    {
        public string KhuVucTinhThanhCap1_Ma { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public string Ma { get; set; }
        public DanhMuc_KhuVucTinhThanhCap1 KhuVucTinhThanhCap1 { get; set; }
        public List<DanhMuc_TinhThanh> DS_TinhThanh { get; set; }
    }
}
