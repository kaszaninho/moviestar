using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin.CinemaMovie
{
    public class ScreenController : BaseDictionaryController<Screen>
    {
        public ScreenController(IRepository<Screen> repository) : base(repository)
        {
        }

        override public async Task<IActionResult> Create(Screen entity)
        {
            entity.Seats = await generateDefaultSeats(entity, 5, 10);
            return await base.Create(entity);
        }

        private async Task<List<Seat>> generateDefaultSeats(Screen screen, int rowsNumber, int seatsInRowNumber)
        {
            char letter = 'A';
            List<Seat> seats = new List<Seat>();
            for (int i = 0; i < rowsNumber; i++)
            {
                for (int j = 1; j <= seatsInRowNumber; j++)
                {
                    seats.Add(new Seat()
                    {
                        NumberInRow = j,
                        Row = letter,
                        Screen = screen,
                        Name = letter.ToString() + j
                    });
                }
                letter++;
            }
            await repository.GetDbSet<Seat>().AddRangeAsync(seats);
            return seats;
        }
    }
}
