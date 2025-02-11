using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.General;

namespace DatabaseAPI.ViewModels
{
    public class MovieListsViewModel
    {
        public IEnumerable<ScreeningViewModel> EarliestScreeningsWithMovies { get; set; }
        public MiniInvoiceViewModel LatestInvoiceWithTickets { get; set; }
    }

    

}
