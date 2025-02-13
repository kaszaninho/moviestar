using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;

namespace MobileApp.Helpers
{
    public static class TicketGenerator
    {
        public static void GenerateTicket(TicketInvoiceModel ticket, string? filePath)
        {
            GlobalFontSettings.FontResolver = new CustomFontResolver();
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 10, XFontStyleEx.Regular);
            XStringFormat format = XStringFormats.Center;
            gfx.DrawImage(XImage.FromFile("E:\\Visual Studio 2022 - Projekty\\ProjektInzynierski\\PortalWWW\\wwwroot\\css\\photos\\LOGO.png"), 300, 100, 225, 75);

            gfx.DrawString("Ticket number: " + ticket.Id, font, XBrushes.Black, new XRect(0, 10, page.Width, page.Height), format);
            gfx.DrawString("Movie: " + ticket.MovieName, font, XBrushes.Black, new XRect(0, 30, page.Width, page.Height), format);
            gfx.DrawString("Screen: " + ticket.RoomNumber, font, XBrushes.Black, new XRect(0, 50, page.Width, page.Height), format);
            gfx.DrawString("Seat: " + ticket.seatCode, font, XBrushes.Black, new XRect(0, 70, page.Width, page.Height), format);
            gfx.DrawString("Date: " + ticket.StartDate, font, XBrushes.Black, new XRect(0, 90, page.Width, page.Height), format);

            var path = string.IsNullOrEmpty(filePath) ? "C:/Users/pre12/Desktop/Ticket" + new Random().Next(100) + ".pdf" : filePath;
            document.Save(path);
        }
    }
}
