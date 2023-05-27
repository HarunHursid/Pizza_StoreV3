using Pizza_StoreV3.Interfaces;
using Pizza_StoreV3.Models;
using System.Collections.Generic;
using Pizza_StoreV3.Helpers;
using System.Linq;

namespace Pizza_StoreV3.Services
{
    public class PizzaJson : IPizzaRepository
    {
        public void AddPizza(Pizza pizza)
        {
            //throw new System.NotImplementedException();
            Dictionary<int, Pizza> pizzas = AllPizzas();
                if (!(pizzas.Keys.Contains(pizza.Id)))
                pizzas.Add(pizza.Id, pizza);
            JsonFileWriter.WriteToJson(pizzas, @"data\pizzajson.json");

        }

        public Dictionary<int, Pizza> AllPizzas()
        {
            //throw new System.NotImplementedException();
            return JsonFileReader.ReadJson(@"data\pizzajson.json");
        }

        public void DeletePizza(Pizza pizza)
        {
            throw new System.NotImplementedException();
        }

        public Dictionary<int, Pizza> FilterPizza(string criteria)
        {
            //throw new System.NotImplementedException();
             //Dictionary<int, Pizza> FilterPizza(string criteria)
            //{
                Dictionary<int, Pizza> pizzas = AllPizzas();    
                
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
           // }

        }

        public Pizza GetPizza(int Id)
        {
            throw new System.NotImplementedException();
        }

        public void UpdatePizza(Pizza pizza)
        {
            throw new System.NotImplementedException();
        }
    }
}
