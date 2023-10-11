using System.ComponentModel.DataAnnotations;

namespace DotNet_OneToMany_Dish.Models
{
    public class Chef
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public List<Dish>? Dishes { get; set; }
    }
}
