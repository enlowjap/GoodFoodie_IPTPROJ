using GoodFoodie_IPTPROJ.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GoodFoodie_IPTPROJ.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = new List<ProductModel>
        {
                new ProductModel { ProductId = 1, ImageUrl = "pictures/L1.png", ProductName = "Product 1", Price = 19.99, StarRatings = 4 },
                new ProductModel { ProductId = 2, ImageUrl = "pictures/L1.png", ProductName = "Product 2", Price = 19.99, StarRatings = 3 },
                new ProductModel { ProductId = 3, ImageUrl = "pictures/L1.png", ProductName = "Product 3", Price = 19.99, StarRatings = 3 },
                new ProductModel { ProductId = 4, ImageUrl = "pictures/L1.png", ProductName = "Product 4", Price = 19.99, StarRatings = 4 },
                new ProductModel { ProductId = 5, ImageUrl = "pictures/L1.png", ProductName = "Product 5", Price = 19.99, StarRatings = 4 },
                new ProductModel { ProductId = 6, ImageUrl = "pictures/L1.png", ProductName = "Product 6", Price = 19.99, StarRatings = 3 },
                new ProductModel { ProductId = 7, ImageUrl = "pictures/L1.png", ProductName = "Product 7", Price = 19.99, StarRatings = 4 },
                new ProductModel { ProductId = 8, ImageUrl = "pictures/L1.png", ProductName = "Product 8", Price = 19.99, StarRatings = 3 },
                new ProductModel { ProductId = 9, ImageUrl = "pictures/L1.png", ProductName = "Product 9", Price = 19.99, StarRatings = 4 },
                new ProductModel { ProductId = 10, ImageUrl = "pictures/L1.png", ProductName = "Product 10", Price = 19.99, StarRatings = 4 },
                new ProductModel { ProductId = 11, ImageUrl = "pictures/L1.png", ProductName = "Product 11", Price = 19.99, StarRatings = 3 },
                new ProductModel { ProductId = 12, ImageUrl = "pictures/L1.png", ProductName = "Product 12", Price = 19.99, StarRatings = 4 },
        };

            return View(products);
        }
        [Authorize]
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