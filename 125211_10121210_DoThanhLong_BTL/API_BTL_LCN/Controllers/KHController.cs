using BUS.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL_LCN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KHController : ControllerBase
    {
        private I_KHBUS khBUS;
        public KHController(I_KHBUS KHBUS)
        {
            khBUS = KHBUS;
        }
        [Route("get_all_kh")]
        [HttpGet]
        public List<KHModel> GetAllKH()
        {
            return khBUS.GetAllKH();
        }
        [Route("get_kh")]
        [HttpGet]
        public List<KHModel> GetKH(string str)
        {
            return khBUS.GetKH(str);
        }

        [Route("create_kh")]
        [HttpPost]
        public bool CreateKH(KHModel khModel)
        {
            return khBUS.CreateKH(khModel);
        }

        [Route("update_kh")]
        [HttpPut]
        public bool UpdateKH(KHModel khModel)
        {
            return khBUS.UpdateKH(khModel);
        }

        [Route("delete_kh")]
        [HttpDelete]
        public bool DeleteKH(int id)
        {
            return khBUS.DeleteKH(id);
        }

    }
}
