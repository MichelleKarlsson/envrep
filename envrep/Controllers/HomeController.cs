using envrep.DataAccess;
using envrep.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace envrep.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private RecordContext _db = new RecordContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            var viewModel = new ListModel { Records = _db.Records.ToList() };
            return View(viewModel); 
        }

        [Route("PostRecord/{temp?}/{hum?}/{co2?}")]
        public IActionResult PostRecord(double? temp, double? hum, double? co2)
        {
            var viewModel = new RecordPostViewModel {temp = temp, hum = hum, co2 = co2 };
            _db.Records.Add(viewModel);
            _db.SaveChanges();
            return View(viewModel);
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}