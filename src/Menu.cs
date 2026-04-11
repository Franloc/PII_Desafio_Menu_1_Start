using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Menu
    // La clase Menu tiene como responsabilidad gestionar la lista de platos disponibles, agregando dishes, sacando dishes y buscando dishes por su nombre
    {
        private List<Dish> dishes = new List<Dish>();
        public List<Dish> Dishes
        {
            get {return this.dishes;}
        }
        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }
        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }
        public Dish GetDishByName(string name)
        {
            for (int i=0;i<dishes.Count;i++)
            {
                if (dishes[i].Name==name)
                {
                    return dishes[i];
                }
            }
            return null;
        }
    }
}