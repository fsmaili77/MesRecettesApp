using MesRecettes.Data;
using MesRecettes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace MesRecettes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // Example of how to use the context to retrieve data
            var recettes = _context.UniteDeMesures.FromSqlRaw("SELECT * FROM UniteDeMesures").ToList();
            // You can pass the data to the view if needed

            return View(recettes);
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

        public async Task<IActionResult> Recettes()
        {
            var recettes = await _context.Recettes
                .Include(r => r.TypeAliment)
                .Include(r => r.OrigineAliment)
                .Include(recettes => recettes.RecetteIngredients)
                    .ThenInclude(ri => ri.Ingredient)
                .ToListAsync();
            return View(recettes);
        }
    }
}