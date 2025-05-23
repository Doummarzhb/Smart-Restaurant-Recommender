 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartRestaurantRecommender.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string UserId { get; set; }
        public int Stars { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

 
        public virtual Restaurant Restaurant { get; set; }
        public virtual User User { get; set; }
    }

}
