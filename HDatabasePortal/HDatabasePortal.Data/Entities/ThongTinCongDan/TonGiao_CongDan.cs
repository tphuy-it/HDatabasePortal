using HDatabasePortal.Data.Entities.TonGiao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.ThongTinCongDan
{
    public class TonGiao_CongDan
    {
        public string CongDan_SoDinhDanh { get; set; }
        public int CacToChucTonGiaoChinh_ID { get; set; }
        public DateTime TuNgay { get; set; }
        public bool HienTai { get; set; }
        public bool CoChucVu { get; set; }
        public string MoTa { get; set; }
        public CongDan CongDan { get; set; }
        public DanhMuc_CacToChucTonGiaoChinh CacToChucTonGiaoChinh { get; set; }
    }
}
