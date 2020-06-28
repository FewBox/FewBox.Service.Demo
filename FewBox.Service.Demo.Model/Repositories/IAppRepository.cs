using FewBox.Service.Demo.Model.Entities;
using FewBox.Core.Persistence.Orm;

namespace FewBox.Service.Demo.Model.Repositories
{
    public interface IAppRepository : IRepository<App>
    {
    }
}