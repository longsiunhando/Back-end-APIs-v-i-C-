using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class hdnModel
    {
        public int idHDN { get; set; }
        public int idNCC { get; set; }
        public int idNV { get; set; }
        public float tongTien { get; set; }
        public DateTime thoiGianN { get; set; }
    }

    public class chiTiethdnModel
    {
        public int idChiTietHDN { get; set; }
        public int idHDN { get; set; }
        public int idSP { get; set; }
        public int soLuong { get; set; }
        public float giaNhap { get; set; }
        public float thanhTien { get; set; }
    }
}
