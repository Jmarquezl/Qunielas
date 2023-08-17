using Authorization.Entity;
using Authorization.Service;
using Microsoft.AspNetCore.Mvc;

namespace Authorization.Controller
{
    [Route("v1/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthorizationService authorizationService;
        public AuthController(IAuthorizationService authorizationService)
        {
            this.authorizationService = authorizationService;   
        }

        [HttpPost, Route("login"), Consumes("application/json"), Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]        
        public ActionResult<IResponseBase> Logine([FromBody]LoginRequest request) 
        {
            var response = authorizationService.Logine(request);
            return Ok(response);
        }
    }
}
