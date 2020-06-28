using FewBox.Service.Demo.Model.Configs;
using FewBox.Service.Demo.Model.Dtos;
using FewBox.Service.Demo.Model.Services;

namespace FewBox.Service.Demo.Domain
{
    public class FewBoxService : IFewBoxService
    {
        private FewBoxConfig FewBoxConfig { get; set; }
        public FewBoxService(FewBoxConfig fewBoxConfig)
        {
            this.FewBoxConfig = fewBoxConfig;
        }

        public AuthorDto GetAuthor()
        {
            return new AuthorDto{
                Name = this.FewBoxConfig.Author
            };
        }
    }
}