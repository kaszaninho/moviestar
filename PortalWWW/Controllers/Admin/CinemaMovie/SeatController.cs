﻿using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Repository;

namespace PortalWWW.Controllers.Admin.CinemaMovie
{
    public class SeatController : BaseDictionaryController<Seat>
    {
        public SeatController(IRepository<Seat> repository) : base(repository)
        {
        }
    }
}
