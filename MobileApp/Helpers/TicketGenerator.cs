﻿using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using QRCoder;

namespace MobileApp.Helpers
{
    public static class TicketGenerator
    {
        public static string IMAGE_LOGO_URL = @"http://localhost/images/photos/BLACKLOGO.png";

        public static void GenerateTicket(TicketInvoiceModel ticket, string? filePath)
        {
            // Custom ticket size: 200mm x 100mm (~7.8in x 3.9in)
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            page.Width = XUnit.FromMillimeter(150);  // Ticket width
            page.Height = XUnit.FromMillimeter(100); // Ticket height

            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Fonts
            XFont font = new XFont("Arial", 18, XFontStyleEx.Bold);
            XFont subtitleFont = new XFont("Arial", 16, XFontStyleEx.Bold);
            XFont normalFont = new XFont("Arial", 14, XFontStyleEx.Regular);

            // Margins
            int margin = 15;
            int yPosition = margin;

            // Draw Ticket Border
            gfx.DrawRectangle(XPens.Black, margin, margin, page.Width - 2 * margin, page.Height - 2 * margin);

            // Draw Logo
            using (HttpClient client = new HttpClient())
            {
                var imageData = client.GetByteArrayAsync(IMAGE_LOGO_URL).GetAwaiter().GetResult();
                string tempPath = Path.Combine(FileSystem.CacheDirectory, "temp_logo.png");
                File.WriteAllBytes(tempPath, imageData);

                XImage img = XImage.FromFile(tempPath);
                gfx.DrawImage(img, margin + 110, margin + 10, 180, 40);
            }
            yPosition += 60;

            // Separator Line
            gfx.DrawLine(XPens.Black, margin, yPosition, page.Width - margin, yPosition);
            yPosition += 30;

            // Ticket Details
            gfx.DrawString($"Ticket: {ticket.Id}", subtitleFont, XBrushes.Black, margin + 25, yPosition);
            yPosition += 25;

            gfx.DrawString($"Movie: {ticket.MovieName}", normalFont, XBrushes.Black, margin + 25, yPosition);
            yPosition += 20;

            gfx.DrawString($"Screen: {ticket.RoomNumber}", normalFont, XBrushes.Black, margin + 25, yPosition);
            yPosition += 20;

            gfx.DrawString($"Seat: {ticket.seatCode}", normalFont, XBrushes.Black, margin + 25, yPosition);
            yPosition += 20;

            gfx.DrawString($"Date: {ticket.StartDate}", normalFont, XBrushes.Black, margin + 25, yPosition);
            yPosition += 25;

            // QR Code Generation
            string qrText = $"Ticket: {ticket.Id} | Movie: {ticket.MovieName} | Seat: {ticket.seatCode}";
            string tempQrPath = Path.Combine(FileSystem.CacheDirectory, "temp_qr.bmp");
            File.WriteAllBytes(tempQrPath, GenerateQRCode(qrText));
            XImage qrImage = XImage.FromFile(tempQrPath);
            gfx.DrawImage(qrImage, page.Width - 200, page.Height - 200, 170, 170);

            // File Saving
            var ticketDirectory = Path.Combine(Directory.GetCurrentDirectory(), "resources/reports/");
            var path = string.IsNullOrEmpty(filePath) ? ticketDirectory + $"Ticket_{ticket.Id}.pdf" : filePath;
            document.Save(path);
        }

        private static byte[] GenerateQRCode(string qrText)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            BitmapByteQRCode qrCode = new BitmapByteQRCode(qrCodeData);
            return qrCode.GetGraphic(20);
        }
    }
}
