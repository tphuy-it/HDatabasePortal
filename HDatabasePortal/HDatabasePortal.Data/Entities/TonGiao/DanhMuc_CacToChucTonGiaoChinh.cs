using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.TonGiao
{
    public class DanhMuc_CacToChucTonGiaoChinh
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string TonGiao_Ma { get; set; }
        public DanhMuc_TonGiao TonGiao { get; set; }
    }
}
