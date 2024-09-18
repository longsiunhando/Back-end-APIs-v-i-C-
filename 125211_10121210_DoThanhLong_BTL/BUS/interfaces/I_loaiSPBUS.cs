using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.interfaces
{
    public partial interface I_loaiSPBUS
    {
        List<loaiSPModel> GetAllloaiSP();
        List<loaiSPModel> GetloaiSP(string str);
        bool CreateloaiSP(loaiSPModel loaiSPModel);
        bool UpdateloaiSP(loaiSPModel loaiSPModel);
        bool DeleteloaiSP(int idLoai);
    }
}
