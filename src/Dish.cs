namespace Ucu.Poo.Restaurant
{

    public class Dish
    {
        private string name;
        public string Name
        {
            get {return this.name;} set {this.name=value;}
        }
        private double price;
        public double Price
        { 
            get {return this.price;} set {this.price=value;}
        }
        private bool isVegetarian;
        public bool IsVegetarian
        {
            get {return this.isVegetarian;} set {this.isVegetarian=value;}
        }
        public Dish(string name, double price, bool isVegetarian)
        {
            this.Name=name;
            this.Price=price;
            this.IsVegetarian=isVegetarian;
        }
    }
}