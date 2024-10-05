using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Models.General.DictionaryModels;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.General.DictionaryTable
{
    public class WorkPositionController : BaseDictionaryController<WorkPosition>
    {
        public WorkPositionController(IRepository<WorkPosition> repository) : base(repository)
        {
        }
    }
}
