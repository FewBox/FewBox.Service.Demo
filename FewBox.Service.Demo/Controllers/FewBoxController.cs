using FewBox.Core.Web.Dto;
using FewBox.Service.Demo.Model.Dtos;
using FewBox.Service.Demo.Model.Services;
using Microsoft.AspNetCore.Mvc;

namespace FewBox.Service.Demo.Controllers
{
    [Route("api/v{v:apiVersion}/[controller]")]
    public class FewBoxController : ControllerBase
    {
        private  IFewBoxService FewBoxService { get; set; }

        public FewBoxController(IFewBoxService fewBoxService)
        {
            this.FewBoxService = fewBoxService;
        }

        [HttpGet]
        public PayloadResponseDto<AuthorDto> Get()
        {
            return new PayloadResponseDto<AuthorDto>
            {
                Payload =this.FewBoxService.GetAuthor()
            };
        }
    }
}
