namespace Ucu.Poo.Restaurant
{
    public class Table
    // La clase Table tiene la responsabilidad de gestionar su estado (ocupada o no ocupada) y la orden asociada
    {
        private int number;
        public int Number 
        {
            get {return this.number;} set {this.number=value;}
        }
        private bool isOccupied;
        public bool IsOccupied
        {
            get {return this.isOccupied;} set {this.isOccupied=value;}
        }
        private Order order;
        public Order Order
        {
            get {return this.order;} set {this.order=value;}
        }
        public Table(int number)
        {
            this.Number=number;
            this.IsOccupied=false;
        }
        public void Occupy()
        {
            IsOccupied=true;
        }
        public void Free()
        {
            IsOccupied=false;
            order.Clear();
        }
        public void AddToOrder(Dish dish) // Le da a order la responsabilidad de agregar un plato a la orden
        {
            order.AddDish(dish);
        }
        public bool HasOrders()
        {
            return this.order.Orders.Count > 0;
        }
        public void AssignOrder(Order order) // AssignOrder permite que hayan pedidos que sean para delivery y no tengan mesa
        {
           this.order = order;
        }
    }
}