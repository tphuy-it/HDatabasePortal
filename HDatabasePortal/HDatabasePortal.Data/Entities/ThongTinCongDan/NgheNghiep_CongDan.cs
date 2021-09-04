using HDatabasePortal.Data.Entities.NgheNghiep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.ThongTinCongDan
{
    public class NgheNghiep_CongDan
    {
        public string CongDan_SoDinhDanh { get; set; }
        public string NgheNghiepCap5_Ma { get; set; }
        public DateTime TuNgay { get; set; }
        public bool HienTai { get; set; }
        public string MoTa { get; set; }
        public CongDan CongDan { get; set; }
        public DanhMuc_NgheNghiepCap5 NgheNghiepCap5 { get; set; }
    }
}
