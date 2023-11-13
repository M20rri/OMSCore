using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OMSCore.Application.DTOs.Authenticate;
using OMSCore.Application.Interfaces;
using System.Net;
using System.Threading.Tasks;

namespace OMSCore.WebApi.Controllers
{
    [Route("api/authentcate")]
    [ApiController]
    public class AuthenticateController : BaseApiController
    {
        private readonly IUserMasterService _iSender;
        public AuthenticateController(IUserMasterService iSender) => _iSender = iSender;

        [AllowAnonymous]
        [HttpPost, Route("signIn")]
        public async Task<IActionResult> SignIn(SignIn model)
        {
            var result = await _iSender.SignIn(model);
            return CustomResult(result, HttpStatusCode.OK);
        }
    }
}
