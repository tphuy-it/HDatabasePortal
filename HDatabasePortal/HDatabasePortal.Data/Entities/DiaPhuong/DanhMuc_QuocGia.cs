using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HDatabasePortal.Data.Entities.ThongTinCongDan;

namespace HDatabasePortal.Data.Entities.DiaPhuong
{
    
    public class DanhMuc_QuocGia
    {
    
        public string MaM49 { get; set; }
        public string MaAlpha2 { get; set; }
        public string MaAlpha3 { get; set; }
        public string TenTA { get; set; }
        public string TenTV { get; set; }
        public string QuocTich { get; set; }
        public string MaBuuChinh { get; set; }
        public string QuocKy { get; set; }
        public string MoTa { get; set; }
        public string MuiGio { get; set; }
        public string KhuVucQuocGia_MaM49 { get; set; }
        public DanhMuc_KhuVucQuocGia KhuVucQuocGia { get; set; }
        public List<DanhMuc_KhuVucTinhThanhCap1> DS_KhuVucTinhThanhCap1 { get; set; }
        public List<QuocTich_CongDan> DS_QuocTich_CongDan { get; set; }
    }
}
