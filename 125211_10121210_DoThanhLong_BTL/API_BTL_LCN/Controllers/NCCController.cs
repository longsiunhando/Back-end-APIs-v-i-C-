using BUS.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL_LCN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NCCController : ControllerBase
    {
        private I_NCCBUS nccBUS;
        public NCCController(I_NCCBUS NCCBUS)
        {
            nccBUS = NCCBUS;
        }
        [Route("get_all_ncc")]
        [HttpGet]
        public List<NCCModel> GetAllNCC()
        {
            return nccBUS.GetAllNCC();
        }
        [Route("get_ncc")]
        [HttpGet]
        public List<NCCModel> GetNCC(string str)
        {
            return nccBUS.GetNCC(str);
        }

        [Route("create_ncc")]
        [HttpPost]
        public bool CreateNCC(NCCModel ncc)
        {
            return nccBUS.CreateNCC(ncc);
        }

        [Route("update_ncc")]
        [HttpPut]
        public bool UpdateNCC(NCCModel ncc)
        {
            return nccBUS.UpdateNCC(ncc);
        }

        [Route("delete_ncc")]
        [HttpDelete]
        public bool DeleteNCC(int id)
        {
            return nccBUS.DeleteNCC(id);
        }
    }
}
