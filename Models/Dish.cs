namespace DotNet_OneToMany_Dish.Models
{
    public class Dish
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public int Tastiness { get; set; }
        public String Description { get; set; }

        public Chef Chef { get; set; }
    }
}
