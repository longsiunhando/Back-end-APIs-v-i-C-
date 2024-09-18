using BUS.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL_LCN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SPController : ControllerBase
    {
        private I_SPBUS SPBUS;
        public SPController(I_SPBUS spBUS)
        {
            SPBUS = spBUS;
        }


        [Route("get_all_sp")]
        [HttpGet]
        public IEnumerable<SPModel> GetAllSP()
        {
            return SPBUS.GetAllSP();
        }

        [Route("get_sp")]
        [HttpGet]
        public IEnumerable<SPModel> GetSP(string str)
        {
            return SPBUS.GetSP(str);
        }

        [Route("create_sp")]
        [HttpPost]
        public bool Create(SPModel spModel)
        {
            return SPBUS.CreateSP(spModel);
        }


        [Route("update_sp")]
        [HttpPut]
        public bool UpdateSP(SPModel spModel)
        {
            return SPBUS.UpdateSP(spModel);
        }

        [Route("delete_sp")]
        [HttpDelete]
        public bool DeleteSP(int idSP)
        {
            return SPBUS.DeleteSP(idSP);
        }
    }
}
