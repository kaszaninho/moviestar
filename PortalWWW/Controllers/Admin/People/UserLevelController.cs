using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Models.General.DictionaryModels;
using DatabaseAPI.Models.People;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.People
{
    public class UserLevelController : BaseDictionaryController<UserLevel>
    {
        public UserLevelController(IRepository<UserLevel> repository) : base(repository)
        {
        }
    }
}
