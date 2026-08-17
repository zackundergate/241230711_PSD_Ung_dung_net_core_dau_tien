using _241230711_PSD_Ung_dung_net_core_dau_tien.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _241230711_PSD_Ung_dung_net_core_dau_tien.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Product Name 1", Price = 500000, CreatedAt = DateTime.Now, Image = "/images/product1.jpg" },
            new Product { Id = 2, Name = "Product Name 2", Price = 700000, CreatedAt = DateTime.Now, Image = "/images/product2.jpg" },
            new Product { Id = 3, Name = "Product Name 3", Price = 550000, CreatedAt = DateTime.Now, Image = "/images/product3.jpg" },
            new Product { Id = 4, Name = "Product Name 4", Price = 650000, CreatedAt = DateTime.Now, Image = "/images/product4.jpg" }
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_products);
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
