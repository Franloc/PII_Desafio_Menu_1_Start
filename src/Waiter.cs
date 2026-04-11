using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Waiter
    // La clase Waiter tiene la responsabilidad de asignar mesas y tomar órdenes
    {
        private string name;
        public string Name
        {
            get {return this.name;} set {this.name=value;}
        }
        private List<Table> assignedTables = new List<Table>();
        public List<Table> AssignedTables
        {
            get {return this.assignedTables;}
        }
        public Waiter(string name)
        {
            this.Name=name;
        }
        public void AssignTable(Table table)
        {
            AssignedTables.Add(table);
        }
        public void TakeOrder(Table table, Dish dish)
        {
            table.AddToOrder(dish);
        }
    }
}