namespace Ucu.Poo.Restaurant
{
    public class Dish
    {
        private string name;
        private float price;
        private bool isVegetarian;
        public string Name
        {
            get { return this.name;}
            set { this.name = value; }
        }
        private float Price {
            get { return this.price;}
            set { this.price = value; } }
        private bool IsVegetarian { 
            get { return this.isVegetarian;}
            set { this.isVegetarian = value; } }

        public Dish( string thisName, float thisPrice, bool thisIsVegetarian )
        {
            this.name = thisName;
            this.price = thisPrice;
            this.isVegetarian = thisIsVegetarian;
        }
    }
}