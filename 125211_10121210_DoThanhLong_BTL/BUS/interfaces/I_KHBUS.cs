using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.interfaces
{
    public partial interface I_KHBUS
    {
        List<KHModel> GetAllKH();
        List<KHModel> GetKH(string str);
        bool CreateKH(KHModel model);
        bool UpdateKH(KHModel model);
        bool DeleteKH(int id);
    }
}
