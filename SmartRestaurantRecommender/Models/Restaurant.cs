using System.ComponentModel.DataAnnotations;

namespace SmartRestaurantRecommender.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Cuisine { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string MealTime { get; set; } // Breakfast, Lunch, Dinner

        public double AverageRating { get; set; }   
        public List<Rating> Ratings { get; set; }
    }
}
