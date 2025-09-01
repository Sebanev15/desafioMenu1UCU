using System;
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
        private string dishReturn;
        public string GetDishByName(string dishString)
        {
            foreach (Dish dish in this.dishes)
            {
                if (dish.Name == dishString)
                {
                    dishReturn = dish.Name;
                    break;
                }
                else
                {
                    dishReturn = null;
                }
            }
            return dishReturn;
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