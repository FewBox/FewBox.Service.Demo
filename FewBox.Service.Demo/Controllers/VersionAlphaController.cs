using Microsoft.AspNetCore.Mvc;

namespace FewBox.Service.Demo.Controllers
{
    [ApiVersion("2.0-alpha")]
    [ApiController]
    [Route("api/v{v:apiVersion}/version")]
    public class VersionAlphaController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "2.0 alpha";
        }
    }
}
