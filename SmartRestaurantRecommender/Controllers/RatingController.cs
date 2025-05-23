using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmartRestaurantRecommender.Data;
using SmartRestaurantRecommender.Models;


namespace SmartRestaurantRecommender.Controllers
{
    public class RatingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public RatingController(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Rate(int restaurantId, int stars)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return Unauthorized();

            var rating = new Rating
            {
                RestaurantId = restaurantId,
                UserId = user.Id,
                Stars = stars
            };

            _context.Ratings.Add(rating);
            await _context.SaveChangesAsync();

            // Update average rating
            var ratings = _context.Ratings.Where(r => r.RestaurantId == restaurantId);
            var average = ratings.Average(r => r.Stars);
            var restaurant = await _context.Restaurants.FindAsync(restaurantId);
            restaurant.AverageRating = average;
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
