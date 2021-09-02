using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.TonGiao
{
    public class DanhMuc_TonGiao
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public List<DanhMuc_CacToChucTonGiaoChinh> DS_CacToChucTonGiaoChinh { get; set; }
    }
}
