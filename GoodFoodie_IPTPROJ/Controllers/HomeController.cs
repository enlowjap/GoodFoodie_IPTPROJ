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
        public IActionResult Menu()
        {
            var products = new List<ProductModel>
        {
                new ProductModel { ProductId = 1, ImageUrl = "/pictures/CHEEZY HAWAIIAN.jpeg", ProductName = "CHEEZY HAWAIIAN", Price = 19.99, StarRatings = 4, Category = "Pizza"},
                new ProductModel { ProductId = 2, ImageUrl = "/pictures/GRANDIOSA PIZZA.jpeg", ProductName = "GRANDIOSA", Price = 19.99, StarRatings = 3, Category = "Pizza"},
                new ProductModel { ProductId = 3, ImageUrl = "/pictures/HAWAIIAN.jpeg", ProductName = "HAWAIIAN", Price = 19.99, StarRatings = 3, Category = "Pizza" },
                new ProductModel { ProductId = 4, ImageUrl = "/pictures/Fried tacos.jpg", ProductName = "FRIED TACOS", Price = 19.99, StarRatings = 4, Category = "Tacos"},
                new ProductModel { ProductId = 5, ImageUrl = "/pictures/Chicken tacos.jpg", ProductName = "CHICKEN TACOS", Price = 19.99, StarRatings = 4, Category = "Tacos" },
                new ProductModel { ProductId = 6, ImageUrl = "/pictures/BBQ tacos.jpg", ProductName = "BBQ TACOS", Price = 19.99, StarRatings = 3, Category = "Tacos" },
                new ProductModel { ProductId = 7, ImageUrl = "/pictures/Fish Tacos Combo.jpeg", ProductName = "FISH TACOS COMBO", Price = 19.99, StarRatings = 4, Category = "Tacos"  },
                new ProductModel { ProductId = 8, ImageUrl = "/pictures/Chicken Caesar Wrap Meal.jpeg", ProductName = "CHICKEN CAESAR WRAP MEAL", Price = 19.99, StarRatings = 4, Category = "Tacos"},
                new ProductModel { ProductId = 9, ImageUrl = "/pictures/KOREAN HOTDOG.jpeg", ProductName = "KOREAN HOTDOG", Price = 19.99, StarRatings = 4, Category = "Hotdogs" },
                new ProductModel { ProductId = 10, ImageUrl = "/pictures/REGULAR HOTDOG.jpeg", ProductName = "REGULAR HOTDOG", Price = 19.99, StarRatings = 3, Category = "Hotdogs" },
                new ProductModel { ProductId = 11, ImageUrl = "/pictures/SPICY CHILI HOTDOG.jpeg", ProductName = "SPICY CHILI HOTDOG", Price = 19.99, StarRatings = 4, Category = "Hotdogs" },
                new ProductModel { ProductId = 12, ImageUrl = "/pictures/Cheese fries.jpg", ProductName = "CHEESE FRIES", Price = 19.99, StarRatings = 4, Category = "Fries" },
                new ProductModel { ProductId = 13, ImageUrl = "/pictures/Fries with bacon and cheese.jpg", ProductName = "FRIES WITH BACON AND CHEESE", Price = 19.99, StarRatings = 3, Category = "Fries" },
                new ProductModel { ProductId = 14, ImageUrl = "/pictures/BBQ FRIES.jpg", ProductName = "BBQ FRIES", Price = 19.99, StarRatings = 4, Category = "Fries"  },
                new ProductModel { ProductId = 15, ImageUrl = "/pictures/BURGER OVERLOAD.jpeg", ProductName = "BURGER OVERLOAD", Price = 19.99, StarRatings = 4, Category = "Sandwiches"  },
                new ProductModel { ProductId = 16, ImageUrl = "/pictures/BURGER STEAK.jpeg", ProductName = "BURGER STEAK", Price = 19.99, StarRatings = 3, Category = "Sandwiches"  },
                new ProductModel { ProductId = 17, ImageUrl = "/pictures/Cheese-Sandwich.jpg", ProductName = "CHEESE SANDWHICH", Price = 19.99, StarRatings = 3, Category = "Sandwiches"  },
                new ProductModel { ProductId = 18, ImageUrl = "/pictures/CHICKEN BURGER.jpeg", ProductName = "CHICKEN BURGER", Price = 19.99, StarRatings = 4, Category = "Sandwiches" },
                new ProductModel { ProductId = 19, ImageUrl = "/pictures/Chicken-Sandwich.jpg", ProductName = "CHICKEN SANDWHICH", Price = 19.99, StarRatings = 3, Category = "Sandwiches" },
                new ProductModel { ProductId = 20, ImageUrl = "/pictures/Classic Burger Combo.jpeg", ProductName = "CLASSIC BURGER COMBO", Price = 19.99, StarRatings = 4, Category = "Sandwiches" },
                new ProductModel { ProductId = 21, ImageUrl = "/pictures/Egg-Sandwich.jpg", ProductName = "EGG SANDWHICH", Price = 19.99, StarRatings = 3, Category = "Sandwiches" },
                new ProductModel { ProductId = 22, ImageUrl = "/pictures/Grilled-Cheese.jpg", ProductName = "GRILLED CHEESE", Price = 19.99, StarRatings = 4, Category = "Sandwiches" },
                new ProductModel { ProductId = 23, ImageUrl = "/pictures/Grilled-Chicken-Sandwich.jpg", ProductName = "GRILLED CHICKEN SANDWHICH", Price = 19.99, StarRatings = 3, Category = "Sandwiches"},
                new ProductModel { ProductId = 24, ImageUrl = "/pictures/Ham-Sandwich.jpg", ProductName = "HAM SANDWHICH", Price = 19.99, StarRatings = 4, Category = "Sandwiches" },
                new ProductModel { ProductId = 25, ImageUrl = "/pictures/Ice-Cream-Sandwich.jpg", ProductName = "ICE CREAM SANDWHICH", Price = 19.99, StarRatings = 4, Category = "Sandwiches" },
                 new ProductModel { ProductId = 26, ImageUrl = "/pictures/Roast-Beef-Sandwich.jpg", ProductName = "ROAST BEEF SANDWHICH", Price = 19.99, StarRatings = 4, Category = "Sandwiches" },
                new ProductModel { ProductId = 27, ImageUrl = "/pictures/Vegetarian Burrito Bowl.jpeg", ProductName = "VEGETARIAN BURRITO BOWL", Price = 19.99, StarRatings = 4, Category = "Special Meals" },
                new ProductModel { ProductId = 28, ImageUrl = "/pictures/salad.jpg", ProductName = "SALAD", Price = 19.99, StarRatings = 4, Category = "Special Meals" },
                new ProductModel { ProductId = 29, ImageUrl = "/pictures/ONE POT CAJUN CHICKEN AND RICE.jpg", ProductName = "ONE POT CAJUN CHICKEN AND RICE", Price = 19.99, StarRatings = 4, Category = "Special Meals" },
                new ProductModel { ProductId = 30, ImageUrl = "/pictures/winter.jpg", ProductName = "WINTERMELON", Price = 19.99, StarRatings = 4, Category = "MilkTea" },
                new ProductModel { ProductId = 31, ImageUrl = "/pictures/oki.jpg", ProductName = "OKINAWA", Price = 19.99, StarRatings = 4, Category = "MilkTea" },
               new ProductModel { ProductId = 32, ImageUrl = "/pictures/MATCHA MILKTEA.jpg", ProductName = "MATCHA", Price = 19.99, StarRatings = 4, Category = "MilkTea" },
                 new ProductModel { ProductId = 33, ImageUrl = "/pictures/straw.jpg", ProductName = "STRAWBERRY", Price = 19.99, StarRatings = 4, Category = "MilkTea" },
               new ProductModel { ProductId = 34, ImageUrl = "/pictures/mango.jpg", ProductName = "MANGO", Price = 19.99, StarRatings = 4, Category = "MilkTea" },
                new ProductModel { ProductId = 35, ImageUrl = "/pictures/choco.jpg", ProductName = "CHOCOLATE", Price = 19.99, StarRatings = 4, Category = "MilkTea" },
            };

            return View(products);
        }
        [Authorize]
        public IActionResult Cart()
        {
            var products = new List<ProductModel>
    {
        new ProductModel { ProductId = 1, ProductName = "Product 1", ImageUrl = "/pictures/ONE POT CAJUN CHICKEN AND RICE.jpg", Price = 10.99, Quantity = 1 },
        new ProductModel { ProductId = 2, ProductName = "Product 2", ImageUrl = "/pictures/MATCHA MILKTEA.jpg", Price = 20.99, Quantity = 1 },
        new ProductModel { ProductId = 3, ProductName = "Product 3", ImageUrl = "/pictures/Grilled-Chicken-Sandwich.jpg", Price = 10.99, Quantity = 1 },
        // Add 8 more products here with unique ProductId, ProductName, ImageUrl, Price, and Quantity values
    };

            return View(products);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }


}