using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OMSCore.Application.DTOs.Authenticate;
using OMSCore.Application.Features.Authenticate.Commands;
using System.Net;
using System.Threading.Tasks;

namespace OMSCore.WebApi.Controllers
{
    [Route("api/authentcate")]
    [ApiController]
    public class AuthenticateController : BaseApiController
    {
        private readonly ISender _iSender;
        public AuthenticateController(ISender iSender) => _iSender = iSender;

        [AllowAnonymous]
        [HttpPost, Route("signIn")]
        public async Task<IActionResult> SignIn(SignIn model)
        {
            var result = await _iSender.Send(new SignInCommand(model));
            return CustomResult(result, HttpStatusCode.OK);
        }
    }
}
