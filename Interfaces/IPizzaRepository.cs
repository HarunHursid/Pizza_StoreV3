using Pizza_StoreV3.Models;
using System.Collections.Generic;

namespace Pizza_StoreV3.Interfaces
{
    public interface IPizzaRepository
    {
		    Dictionary<int, Pizza> AllPizzas();

			Dictionary<int, Pizza> FilterPizza(string crtiteria);

			public void DeletePizza(Pizza pizza);

			public void AddPizza(Pizza pizza);

			public void UpdatePizza(Pizza pizza);

			public Pizza GetPizza(int Id);

    }
}
