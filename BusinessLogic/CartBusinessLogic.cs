using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CartBusinessLogic
    {
        private readonly DatabaseAPIContext dbContext;
        private string SessionId;

        public CartBusinessLogic(DatabaseAPIContext dbContext, HttpContext httpContext)
        {
            this.dbContext = dbContext;
            this.SessionId = GetSessionId(httpContext);
        }

        private string GetSessionId(HttpContext httpContext)
        {
            if (httpContext.Session.GetString("SessionId") == null)
            {
                if (!string.IsNullOrWhiteSpace(httpContext.User.Identity.Name))
                {
                    httpContext.Session.SetString("SessionId", httpContext.User.Identity.Name);
                }
                else
                {
                    Guid tempSessionId = Guid.NewGuid();
                    httpContext.Session.SetString("SessionId", tempSessionId.ToString());
                }
            }
            return httpContext.Session.GetString("SessionId").ToString();
        }

        public async Task RemoveFromCart(CartElement element)
        {
            dbContext.CartElement.Remove(element);
            await dbContext.SaveChangesAsync();
        }

        // I need to add logic to check if ticket was taken.
        public void AddToCart(ScreeningSeat screeningSeat)
        {
            dbContext.CartElement.Add(NewCartElement(screeningSeat));
            dbContext.SaveChanges();
        }
        // I need to check if I want to edit ticket added to a cart or I prefer to delete it and then add new one.

        public async Task<List<CartElement>> GetCartElements()
        {
            return await dbContext.CartElement.Where(item => item.SessionId == this.SessionId)
                .Include(item => item.ScreeningSeat)
                    .ThenInclude(item => item.Screening).ThenInclude(item => item.Screen)
                .Include(item => item.ScreeningSeat)
                    .ThenInclude(item => item.Screening).ThenInclude(item => item.Movie)
                .ToListAsync();
        }

        public async Task<decimal> CalculateSum()
        {
            return await dbContext.CartElement.Where(item => item.SessionId == this.SessionId).Include(item => item.ScreeningSeat)
                .ThenInclude(item => item.Screening).ThenInclude(item => item.Movie).SumAsync(item => item.ScreeningSeat.Screening.Movie.TicketPrice) ?? decimal.Zero;
        }

        // Creating receipt and adding to database
        public void AddReceipt()
        {

        }

        private CartElement NewCartElement(ScreeningSeat screeningSeat)
        {
            return new CartElement()
            {
                ScreeningSeatId = screeningSeat.Id,
                ScreeningSeat = screeningSeat,
                SessionId = this.SessionId
            };
        }
    }
}
