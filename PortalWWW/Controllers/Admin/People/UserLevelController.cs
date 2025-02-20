using DatabaseAPI.Models.People;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.People
{
    public class UserLevelController : BaseDictionaryController<UserLevel>
    {
        public UserLevelController(IRepository<UserLevel> repository) : base(repository)
        {
        }
    }
}
