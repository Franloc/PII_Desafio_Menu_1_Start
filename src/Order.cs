using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Order
    //Order gestiona los platos de una orden y tiene la información necesaria para calcular el total de la orden con GetTotal(), además conoce si un pedido es delivery o no
    {
        private List<Dish> orders = new List<Dish>();
        public List<Dish> Orders
        {
            get {return this.orders;} set {this.orders=value;}
        }
        private bool isDelivery;
        public bool IsDelivery
        {
            get {return this.isDelivery;}
        }
        public Order(bool isDelivery)
        {
            this.isDelivery = isDelivery;
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
        public void AddDish(Dish dish)
        {
            this.orders.Add(dish);
        }
        public void Clear()
        {
            this.orders.Clear();
        }
    }
}