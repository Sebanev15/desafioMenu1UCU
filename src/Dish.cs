namespace Ucu.Poo.Restaurant
{
    public class Dish
    {
        private string Name { get; set; }
        private float Price { get; set; }
        private bool IsVegetarian { get; set; }

        public Dish( string name, float price, bool isVegetarian )
        {
            this.Name = name;
            this.Price = price;
            this.IsVegetarian = isVegetarian;
        }
    }
}