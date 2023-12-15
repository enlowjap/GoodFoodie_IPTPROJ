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
                new ProductModel { ProductId = 1, ImageUrl = "pictures/CHEEZY HAWAIIAN.jpeg", ProductName = "CHEEZY HAWAIIAN", Price = 19.99, StarRatings = 4 },
                new ProductModel { ProductId = 2, ImageUrl = "pictures/GRANDIOSA PIZZA.jpeg", ProductName = "GRANDIOSA", Price = 19.99, StarRatings = 3 },
                new ProductModel { ProductId = 3, ImageUrl = "pictures/HAWAIIAN.jpeg", ProductName = "HAWAIIAN", Price = 19.99, StarRatings = 3 },
                new ProductModel { ProductId = 4, ImageUrl = "pictures/Fried tacos.jpg", ProductName = "FRIED TACOS", Price = 19.99, StarRatings = 4 },
                new ProductModel { ProductId = 5, ImageUrl = "pictures/Chicken tacos.jpg", ProductName = "CHICKEN TACOS", Price = 19.99, StarRatings = 4 },
                new ProductModel { ProductId = 6, ImageUrl = "pictures/BBQ tacos.jpg", ProductName = "BBQ TACOS", Price = 19.99, StarRatings = 3 },
                new ProductModel { ProductId = 7, ImageUrl = "pictures/KOREAN HOTDOG.jpeg", ProductName = "KOREAN HOTDOG", Price = 19.99, StarRatings = 4 },
                new ProductModel { ProductId = 8, ImageUrl = "pictures/REGULAR HOTDOG.jpeg", ProductName = "REGULAR HOTDOG", Price = 19.99, StarRatings = 3 },
                new ProductModel { ProductId = 9, ImageUrl = "pictures/SPICY CHILI HOTDOG.jpeg", ProductName = "SPICY CHILI HOTDOG", Price = 19.99, StarRatings = 4 },
                new ProductModel { ProductId = 10, ImageUrl = "pictures/Cheese fries.jpg", ProductName = "CHEESE FRIES", Price = 19.99, StarRatings = 4 },
                new ProductModel { ProductId = 11, ImageUrl = "pictures/Fries with bacon and cheese.jpg", ProductName = "FRIES WITH BACON AND CHEESE", Price = 19.99, StarRatings = 3 },
                new ProductModel { ProductId = 12, ImageUrl = "pictures/BBQ FRIES.jpg", ProductName = "BBQ FRIES", Price = 19.99, StarRatings = 4 },
        };

            return View(products);
        }
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Contact()
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