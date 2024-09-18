using BUS;
using BUS.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL_LCN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class hdbController : ControllerBase
    {
        private I_hdbBUS hdbBUS;
        public hdbController(I_hdbBUS HDBBUS)
        {
            hdbBUS = HDBBUS;
        }

        [Route("get_all_hdb")]
        [HttpGet]
        public List<hdbModel> GetAllhdb()
        {
            return hdbBUS.GetAllhdb();
        }

        [Route("get_hdb/{str}")]
        [HttpGet]
        public hdbModel Gethdb(string str)
        {
            return hdbBUS.Gethdb(str);
        }

        [Route("get_cthdb/{idHDB}")]
        [HttpGet]
        public chiTiethdbModel GetCThdb(int idHDB)
        {
            return hdbBUS.GetCThdb(idHDB);
        }

        [Route("create_hdb")]
        [HttpPost]
        public bool CreateHDB(hdbModel hdbModel)
        {
            return hdbBUS.CreateHDB(hdbModel);
        }

        [Route("create_cthdb")]
        [HttpPost]
        public bool CreateCTHDB(chiTiethdbModel chiTiethdbModel)
        {
            return hdbBUS.CreateCTHDB(chiTiethdbModel);
        }
        [Route("update_hdb")]
        [HttpPut]
        public bool UpdateHDB(hdbModel hdbModel)
        {
            return hdbBUS.UpdateHDB(hdbModel);
        }
        [Route("update_cthdb")]
        [HttpPut]
        public bool UpdateCTHDB(chiTiethdbModel chiTiethdbModel)
        {
            return hdbBUS.UpdateCTHDB(chiTiethdbModel);
        }
        [Route("delete_hdb")]
        [HttpDelete]
        public bool DeleteHDB(int idHDB)
        {
            return hdbBUS.DeleteHDB(idHDB);
        }
        [Route("delete_cthdb")]
        [HttpDelete]
        public bool DeleteCTHDB(int idHDB)
        {
            return hdbBUS.DeleteCTHDB(idHDB);
        }
    }
}
