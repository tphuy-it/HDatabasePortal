using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.ThongTinCongDan
{
    public class DanhMuc_LoaiTrangThai
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public List<LoaiTrangThai_CongDan> DS_LoaiTrangThaiCongDan { get; set; }
    }
}
