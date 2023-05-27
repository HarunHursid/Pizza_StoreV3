using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV3.Interfaces;
using Pizza_StoreV3.Models;
using Pizza_StoreV3.Services;

namespace Pizza_StoreV3
{
    public class GetAllPizzasModel : PageModel
    {
        //private PizzaCatalog catalog;
        IPizzaRepository catalog;
        public GetAllPizzasModel(IPizzaRepository Cat)
        {
            catalog =  Cat;
        }
        
        
        public Dictionary<int, Pizza> Pizzas { get; private set; }
        
        public Dictionary<int, Pizza> FilteredPizza { get;set; }
        
        
        [BindProperty(SupportsGet = true)]
        public string FilterCriteria { get;set; }
        public IActionResult OnGet()
        {
            Pizzas = catalog.AllPizzas();
            if (!string.IsNullOrEmpty(FilterCriteria))
            {
                Pizzas = catalog.FilterPizza(FilterCriteria);
            }
            else
            {
                Pizzas = catalog.AllPizzas();

            }
            return Page();
        }
    }
}