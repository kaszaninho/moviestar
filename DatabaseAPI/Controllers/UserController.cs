using DatabaseAPI.Data;
using DatabaseAPI.Models.People;
using DatabaseAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public UserController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            return await _context.User.Include(user => user.Address).ThenInclude(user => user.Country).ToListAsync();
        }

        // GET: api/User/5
        [HttpGet("{param}")]
        public async Task<ActionResult<UserViewModel>> GetUser(string param)
        {
            try
            {
                var user = await _context.User.Include(user => user.Address).ThenInclude(user => user.Country).Where(user => user.Id == param || user.UserName == param).FirstAsync();

                if (user == null)
                {
                    return NotFound();
                }
                var userViewModel = new UserViewModel
                {
                    Country = user.Address.Country.Name,
                    DateOfBirth = user.DateOfBirth.Date,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    FirstName = user.FirstName,
                    Id = user.Id,
                    LastName = user.LastName,
                    MiddleName = user.MiddleName,
                    PhoneNumber = user.PhoneNumber,
                    PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                    TwoFactorEnabled = user.TwoFactorEnabled,
                    UserName = user.UserName,
                    Address = new AddressViewModel
                    {
                        City = user.Address.City,
                        Country = user.Address.Country.Name,
                        EirCode = user.Address.EirCode,
                        Street = user.Address.StreetName + " " + user.Address.HouseNumber
                    }
                };
                return userViewModel;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Sequence contains no elements"))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
