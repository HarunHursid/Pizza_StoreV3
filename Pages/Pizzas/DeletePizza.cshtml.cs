using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV3.Interfaces;
using Pizza_StoreV3.Models;
using Pizza_StoreV3.Services;
namespace Pizza_StoreV3.Pages.Pizzas;

    public class DeletePizzaModel : PageModel
    {
        
        
            [BindProperty]
            public Pizza pizza { get; set; }

            public DeletePizzaModel(IPizzaRepository Cat)
            {
                Catalog = Cat;
            }
            IPizzaRepository Catalog;
            public IActionResult OnGet(int Id)
            {
                pizza = Catalog.GetPizza(Id);
                return Page();
            }

            public IActionResult OnPost()
            {
               
                Catalog.DeletePizza(pizza);
                return RedirectToPage("GetAllPizzas");
            }







        
    }
