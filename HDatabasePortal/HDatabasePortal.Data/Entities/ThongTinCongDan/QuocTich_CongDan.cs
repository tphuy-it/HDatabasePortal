using HDatabasePortal.Data.Entities.DiaPhuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.ThongTinCongDan
{
    public class QuocTich_CongDan
    {
        public string CongDan_SoDinhDanh { get; set; }
        public string QuocGia_MaM49 { get; set; }
        public DateTime TuNgay { get; set; }
        public bool HienTai { get; set; }
        public string MoTa { get; set; }
        public CongDan CongDan { get; set; }
        public DanhMuc_QuocGia QuocGia { get; set; }
    }
}
