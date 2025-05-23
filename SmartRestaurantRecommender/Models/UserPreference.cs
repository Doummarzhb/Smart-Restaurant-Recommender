using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRestaurantRecommender.Models
{
    public class UserPreference
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string PreferredCuisine { get; set; }

        [Required]
        public string PreferredMealTime { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
