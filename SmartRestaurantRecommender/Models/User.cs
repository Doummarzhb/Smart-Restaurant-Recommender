using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartRestaurantRecommender.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public ICollection<UserPreference> Preferences { get; set; }
    }
}
