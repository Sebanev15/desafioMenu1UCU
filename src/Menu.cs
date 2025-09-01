using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        public string GetDishByName(string dishString)
        {
            foreach (Dish dish in this.dishes)
            {
                if (dish.Name == dishString)
                {
                    return dish.Name;
                }
                else
                {
                    return null;
                }
            }
        }
        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }

        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }
    }
}