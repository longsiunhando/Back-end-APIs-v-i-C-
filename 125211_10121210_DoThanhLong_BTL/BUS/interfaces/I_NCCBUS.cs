using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.interfaces
{
    public partial interface I_NCCBUS
    {
        List<NCCModel> GetAllNCC();
        List<NCCModel> GetNCC(string str);
        bool CreateNCC(NCCModel model);
        bool UpdateNCC(NCCModel model);
        bool DeleteNCC(int id);
    }
}
