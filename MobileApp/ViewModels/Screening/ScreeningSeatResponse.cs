using System.ComponentModel;
using System.Text.Json.Serialization;

public class ScreeningSeatResponse
{
    [JsonPropertyName("screeningSeatId")]
    public int ScreeningSeatId { get; set; }

    [JsonPropertyName("seatNumber")]
    public string SeatNumber { get; set; }

    [JsonPropertyName("isTaken")]
    public bool IsTaken { get; set; }

    [JsonPropertyName("screeningId")]
    public int ScreeningId { get; set; }

    [JsonPropertyName("ticketPrice")]
    public decimal TicketPrice{ get; set; }

    // View data
    private bool isSelected;
    public bool IsSelected
    {
        get => isSelected;
        set
        {
            if (isSelected != value)
            {
                isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
} 