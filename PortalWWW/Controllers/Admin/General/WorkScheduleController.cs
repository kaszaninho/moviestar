using DatabaseAPI.Data;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Models.General;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Admin.General
{
    public class WorkScheduleController : BaseDictionaryController<WorkSchedule>
    {
        public WorkScheduleController(IRepository<WorkSchedule> repository) : base(repository)
        {
        }
    }
}
