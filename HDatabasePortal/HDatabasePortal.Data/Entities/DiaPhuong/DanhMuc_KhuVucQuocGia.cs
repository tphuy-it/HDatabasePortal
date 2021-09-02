using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HDatabasePortal.Data.Entities.DiaPhuong
{
  
    public class DanhMuc_KhuVucQuocGia
    {
  
        public string MaM49 { get; set; }
  
        public string TenTA { get; set; }
  
        public string TenTV { get; set; }
        public string MoTa { get; set; }

        public string ChauLuc_MaM49 { get; set; }
  
        public DanhMuc_ChauLuc ChauLuc { get; set; }
        public virtual List<DanhMuc_QuocGia> DS_QuocGia { get; set; }
    }
}
