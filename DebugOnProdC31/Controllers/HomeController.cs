using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DebugOnProdC31.Models;
using DebugOnProdC31.Data;

namespace DebugOnProdC31.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RegistrationsDbContext _context;

        public HomeController(ILogger<HomeController> logger, RegistrationsDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Policies()
        {
            return View();
        }

        public IActionResult ViewRegistrations()
        {
            var items = _context.Registrations.ToList();
            return View(items);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterInterest(Registration model)
        {
            _context.Registrations.Add(model);
            await _context.SaveChangesAsync();
            
            var x = View("Thanks", model);
            return x;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
