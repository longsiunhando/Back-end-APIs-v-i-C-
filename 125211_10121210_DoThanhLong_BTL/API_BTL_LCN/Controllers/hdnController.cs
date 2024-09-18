using BUS.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL_LCN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class hdnController : ControllerBase
    {
        private I_hdnBUS hdnBUS;
        public hdnController(I_hdnBUS HDNBUS)
        {
            hdnBUS = HDNBUS;
        }

        [Route("get_all_hdn")]
        [HttpGet]
        public List<hdnModel> GetAllhdn()
        {
            return hdnBUS.GetAllhdn();
        }

        [Route("get_hdn/{str}")]
        [HttpGet]
        public hdnModel Gethdn(string str)
        {
            return hdnBUS.Gethdn(str);
        }

        [Route("get_cthdn/{idHDN}")]
        [HttpGet]
        public chiTiethdnModel GetCThdn(int idHDN)
        {
            return hdnBUS.GetCThdn(idHDN);
        }

        [Route("create_hdn")]
        [HttpPost]
        public bool CreateHDN(hdnModel hdnModel)
        {
            return hdnBUS.CreateHDN(hdnModel);
        }

        [Route("create_cthdn")]
        [HttpPost]
        public bool CreateCTHDN(chiTiethdnModel chiTiethdnModel)
        {
            return hdnBUS.CreateCTHDN(chiTiethdnModel);
        }
        [Route("update_hdn")]
        [HttpPut]
        public bool UpdateHDN(hdnModel hdnModel)
        {
            return hdnBUS.UpdateHDN(hdnModel);
        }
        [Route("update_cthdn")]
        [HttpPut]
        public bool UpdateCTHDN(chiTiethdnModel chiTiethdnModel)
        {
            return hdnBUS.UpdateCTHDN(chiTiethdnModel);
        }
        [Route("delete_hdn")]
        [HttpDelete]
        public bool DeleteHDN(int idHDN)
        {
            return hdnBUS.DeleteHDN(idHDN);
        }
        [Route("delete_cthdn")]
        [HttpDelete]
        public bool DeleteCTHDN(int idHDN)
        {
            return hdnBUS.DeleteCTHDN(idHDN);
        }
    }
}
