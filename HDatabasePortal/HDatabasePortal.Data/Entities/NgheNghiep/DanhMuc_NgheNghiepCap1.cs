using System;
using System.Collections.Generic;

namespace HDatabasePortal.Data.Entities.NgheNghiep
{
    public class DanhMuc_NgheNghiepCap1
    {
        public string Ma { get; set; }

        public string Ten { get; set; }

        public string MoTa { get; set; }
        public List<DanhMuc_NgheNghiepCap2> DS_NgheNghiepCap2 { get; set; }
    }
}
