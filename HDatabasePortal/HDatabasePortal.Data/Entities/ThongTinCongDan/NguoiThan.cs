using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.ThongTinCongDan
{
    public class NguoiThan
    {
        public string CongDan_SoDinhDanh { get; set; }
        public string QuanHe_Ma { get; set; }
        public string SoDinhDanh { get; set; }
        public string SoChungMinhNhanDan { get; set; }
        public string Ho { get; set; }
        public string ChuDem { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public bool ChungHo { get; set; }
        public CongDan CongDan { get; set; }
        public DanhMuc_QuanHe QuanHe { get; set; }
    }
}
