using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Application.DTOs.Authenticate;
using Application.Interfaces;
using System;
using System.Net;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/authentcate")]
    [ApiController]
    public class AuthenticateController : BaseApiController
    {
        private readonly IUserMasterService _iSender;
        public AuthenticateController(IUserMasterService iSender)
        {
            _iSender = iSender;
        }

        [AllowAnonymous]
        [HttpPost, Route("signIn")]
        public async Task<IActionResult> SignIn(SignIn model)
        {
            try
            {
                AuthenticateLogger.Info(JsonConvert.SerializeObject(model));
                var result = await _iSender.SignIn(model);
                AuthenticateLogger.Info(JsonConvert.SerializeObject(result));
                return CustomResult(result, HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                AuthenticateLogger.Error(JsonConvert.SerializeObject(ex.Message));
                throw;
            }
        }
    }
}
