using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.DiaPhuong
{
    public class DanhMuc_KhuVucTinhThanhCap1
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string QuocGia_MaM49 { get; set; }
        public DanhMuc_QuocGia QuocGia { get; set; }
        public List<DanhMuc_KhuVucTinhThanhCap2> DS_KhuVucTinhThanhCap2 { get; set; }
    }
}
