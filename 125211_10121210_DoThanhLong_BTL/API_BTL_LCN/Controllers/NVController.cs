using BUS.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL_LCN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NVController : ControllerBase
    {

        private I_NVBUS NVBUS;
        public NVController(I_NVBUS nvBUS)
        {
            NVBUS = nvBUS;
        }

        [Route("get_all_nv")]
        [HttpGet]

        public IEnumerable<NVModel> GetAllNV()
        {
            return NVBUS.GetAllNV();
        }

        [Route("get_nv")]
        [HttpGet]
        public IEnumerable<NVModel> GetNV(string str)
        {
            return NVBUS.GetNV(str);
        }

        [Route("create_nv")]
        [HttpPost]
        public bool CreateNV(NVModel nvModel)
        {
            return NVBUS.CreateNV(nvModel);
        }


        [Route("update_nv")]
        [HttpPut]
        public bool Update(NVModel nvModel)
        {
            return NVBUS.UpdateNV(nvModel);
        }

        [Route("delete_nv")]
        [HttpDelete]
        public bool DeleteNV(int idNV)
        {
            return NVBUS.DeleteNV(idNV);
        }
    }
}
