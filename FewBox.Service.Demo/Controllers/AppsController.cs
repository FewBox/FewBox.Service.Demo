using AutoMapper;
using FewBox.Core.Web.Controller;
using FewBox.Core.Web.Dto;
using FewBox.Service.Demo.Model.Dtos;
using FewBox.Service.Demo.Model.Entities;
using FewBox.Service.Demo.Model.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FewBox.Service.Demo.Controllers
{
    [Route("api/v{v:apiVersion}/[controller]")]
    [Authorize(Policy="JWTRole_ControllerAction")]
    public class AppsController : ResourcesController<IAppRepository, App, AppDto, AppPersistantDto>
    {
        public AppsController(IAppRepository appRepository, IMapper mapper) : base(appRepository, mapper)
        {
            // SQLite ID must be Upcase.
        }
    }
}
