using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV3.Interfaces;
using Pizza_StoreV3.Models;
using Pizza_StoreV3.Services;

namespace Pizza_StoreV3
{
    public class EditpizzaModel : PageModel
    {
    [BindProperty]
    public Pizza pizza { get; set; }

        public EditpizzaModel(IPizzaRepository Cat)
        {
            catalog = Cat;
        }
        IPizzaRepository catalog;
        public IActionResult OnGet(int Id)
        {
            pizza = catalog.GetPizza(Id);
            return Page();
        }

        public IActionResult OnPost() 
        { 
            if (!ModelState.IsValid)
            { 
                return Page(); 
            }
            catalog.UpdatePizza(pizza);
            return RedirectToPage("GetAllPizzas");
        }







    }





}