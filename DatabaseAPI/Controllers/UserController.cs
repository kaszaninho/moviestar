﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseAPI.Data;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Models.People;
using DatabaseAPI.ViewModels;

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

        // PUT: api/User/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(string id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/User
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _context.User.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.User.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(string id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
