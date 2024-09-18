using BUS.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL_LCN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private I_AccountBUS AccBUS;
        public AccountController(I_AccountBUS accBUS)
        {
            AccBUS = accBUS;
        }


        [Route("get_acc_by_username/{username}")]
        [HttpGet]
        public accountModel GetAccByUsername(string username)
        {
            return AccBUS.GetAccByUsername(username);
        }



        [Route("get_TTTK_by_username/{username}")]
        [HttpGet]
        public accountIn4Model GetTTTKByUsername(string username)
        {
            return AccBUS.GetTTTKByUsername(username);
        }

        [Route("create_acc")]
        [HttpPost]
        public bool CreateAcc(accountModel account)
        {
            return AccBUS.CreateAcc(account);
        }
        [Route("create_accIn4")]
        [HttpPost]
        public bool CreateAccIn4(accountIn4Model accountIn4)
        {
            return AccBUS.CreateAccIn4(accountIn4);
        }

        [Route("update_acc")]
        [HttpPut]
        public bool UpdateAcc(accountModel account)
        {
            return AccBUS.UpdateAcc(account);
        }
        [Route("update_accIn4")]
        [HttpPut]
        public bool UpdateAccIn4(accountIn4Model accountIn4)
        {
            return AccBUS.UpdateAccIn4(accountIn4);
        }
        [Route("delete_acc")]
        [HttpDelete]
        public bool DeleteAcc(string username)
        {
            return AccBUS.DeleteAcc(username);
        }
        [Route("delete_accIn4")]
        [HttpDelete]
        public bool DeleteAccIn4(string username)
        {
            return AccBUS.DeleteAccIn4(username);
        }
    }
}
