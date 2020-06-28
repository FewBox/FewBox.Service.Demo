using Microsoft.AspNetCore.Mvc;

namespace FewBox.Service.Demo.Controllers
{
    [ApiVersion("2.0-beta")]
    [ApiController]
    [Route("api/v{v:apiVersion}/version")]
    public class VersionBetaController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "2.0 beta";
        }
    }
}
