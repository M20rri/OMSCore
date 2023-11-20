using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using System.Net;
using System.Threading.Tasks;

namespace WebApi.Controllers.v1
{
    [Authorize]
    [Route("api/UserMaster")]
    [ApiVersion("1.0")]
    public class UserMasterController : BaseApiController
    {
        private readonly IUserMasterService _iSender;
        public UserMasterController(IUserMasterService iSender) => _iSender = iSender;

        [HttpGet, Route("api/get-all")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _iSender.GetAll();
            return CustomResult(response, HttpStatusCode.OK);
        }
    }
}
