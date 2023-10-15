using System.ComponentModel.DataAnnotations;

namespace DotNet_OneToMany_Dish.Models
{
    public class Dish
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Calories { get; set; }

        public int Tastiness { get; set; }

        public string Description { get; set; }

        public int ChefId { get; set; }

        public Chef Chef { get; set; }
    }
}
