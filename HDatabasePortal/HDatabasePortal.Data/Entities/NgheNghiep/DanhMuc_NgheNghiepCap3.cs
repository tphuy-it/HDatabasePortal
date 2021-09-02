using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HDatabasePortal.Data.Entities.NgheNghiep
{
    public class DanhMuc_NgheNghiepCap3
    {
        public string Ma { get; set; }

        public string Ten { get; set; }

        public string MoTa { get; set; }

        public string NgheNghiepCap2_Ma { get; set; }

        public DanhMuc_NgheNghiepCap2 NgheNghiepCap2 { get; set; }
        public List<DanhMuc_NgheNghiepCap4> DS_NgheNghiepCap4 { get; set; }
    }
}
