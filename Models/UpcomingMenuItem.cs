using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MenuAppBlazor.Models
{
    public class UpcomingMenuItem
    {
        public int Id { get; set; }

        [Required]
        public int DishId { get; set; }

        [ForeignKey("DishId")]
        public Dish Dish { get; set; } = null!;

        //public DateTime AddedOn { get; set; } = DateTime.Now;
    }
}
