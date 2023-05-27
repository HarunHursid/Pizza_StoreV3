using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV3.Models;
using Pizza_StoreV3.Services;
using Pizza_StoreV3.Interfaces;

namespace Pizza_StoreV3
{
    public class CreatePizzaModel : PageModel
    {
        IPizzaRepository catalog;
        [BindProperty]
        public Pizza Pizza { get; set; }
        public CreatePizzaModel(IPizzaRepository Cat)
        {
            catalog = Cat;
        }

        
        public IActionResult OnGet()
        {
           
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            catalog.AddPizza(Pizza);
           return RedirectToPage("GetAllPizzas");
        }
    }
}