using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.DiaPhuong
{
  public class DanhMuc_CapQuanHuyen
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public List<DanhMuc_QuanHuyen> DS_QuanHuyen { get; set; }

    }
}
