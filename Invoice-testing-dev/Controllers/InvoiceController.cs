using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SixStorage.AutoInvoice.WebApi.Shared.DTOs.AutoInvoice;

namespace Invoice_testing_dev.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult invoiceView()
        {
            InvoicePdfDto model = new InvoicePdfDto();
            var folderDetails = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\{"Json\\model.json"}");
            var JSON = System.IO.File.ReadAllText(folderDetails);
            try
            {
                model = JsonConvert.DeserializeObject<InvoicePdfDto>(JSON);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View(model);
        }

    }
}
