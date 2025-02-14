using DatabaseAPI.Data;
using DatabaseAPI.Models.General;
using DatabaseAPI.Models.People;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using PortalWWW.Models;

namespace PortalWWW.Controllers.Admin.People
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly DatabaseAPIContext context;
        private readonly UserManager<IdentityUser> userManager;

        public UserController(DatabaseAPIContext context, UserManager<IdentityUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        [HttpGet("Index")]
        virtual public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var entities = context.User.ToList();
            var userRoles = context.UserRoles.ToList();
            var roles = context.Roles.ToList();

            foreach (var user in entities)
            {
                var roleId = userRoles.FirstOrDefault(u => u.UserId == user.Id).RoleId;
                var roleName = roles.FirstOrDefault(r => r.Id == roleId)?.Name;
                user.Role = roleName;
            }
            return Json(new { data = entities });
        }

        [HttpGet("Details")]
        virtual public async Task<IActionResult> Details(string id)
        {
            var entity = await context.User.Include(u => u.Address).ThenInclude(u => u.Country).FirstOrDefaultAsync(us => us.Id == id);
            var userRole = await context.UserRoles.FirstOrDefaultAsync(ur => ur.UserId == id);
            var role = await context.Roles.FirstOrDefaultAsync(r => r.Id == userRole.RoleId);

            entity.Role = role.Name;

            return View(entity);
        }

        //[HttpGet("Delete")]
        //virtual public async Task<IActionResult> Delete(string id)
        //{
        //    var entity = await context.User.Include(u => u.Address).ThenInclude(u => u.Country).FirstOrDefaultAsync(us => us.Id == id);
        //    var userRole = await context.UserRoles.FirstOrDefaultAsync(ur => ur.UserId == id);
        //    var role = await context.Roles.FirstOrDefaultAsync(r => r.Id == userRole.RoleId);

        //    entity.Role = role.Name;

        //    return View(entity);
        //}

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var user = await context.User.FirstAsync(us => us.Id == id);
        //    if (user != null)
        //    {
        //        context.Remove(user);
        //        await context.SaveChangesAsync();
        //    }
        //    return RedirectToAction(nameof(Index));
        //}

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(string id)
        {
            var entity = await context.User.FindAsync(id);
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

        [HttpPost("LockUnlock")]
        public IActionResult LockUnlock([FromBody]string id) 
        { 
            var user = context.User.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return Json(new { success = false, message = "Error while locking/unlocking" });
            }
            if(user.LockoutEnd != null && user.LockoutEnd > DateTime.Now)
            {
                user.LockoutEnd = DateTime.Now;
            }
            else
            {
                user.LockoutEnd = DateTime.Now.AddYears(10);
            }
            context.SaveChanges();
            return Json(new { success = true, message = "Success" });
        }

        [HttpGet("RoleManagement")]
        public IActionResult RoleManagement(string id)
        {
            string RoleID = context.UserRoles.FirstOrDefault(u => u.UserId == id).RoleId;
            RoleManagementVM RoleVM = new RoleManagementVM()
            {
                User =  context.User.First(us => us.Id == id),
                RoleList = context.Roles.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Name
                })
            };

            RoleVM.User.Role = context.Roles.FirstOrDefault(u => u.Id == RoleID).Name;
            return View(RoleVM);
        }

        [HttpPost("RoleManagement")]
        public async Task<IActionResult> RoleManagement(RoleManagementVM roleVM)
        {
            string RoleID = context.UserRoles.FirstOrDefault(u => u.UserId == roleVM.User.Id).RoleId;
            string oldRole = context.Roles.FirstOrDefault(u => u.Id == RoleID).Name;

            if(roleVM.User.Role != oldRole) 
            {
                User user = context.User.FirstOrDefault(u => u.Id == roleVM.User.Id);
                await userManager.RemoveFromRoleAsync(user, oldRole);
                await userManager.AddToRoleAsync(user, roleVM.User.Role);
            }

            return RedirectToAction("Index");
        }
    }
}
