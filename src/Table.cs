using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private List<Dish> order = new List<Dish>();

        private int Number { get; set; }
        
        private bool IsOccupied { get; set; }
        
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }

        public void Occupy()
        {
            if (this.IsOccupied)
            {
                Console.WriteLine("ERROR: Esta mesa ya esta ocupada.");
            }
            else
            {
                this.IsOccupied = true;
                Console.WriteLine("Se ha ocupado la mesa correctamente");
            }
        }

        public void Free()
        {
            if (this.IsOccupied)
            {
                this.IsOccupied = false;
                this.order.Clear();
                Console.WriteLine("Se ha liberado la mesa correctamente");
            }
            else
            {
                Console.WriteLine("ERROR: La mesa todavia no estaba ocupada");
            }
        }

        public void AddToOrder(Dish thisDish)
        {
            if (this.IsOccupied)
            {
                this.order.Add(thisDish);
                Console.WriteLine("El plato se ha añadido a la orden");
            }
            else
            {
                Console.WriteLine("ERROR: La mesa no esta ocupada, por lo que no se puede realizar una orden");
            }
        }

    }
}