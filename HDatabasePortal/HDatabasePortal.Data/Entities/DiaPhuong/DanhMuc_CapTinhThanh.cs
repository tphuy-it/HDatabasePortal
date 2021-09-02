using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.DiaPhuong
{
  public class DanhMuc_CapTinhThanh
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public List<DanhMuc_TinhThanh> DS_TinhThanh { get; set; }

    }
}
