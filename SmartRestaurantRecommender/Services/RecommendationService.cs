using SmartRestaurantRecommender.Data;
using SmartRestaurantRecommender.Models;

namespace SmartRestaurantRecommender.Services
{
    public class RecommendationService
    {
        private readonly AppDbContext _context;

        public RecommendationService(AppDbContext context)
        {
            _context = context;
        }

        public List<Restaurant> GetRecommendationsForUser(int userId)
        {
            var prefs = _context.UserPreferences.Where(p => p.UserId == userId).ToList();

            var query = _context.Restaurants.AsQueryable();

            foreach (var pref in prefs)
            {
                query = query.Where(r => r.Cuisine.Contains(pref.PreferredCuisine) &&
                                         r.MealTime == pref.PreferredMealTime);
            }

            return query.Take(5).ToList();
        }
    }

}
