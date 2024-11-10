using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using System.Diagnostics;

namespace PetShop.Controllers
{
    public class EmpregadoController : Controller
    {
        private readonly ILogger<EmpregadoController> _logger;

        public EmpregadoController(ILogger<EmpregadoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
