using MobileApp.Helpers;
using MobileApp.Services;
using MobileApp.ViewModels.Invoice;

namespace MobileApp.Pages.ProfilePages;

public partial class ProfileTickets : ContentPage
{
    private IEnumerable<TicketResponse> allTickets; // Stores full data
    public ProfileTickets()
	{
		InitializeComponent();
        LoadAllTickets();
    }

    private async void LoadAllTickets()
    {
        var userId = await SecureStorage.GetAsync("userid");
        allTickets = await TicketApiService.GetScreeningsForUser(userId);
        CvAllTickets.ItemsSource = allTickets;
    }
    private async void OnGeneratePDFClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            try
            {

                int ticketId = (int) button.CommandParameter;
                var ticketModel = allTickets.First(tic => tic.TicketId == ticketId);
                var ticketInvoice = new TicketInvoiceModel
                {
                    Id = ticketModel.TicketId ?? 0,
                    MovieName = ticketModel.MovieName,
                    seatCode = ticketModel.SeatNumber,
                    StartDate = ticketModel.StartDate,
                    RoomNumber = 23,
                    UserName = await SecureStorage.GetAsync("username")
                };
                string pdfPath = Path.Combine(FileSystem.CacheDirectory, $"Ticket_{ticketInvoice.Id}.pdf");
                TicketGenerator.GenerateTicket(ticketInvoice, pdfPath);

                await DisplayAlert("Success", $"PDF saved at:\n{pdfPath}", "OK");

                // Optionally, open the PDF
                await Launcher.OpenAsync(new OpenFileRequest
                {
                    File = new ReadOnlyFile(pdfPath)
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Failed to generate PDF: " + ex.Message, "OK");
            }
        }
    }
}