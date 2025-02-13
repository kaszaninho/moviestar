using MobileApp.Services;
using MobileApp.ViewModels.Invoice;
using System.Collections.ObjectModel;

namespace MobileApp.Pages.ProfilePages;

public partial class InvoiceDetails : ContentPage
{
    private string _invoiceId;
    public InvoiceDetails(string invoiceId)
    {
        InitializeComponent();
        _invoiceId = invoiceId;
        LoadInvoiceDetails();
    }

    private async void LoadInvoiceDetails()
    {
        var invoice = await InvoiceApiService.GetInvoice(_invoiceId);

        if (invoice != null)
        {
            // Populate invoice info
            InvoiceIdLabel.Text = $"Invoice ID: {invoice.InvoiceId}";
            OrderStatusLabel.Text = $"Order Status: {invoice.OrderStatus}";
            PaymentStatusLabel.Text = $"Payment Status: {invoice.PaymentStatus}";
            CreatedAtLabel.Text = $"Created At: {invoice.CreatedAt:MMM dd, yyyy HH:mm}";

            // Populate buyer address
            if (invoice.Address != null)
            {
                BuyerStreetLabel.Text = $"Street: {invoice.Address.Street}";
                BuyerEircodeLabel.Text = $"Eircode: {invoice.Address.Eircode}";
                BuyerCityLabel.Text = $"City: {invoice.Address.City}";
                BuyerCountryLabel.Text = $"Country: {invoice.Address.Country}";
            }

            // Populate price details
            TicketSumLabel.Text = $"Ticket Sum: ${invoice.TicketSum:F2}";
            CouponLabel.Text = string.IsNullOrEmpty(invoice.Coupon) ? "Coupon: None" : $"Coupon: {invoice.Coupon}";
            CouponDiscountLabel.Text = invoice.CouponDiscount == null ? "Discount: None" : $"Discount: ${invoice.CouponDiscount:F2}";
            TotalSumLabel.Text = $"Total: ${invoice.TotalSum:F2}";

            // Populate ticket list
            if (invoice.Tickets != null && invoice.Tickets.Count > 0)
            {
                TicketsCollectionView.ItemsSource = new ObservableCollection<TicketResponse>(invoice.Tickets);
            }
            else
            {
                TicketsCollectionView.ItemsSource = new ObservableCollection<TicketResponse>();
            }
        }
    }
}