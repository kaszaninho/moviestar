using DatabaseAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.General
{
    [Route("[controller]")]
    public class CustomerQueryController : Controller
    {
        private readonly DatabaseAPIContext context;

        public CustomerQueryController(DatabaseAPIContext context)
        {
            this.context = context;
        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var entities = context.CustomerQuery.ToList();
            return Json(new { data = entities });
        }

        [HttpGet("Details")]
        virtual public async Task<IActionResult> Details(int id)
        {
            var entity = await context.CustomerQuery.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            return View(entity);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await context.CustomerQuery.FindAsync(id);
            if (entity == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            else
            {
                context.Remove(entity);
                await context.SaveChangesAsync();

                return Json(new { success = true, message = "Delete Successful" });
            }
        }

        [HttpPost("TrueFalse")]
        public IActionResult TrueFalse([FromBody] int id)
        {
            var entity = context.CustomerQuery.FirstOrDefault(u => u.Id == id);
            if (entity == null)
            {
                return Json(new { success = false, message = "Error while answering" });
            }
            entity.IsAnswered = !entity.IsAnswered;
            context.SaveChanges();
            return Json(new { success = true, message = "Success" });
        }
    }
}
