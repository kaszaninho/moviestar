using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using MobileApp.Models;
using MobileApp.Services;

namespace MobileApp.Pages.MoviePages
{
    public partial class SeatSelectionPage : ContentPage
    {
        private readonly TicketPurchaseState purchaseState;
        private IEnumerable<ScreeningSeatResponse> seats;

        public SeatSelectionPage(int screeningId)
        {
            InitializeComponent();
            purchaseState = new TicketPurchaseState { ScreeningId = screeningId };
            LoadSeats();
        }

        private async void LoadSeats()
        {
            seats = await ScreeningSeatApiService.GetSeatsForScreening(purchaseState.ScreeningId ?? 0);
            SeatsCollection.ItemsSource = seats.Where(s => !s.IsTaken);
            SeatsCollection.SelectionChanged += OnSeatsSelectionChanged;
        }

        private void OnSeatsSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedSeats = SeatsCollection.SelectedItems.Cast<ScreeningSeatResponse>().ToList();
            purchaseState.SelectedSeatIds = selectedSeats.Select(s => s.ScreeningSeatId).ToList();
            purchaseState.TotalPrice = selectedSeats.Sum(x => x.TicketPrice);
            purchaseState.TicketsPrice = purchaseState.TotalPrice;
            TotalPriceLabel.Text = $"Total: PLN {purchaseState.TotalPrice:F2}";
            ContinueButton.IsEnabled = selectedSeats.Any();
        }

        private async void OnContinueClicked(object sender, EventArgs e)
        {
            if (purchaseState.SelectedSeatIds.Any())
            {
                await Navigation.PushAsync(new CouponPage(purchaseState));
            }
            else
            {
                await DisplayAlert("Error", "Please select at least one seat", "OK");
            }
        }
    }
} 