using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FewBox.Service.Demo.Model.Dtos;
using FewBox.Service.Demo.Model.Entities;

namespace FewBox.Service.Demo.AutoMapperProfiles
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<App, AppDto>();
            CreateMap<AppPersistantDto, App>();
        }
    }
}