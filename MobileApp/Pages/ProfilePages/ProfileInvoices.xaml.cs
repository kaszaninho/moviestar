using MobileApp.Services;
using MobileApp.ViewModels.Invoice;
using MobileApp.ViewModels.Movie;
using System.Collections.ObjectModel;

namespace MobileApp.Pages.ProfilePages;

public partial class ProfileInvoices : ContentPage
{
    private IEnumerable<Invoice> allInvoices; // Stores full data
    public ProfileInvoices()
	{
		InitializeComponent(); 
        LoadAllInvoices();
    }

    private async void LoadAllInvoices()
    {
        var userId = await SecureStorage.GetAsync("userid");
        allInvoices = await InvoiceApiService.GetInvoiceListForUser(userId);
        CvAllInvoices.ItemsSource = allInvoices;
    }
    private async void OnInvoiceDetailsClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var invoiceId = button.CommandParameter;

        if (invoiceId != null)
        {
            await Navigation.PushAsync(new InvoiceDetails(((Guid)invoiceId).ToString()));
        }
    }
}