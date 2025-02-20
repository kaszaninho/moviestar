using DatabaseAPI.Data;
using DatabaseAPI.Models.CMS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Admin.CMS
{
    [Route("[controller]")]
    public class InvoiceTemplateInformationController : Controller
    {

        private readonly DatabaseAPIContext context;

        public InvoiceTemplateInformationController(DatabaseAPIContext context)
        {
            this.context = context;
        }

        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            return View(await context.InvoiceTemplateInformation.FirstOrDefaultAsync());
        }

        [HttpPost("Edit")]
        public IActionResult Edit(InvoiceTemplateInformation invoiceInfo)
        {
            context.InvoiceTemplateInformation.Update(invoiceInfo);
            context.SaveChanges();
            TempData["SuccessMessage"] = "Invoice template updated successfully!";
            return RedirectToAction("Index");
        }
    }
}
