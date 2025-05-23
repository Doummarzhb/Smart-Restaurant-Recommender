using Microsoft.AspNetCore.Mvc;
using SmartRestaurantRecommender.Models;
using System.Diagnostics;
using System.Collections.Generic;

namespace SmartRestaurantRecommender.Controllers
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
            //     (mock data)
            var restaurants = new List<Restaurant>
            {
                new Restaurant { Name = "Pizza Town", Cuisine = "Italian", MealTime = "Lunch", Location = "Downtown" },
                new Restaurant { Name = "Sushi Hub", Cuisine = "Japanese", MealTime = "Dinner", Location = "City Center" },
                new Restaurant { Name = "Falafel Express", Cuisine = "Middle Eastern", MealTime = "Breakfast", Location = "Hamra" }
            };

            return View(restaurants); //   View
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
