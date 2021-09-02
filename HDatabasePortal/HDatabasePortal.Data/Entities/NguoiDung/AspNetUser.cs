using HDatabasePortal.Data.Entities.ThongTinCongDan;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data.Entities.NguoiDung
{
    public class AspNetUser:IdentityUser<Guid>
    {
        public string? SoDinhDanh { get; set; }
        public CongDan CongDan { get; set; }
    }
}
