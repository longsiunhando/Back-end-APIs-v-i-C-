using BUS;
using BUS.interfaces;
using DAL.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL_LCN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loaiSPController : ControllerBase
    {
        private I_loaiSPBUS loaiSPBUS;
        public loaiSPController(I_loaiSPBUS loaispBUS)
        {
            loaiSPBUS = loaispBUS;
        }

        [Route("get_all_loaisp")]
        [HttpGet]
        public List<loaiSPModel> GetAllloaiSP()
        {
            return loaiSPBUS.GetAllloaiSP();
        }

        [Route("get_loaisp")]
        [HttpGet]
        public List<loaiSPModel> GetloaiSP(string str)
        {
            return loaiSPBUS.GetloaiSP(str);
        }


        [Route("create_loaisp")]
        [HttpPost]
        public bool CreateloaiSP(loaiSPModel loaiSPModel)
        {
            return loaiSPBUS.CreateloaiSP(loaiSPModel);
        }

        [Route("update_loaisp")]
        [HttpPut]
        public bool UpdateloaiSP(loaiSPModel loaiSPModel)
        {
            return loaiSPBUS.UpdateloaiSP(loaiSPModel);
        }

        [Route("delete_loaisp")]
        [HttpDelete]
        public bool DeleteloaiSP(int idLoai)
        {
            return loaiSPBUS.DeleteloaiSP(idLoai);
        }
    }
}
