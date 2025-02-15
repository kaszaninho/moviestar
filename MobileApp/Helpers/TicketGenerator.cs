using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;

namespace MobileApp.Helpers
{
    public static class TicketGenerator
    {
        public static string IMAGE_LOGO_URL = @"http://localhost/images/photos/LOGO.png";
        public static void GenerateTicket(TicketInvoiceModel ticket, string? filePath)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 10, XFontStyleEx.Regular);
            XStringFormat format = XStringFormats.Center;
            using (HttpClient client = new HttpClient())
            {
                var imageData = client.GetByteArrayAsync(IMAGE_LOGO_URL).GetAwaiter().GetResult(); // Download image as byte array
                if (imageData == null || imageData.Length == 0)
                {
                    throw new Exception("Failed to download image. Image data is empty.");
                }
                // Save to a temporary file
                string tempPath = Path.Combine(FileSystem.CacheDirectory, "temp_logo.png");
                File.WriteAllBytes(tempPath, imageData);

                XImage img = XImage.FromFile(tempPath);
                gfx.DrawImage(img, 300, 100, 225, 75);
            }
            gfx.DrawString("Ticket number: " + ticket.Id, font, XBrushes.Black, new XRect(0, 10, page.Width, page.Height), format);
            gfx.DrawString("Movie: " + ticket.MovieName, font, XBrushes.Black, new XRect(0, 30, page.Width, page.Height), format);
            gfx.DrawString("Screen: " + ticket.RoomNumber, font, XBrushes.Black, new XRect(0, 50, page.Width, page.Height), format);
            gfx.DrawString("Seat: " + ticket.seatCode, font, XBrushes.Black, new XRect(0, 70, page.Width, page.Height), format);
            gfx.DrawString("Date: " + ticket.StartDate, font, XBrushes.Black, new XRect(0, 90, page.Width, page.Height), format);
            var ticketDirectory = Path.Combine(Directory.GetCurrentDirectory(), "resources/reports/");

            var path = string.IsNullOrEmpty(filePath) ? ticketDirectory + "Ticket" + new Random().Next(100) + ".pdf" : filePath;
            document.Save(path);
        }
    }
}
