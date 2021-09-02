using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.ThongTinCongDan
{
    public class DanhMuc_GioiTinh
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public List<CongDan> DS_CongDan { get; set; }
    }
}
