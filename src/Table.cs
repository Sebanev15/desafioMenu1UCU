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

        private int number;
        public int Number
        {
            get { return this.number;}
            set { this.number = value; }
        }

        private bool isOccupied;

        public bool IsOccupied
        {
            get { return this.isOccupied; }
            set { this.isOccupied = value; }
        }

        public Table(int thisnumber)
        {
            this.number = thisnumber;
            this.isOccupied = false;
        }
        
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }

        public void Occupy()
        {
            if (this.isOccupied)
            {
                Console.WriteLine("ERROR: Esta mesa ya esta ocupada.");
            }
            else
            {
                this.isOccupied = true;
                Console.WriteLine("Se ha ocupado la mesa correctamente");
            }
        }

        public void Free()
        {
            if (this.isOccupied)
            {
                this.isOccupied = false;
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
            if (this.isOccupied)
            {
                this.order.Add(thisDish);
                Console.WriteLine("El plato "+ thisDish.Name + " se ha añadido a la orden");
            }
            else
            {
                Console.WriteLine("ERROR: La mesa no esta ocupada, por lo que no se puede realizar una orden");
            }
        }

    }
}