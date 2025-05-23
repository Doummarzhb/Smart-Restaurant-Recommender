using SmartRestaurantRecommender.Models;

using Microsoft.AspNetCore.Identity;

namespace SmartRestaurantRecommender.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FavoriteCuisine { get; set; }
        public string PreferredMealTime { get; set; }
    }
}
