using BusinessLogic;
using DatabaseAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using NuGet.Packaging;
using OfficeOpenXml;
using ServiceStack;
using ServiceStack.Text;
using System.Collections;
using System.ComponentModel;
using System.Data;
using LicenseContext = OfficeOpenXml.LicenseContext;
using static BusinessLogic.Constans;
using System.Diagnostics;
using Xceed.Words.NET;

namespace PortalWWW.Controllers.Admin.Report
{
    public class ReportController : Controller
    {

        private readonly DatabaseAPIContext context;

        public ReportController(DatabaseAPIContext context)
        {
            this.context = context;
        }

        public IActionResult MoviesGenerator(DateTime? start, DateTime? end)
        {
            DateTime? startDate = start == null ? new DateTime(2023, 1, 1) : start;
            DateTime? endDate = end == null ? new DateTime(2025, 12, 31) : end;
            var movies = context.Movie.Include(m => m.Genre).Where(movie => movie.CreatedAt >= startDate && movie.CreatedAt < endDate).ToList();

            var genres = context.Genre.Include(m => m.Movies).OrderBy(g => g.Name).ToList();

            HashSet<string> labels = new HashSet<string>();
            ArrayList genresCount = new ArrayList();
            for (int i = 0; i < genres.Count; i++)
            {
                genresCount.Add(genres[i].Movies.Count);
                labels.Add(genres[i].Name);
            }

            var chartData = new
            {
                labels = labels,
                datasets = new[]
                {
                    new
                    {
                        label = $"Movies' count in each genre from {startDate.GetValueOrDefault().ToShortDateString()} do {endDate.GetValueOrDefault().ToShortDateString()}",
                        data = genresCount,
                        backgroundColor = "rgba(75, 12, 12, 0.2)",
                        borderColor = "rgba(75, 12, 12, 1)",
                        borderWidth = 1
                    }
                }
            };

            return View(chartData);
        }

        public IActionResult InvoicesGenerator(DateTime? start, DateTime? end, string mode = "all")
        {
            ViewBag.PaymentStatuses = new SelectList(PaymentStatuses);

            ViewData["startDate"] = start == null ? new DateTime(2023, 1, 1) : start;
            ViewData["endDate"] = end == null ? new DateTime(2025, 12, 31) : end;
            ViewData["paymentMethod"] = mode;
            return View();
        }

        [HttpGet]
        public IActionResult GetAllInvoices(DateTime? start, DateTime? end, string mode = "all")
        {
            DateTime? startDate = start == null ? new DateTime(2023, 1, 1) : start;
            DateTime? endDate = end == null ? new DateTime(2025, 12, 31) : end;

            var invoices = context.Invoice
                .Include(inv => inv.User)
                .Include(inv => inv.PaymentMethod)
                .Where(inv => inv.CreatedAt >= startDate && inv.CreatedAt <= endDate)
                .ToList();
            var invoicesToShow = invoices.Where(inv => mode == "all" || inv.PaymentStatus == mode).ToList();
            return Json(new { data = invoicesToShow });
        }

        public IActionResult IncomeGenerator(DateTime? start, DateTime? end)
        {
            DateTime? startDate = start == null ? new DateTime(2023, 1, 1) : start;
            DateTime? endDate = end == null ? new DateTime(2025, 12, 31) : end;
            var invoices = context.Invoice.Include(inv => inv.PaymentMethod).Where(inv => inv.CreatedAt >= startDate && inv.CreatedAt < endDate).ToList();

            var paymentMethods = context.PaymentMethod.OrderBy(g => g.Name).ToList();

            HashSet<string> labels = new HashSet<string>();
            ArrayList paymentMethodsCount = new ArrayList();
            ArrayList paymentMethodsSum = new ArrayList();
            for (int i = 0; i < paymentMethods.Count; i++)
            {
                paymentMethodsCount.Add(invoices.Where(inv => inv.PaymentMethod == paymentMethods[i]).Count());
                paymentMethodsSum.Add(invoices.Where(inv => inv.PaymentMethod == paymentMethods[i]).Sum(inv => inv.Sum));
                labels.Add(paymentMethods[i].Name);
            }

            var chartData = new
            {
                labels = labels,
                datasets = new[]
                {
                    new
                    {
                        label = $"Invoice count with each payment method from {startDate.GetValueOrDefault().ToShortDateString()} do {endDate.GetValueOrDefault().ToShortDateString()}",
                        data = paymentMethodsCount,
                        backgroundColor = "rgba(75, 12, 12, 0.2)",
                        borderColor = "rgba(75, 12, 12, 1)",
                        borderWidth = 1
                    },
                    new
                    {
                        label = $"Income with each payment method from {startDate.GetValueOrDefault().ToShortDateString()} do {endDate.GetValueOrDefault().ToShortDateString()}",
                        data = paymentMethodsSum,
                        backgroundColor = "rgba(15, 72, 12, 0.2)",
                        borderColor = "rgba(75, 12, 12, 1)",
                        borderWidth = 1
                    }
                }
            };
            decimal totalSum = 0;
            foreach (var x in paymentMethodsSum)
            {
                totalSum += (decimal)x;
            }
            ViewData["totalSum"] = totalSum;
            return View(chartData);
        }



        // Method for converting data to a DataTable
        private DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;
        }


        [HttpPost]
        public IActionResult ExportExcel(string status)
        {
            // Set EPPlus license context
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            try
            {
                using (var package = new ExcelPackage())
                {

                    // List of statuses you want to include in the Excel file
                    var statuses = new[] { "all", PaymentStatus_Approved, PaymentStatus_Pending, PaymentStatus_Rejected };

                    foreach (var currentStatus in statuses)
                    {
                        // Fetch data for the current status
                        var invoices = context.Invoice
                                             .Where(o => currentStatus == "all" || o.PaymentStatus == currentStatus)
                                             .Select(o => new
                                             {
                                                 o.InvoiceId,
                                                 o.User,
                                                 o.CreatedAt,
                                                 o.OrderStatus,
                                                 o.PaymentStatus,
                                                 o.Sum
                                             }).ToList();

                        // Convert the data to DataTable
                        DataTable tableData = ConvertToDataTable(invoices);

                        // Create a new worksheet for each status
                        var worksheet = package.Workbook.Worksheets.Add(currentStatus.ToUpper());

                        // Add column headers
                        for (int i = 0; i < tableData.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = tableData.Columns[i].ColumnName;
                            worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                        }

                        // Add row data
                        for (int i = 0; i < tableData.Rows.Count; i++)
                        {
                            for (int j = 0; j < tableData.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = tableData.Rows[i][j];
                            }
                        }
                    }

                    // Save to a memory stream
                    using (var stream = new MemoryStream())
                    {
                        package.SaveAs(stream);
                        stream.Position = 0;

                        var fileName = $"Invoices_Report_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
                        var mimeType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

                        return File(stream.ToArray(), mimeType, fileName);
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error generating Excel file: {ex.Message}");
            }
        }

        public IActionResult ExportDoc()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ExportDoc(string status)
        {
            if (status == null || status == "")
            {
                status = "all";
            }
            // Fetch all orders if the status is "all", otherwise filter by the specified status
            var invoices = context.Invoice
                                             .Where(o => status == "all" || o.PaymentStatus == status)
                                             .Select(o => new
                                             {
                                                 o.InvoiceId,
                                                 o.User,
                                                 o.CreatedAt,
                                                 o.OrderStatus,
                                                 o.PaymentStatus,
                                                 o.Sum
                                             }).ToList();

            // Ensure the directory for reports exists
            var reportDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/reports");
            if (!Directory.Exists(reportDirectory))
            {
                Directory.CreateDirectory(reportDirectory);
            }

            // If no orders are available, return a "No data available" PDF
            if (!invoices.Any())
            {
                // Create a temporary file for the "No data available" PDF
                var noDataDocxPath = Path.Combine(reportDirectory, $"NoDataReport_{DateTime.Now:yyyyMMddHHmmss}.docx");
                var noDataPdfPath = Path.Combine(reportDirectory, $"NoDataReport_{DateTime.Now:yyyyMMddHHmmss}.pdf");

                // Use DocX to create a simple .docx with "No data available"
                using (var document = DocX.Create(noDataDocxPath))
                {
                    document.InsertParagraph("No data available").FontSize(16).Bold();
                    document.SaveAs(noDataDocxPath);
                }

                // Convert the .docx to PDF using LibreOffice
                var process = new Process();
                process.StartInfo.FileName = @"C:\Program Files\LibreOffice\program\soffice.exe"; // Update path for Windows
                process.StartInfo.Arguments = $"--headless --convert-to pdf --outdir \"{Path.GetDirectoryName(noDataPdfPath)}\" \"{noDataDocxPath}\"";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.Start();
                process.WaitForExit();

                // Return the "No data available" PDF to the user
                byte[] noDataPdfBytes = System.IO.File.ReadAllBytes(noDataPdfPath);
                return File(noDataPdfBytes, "application/pdf", $"NoDataReport_{DateTime.Now:yyyyMMddHHmmss}.pdf");
            }

            // Path to the Word template (docx file)
            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/templates", "InvoiceTemplate.docx");

            // Path to save the generated .docx file
            var docxOutputPath = Path.Combine(reportDirectory, $"InvoiceReport_{DateTime.Now:yyyyMMddHHmmss}.docx");

            // Path to save the generated PDF
            var pdfOutputPath = Path.Combine(reportDirectory, $"InvoiceReport_{DateTime.Now:yyyyMMddHHmmss}.pdf");

            // Load the Word template
            using (DocX document = DocX.Load(templatePath))
            {
                // Set the order status in the template
                document.ReplaceText("{InvoiceStatus}", status);

                // Find the table in the document
                var table = document.Tables[0]; // Assuming the table is in the first position

                // Iterate through each invoice and add data to the table
                foreach (var invoice in invoices)
                {
                    var row = table.InsertRow();
                    row.Cells[0].Paragraphs[0].Append(invoice.InvoiceId.ToString());
                    row.Cells[1].Paragraphs[0].Append(invoice.User.UserName);
                    row.Cells[2].Paragraphs[0].Append(invoice.CreatedAt.ToString());
                    row.Cells[3].Paragraphs[0].Append(invoice.PaymentStatus);
                    row.Cells[4].Paragraphs[0].Append(invoice.OrderStatus);
                    row.Cells[5].Paragraphs[0].Append(invoice.Sum.ToString());
                }

                // Save the generated document as a .docx file
                document.SaveAs(docxOutputPath);
            }

            // Convert the .docx document to PDF using LibreOffice
            var convertProcess = new Process();
            convertProcess.StartInfo.FileName = @"C:\Program Files\LibreOffice\program\soffice.exe"; // Update path for Windows
            convertProcess.StartInfo.Arguments = $"--headless --convert-to pdf --outdir \"{Path.GetDirectoryName(pdfOutputPath)}\" \"{docxOutputPath}\"";
            convertProcess.StartInfo.RedirectStandardOutput = true;
            convertProcess.StartInfo.UseShellExecute = false;
            convertProcess.Start();
            convertProcess.WaitForExit();

            // Download the generated PDF for the user
            byte[] pdfBytes = System.IO.File.ReadAllBytes(pdfOutputPath);
            return File(pdfBytes, "application/pdf", $"InvoiceReport_{DateTime.Now:yyyyMMddHHmmss}.pdf");
        }
    }
}
