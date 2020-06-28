using FewBox.Core.Web.Dto;
using Microsoft.AspNetCore.Mvc;

namespace FewBox.Service.Demo.Controllers
{
    [ApiController]
    [Route("api/v{v:apiVersion}/[controller]")]
    public class VersionsController : ControllerBase
    {
        public VersionsController()
        {
        }

        [HttpGet]
        public PayloadResponseDto<string> Get()
        {
            return new PayloadResponseDto<string>
            {
                Payload ="latest"
            };
        }
    }
}
