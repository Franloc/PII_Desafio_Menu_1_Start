using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Order
    {
        private List<Dish> orders = new List<Dish>();
        public List<Dish> Orders
        {
            get {return this.orders;} set {this.orders=value;}
        }
        private bool isDelivery;
        public bool IsDelivery
        {
            get {return this.isDelivery;} set {this.isDelivery=value;}
        }
        public Order(List<Dish> orders, bool isDelivery)
        {
            this.Orders=orders;
            this.IsDelivery=isDelivery;
        }
        public double GetTotal()
        {
            double total=0;
            for (int i=0;i<Orders.Count;i++)
            {
                Dish dish=Orders[i];
                total+=dish.Price;
            }
            return total;
        }
    }
}