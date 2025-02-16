using DatabaseAPI.Models.Abstract;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseAPI.Models.CinemaMovie
{
    public class ScreeningSeat : DictionaryTable
    {
        public int? SeatId { get; set; }
        public Seat? Seat { get; set; }
        public int? ScreeningId { get; set; }
        public Screening? Screening { get; set; }
        public bool? IsTaken { get; set; }
    }
}
