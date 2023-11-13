using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OMSCore.Application.Features.UserMaster;
using System.Net;
using System.Threading.Tasks;

namespace OMSCore.WebApi.Controllers.v1
{
    [Authorize]
    [Route("api/UserMaster")]
    [ApiVersion("1.0")]
    public class UserMasterController : BaseApiController
    {
        [HttpGet, Route("api/get-all")]
        public async Task<IActionResult> GetAll()
        {
            return CustomResult(await Mediator.Send(new GetUserMasterQuery()), HttpStatusCode.OK);
        }
    }
}
