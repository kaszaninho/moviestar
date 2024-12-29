﻿using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.General;

namespace DatabaseAPI.Models.Helpers
{
    public class TicketInvoiceModel
    {
        public int Id { get; set; }
        public string? MovieName { get; set; }
        public DateTime? StartDate { get; set; }
        public int? RoomNumber { get; set; }
        public string? seatCode { get; set; }
        public string? UserName { get; set; }
    }
}