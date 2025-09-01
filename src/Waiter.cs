using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        private string Name { get; set; }
        private List<Table> assignedTables = new List<Table>();

        public Waiter(string name)
        {
            this.Name = name;
        }

        public void AssignTable(Table Number)
        {
            this.assignedTables.Add(Number);
        }

        public void TakeOrder(Table thisTable, Dish fullDish)
        {
            
            if (assignedTables.Contains(thisTable)){
                
                thisTable.AddToOrder(fullDish);
                Console.WriteLine("Pedido tomado correctamente de la mesa");

            }
            else
            {
                
                Console.WriteLine("ERROR:Esta mesa no corresponde");
            }

        }

    }
}