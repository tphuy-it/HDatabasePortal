using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.ThongTinCongDan
{
    public class DanhMuc_LoaiDiaChi
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public List<DiaChi_CongDan> DS_DiaChi_CongDan { get; set; }
    }
}
