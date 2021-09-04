using HDatabasePortal.Data.Entities.ThongTinCongDan;
using System;
using System.Collections.Generic;


namespace HDatabasePortal.Data.Entities.NgheNghiep
{
   
    
    public class DanhMuc_NgheNghiepCap5
    {
    
        public string Ma { get; set; } 
    
        public string Ten { get; set; }
    
        public string MoTa { get; set; }
    
        public string NgheNghiepCap4_Ma { get; set; }
    
        public DanhMuc_NgheNghiepCap4 NgheNghiepCap4 { get; set; }
        public List<NgheNghiep_CongDan> DS_NgheNghiep_CongDan { get; set; }
    }
}
