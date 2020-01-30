using DebugOnProdF452.Data;
using DebugOnProdF452.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DebugOnProdF452.Controllers
{
    public class HomeController : Controller
    {

        private RegistrationsDbContext _context = new RegistrationsDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Policies()
        {
            return View();
        }
        public ActionResult ViewRegistrations()
        {
            var items = _context.Registrations.ToList();
            return View(items);
        }

        [HttpPost]
        public async Task<ActionResult> RegisterInterest(Registration model)
        {
            _context.Registrations.Add(model);
            await _context.SaveChangesAsync();

            return View("Thanks", model);
        }
    }
}