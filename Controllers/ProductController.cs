using _241230711_PSD_Ung_dung_net_core_dau_tien.Models;
using Microsoft.AspNetCore.Mvc;

namespace _241230711_PSD_Ung_dung_net_core_dau_tien.Controllers
{
    public class ProductController : Controller
    {
        private static readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Product 1", Price = 500000, CreatedAt = new DateTime(2020, 12, 25), Image = "/images/product1.jpg" },
            new Product { Id = 2, Name = "Product 2", Price = 700000, CreatedAt = new DateTime(2020, 12, 25), Image = "/images/product2.jpg" },
            new Product { Id = 3, Name = "Product 3", Price = 550000, CreatedAt = new DateTime(2020, 12, 25), Image = "/images/product3.jpg" },
            new Product { Id = 4, Name = "Product 4", Price = 650000, CreatedAt = new DateTime(2020, 12, 25), Image = "/images/product4.jpg" }
        };
        public IActionResult Index()
        {
            return View(_products);
        }
    }
}
