using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HDatabasePortal.Data.Entities.NgheNghiep
{
    public class DanhMuc_NgheNghiepCap2
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public string NgheNghiepCap1_Ma { get; set; }
        public DanhMuc_NgheNghiepCap1 NgheNghiepCap1 { get; set; }
        public List<DanhMuc_NgheNghiepCap3> DS_NgheNghiepCap3 { get; set; }
    }
}
