using Pizza_StoreV3.Interfaces;
using Pizza_StoreV3.Models;
using Pizza_StoreV3.Pages.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_StoreV3.Services
{
    public class PizzaCatalog : IPizzaRepository
    {
        private Dictionary<int, Pizza> pizzas { get; }
        //private static PizzaCatalog _instance;
        public PizzaCatalog()
        {
            pizzas = new Dictionary<int, Pizza>();
            pizzas.Add(1, new Pizza() { Id = 1, Name = "Cheese_pizza", Description = " Made of cheese", Price = 98, ImageName = "Chicken_pizza.jfif" });
            pizzas.Add(2, new Pizza() { Id = 2, Name = "Bufalla_pizza", Description = " Made of bufalla", Price = 59, ImageName = "Cheese_pizza.jfif" });
            pizzas.Add(3, new Pizza() { Id = 3, Name = "Chicken_pizza", Description = " Made of chicken", Price = 120, ImageName = "Chicken_pizza.jfif" });
            pizzas.Add(4, new Pizza() { Id = 4, Name = "Mozzarella_pizza", Description = " Made of mozzarella", Price = 77, ImageName = "Mozzarella_pizza.jfif" });
            pizzas.Add(5, new Pizza() { Id = 5, Name = "Vegetable_pizza", Description = " Made of vegetars", Price = 88, ImageName = "Cheese_pizza.jfif" });
        }

        //public static PizzaCatalog Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new PizzaCatalog();
        //        }
        //        return _instance;
        //    }
        //}

        public Dictionary<int, Pizza> AllPizzas()
        {
            return pizzas;
        }
        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza.Id, pizza);
        }

        public Pizza GetPizza(int Id)
        {
            return pizzas[Id];
        }
        public void UpdatePizza(Pizza pizza)
        { //pizzas{pizza.Id} = pizza;
            if (pizza != null)
            {
                foreach (var p in AllPizzas())
                {
                    if (p.Key == pizza.Id)
                    {
                        p.Value.Name = pizza.Name;
                        p.Value.Description = pizza.Description;
                        p.Value.Price = pizza.Price;
                        p.Value.Id = pizza.Id;
                    }
                }
            }
        }

        public void DeletePizza(Pizza pizza)
        {
            if (pizza != null)
            {
                pizzas.Remove(pizza.Id);
            }

        }

        public Dictionary<int, Pizza> FilterPizza(string criteria)
        {
            Dictionary<int, Pizza> filteredpizzas = new Dictionary<int, Pizza>();
            if (criteria != null)
            {
                foreach (var p in pizzas.Values)
                {
                    if (p.Name.ToLower().StartsWith(criteria.ToLower()))
                    {
                        filteredpizzas.Add(p.Id, p);
                    }
                }
            }
            return filteredpizzas;
        }


    }
}

