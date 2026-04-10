namespace Ucu.Poo.Restaurant
{
    public class Table
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
            get {return this.Order;} set {this.Order=value;}
        }
        public Table(int number, Order order)
        {
            this.Number=number;
            this.IsOccupied=false;
            this.Order=order;
        }
        public void Occupy()
        {
            IsOccupied=true;
        }
        public void Free()
        {
            IsOccupied=false;
            order.Orders.Clear();
        }
        public void AddToOrder(Dish dish)
        {
            order.Orders.Add(dish);
        }
        public bool HasOrders()
        {
            return this.order.Orders.Count > 0;
        }
    }
}