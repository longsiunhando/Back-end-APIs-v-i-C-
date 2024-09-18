using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class hdbModel
    {
        public int idHDB { get; set; }
        public int idKH { get; set; }
        public int idNV { get; set; }
        public float tongTien { get; set; }
        public DateTime thoiGianB { get; set; }
    }

    public class chiTiethdbModel
    {
        public int idChiTietHDB { get; set; }
        public int idHDB { get; set; }
        public int idSP { get; set; }
        public int soLuong { get; set; }
        public float giaBan { get; set; }
        public float thanhTien { get; set; }
    }
}
