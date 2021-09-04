using HDatabasePortal.Data.Entities.ThongTinCongDan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.DanToc
{
    public class DanhMuc_DanToc
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string TenKhac { get; set; }
        public string MoTa { get; set; }
        public List<CongDan> DS_CongDan { get; set; }
    }
}
