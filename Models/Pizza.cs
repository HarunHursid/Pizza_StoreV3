using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;



namespace Pizza_StoreV3.Models
{
    public class Pizza
    {
        //[Required(ErrorMessage = "Id is required")]
        //[Range(typeof(decimal), "1", "150", ErrorMessage = "value for {0} must be between {1} and {2}")]
        public int Id { get; set; }

        [Display(Name = "pizza name")]
        [Required(ErrorMessage = "Name of pizza is required"),MaxLength (20)]
        public string Name { get; set; }

        [Display(Description = "description of pizza")]
        [Required(ErrorMessage = "descriptionen of pizza is required"),MaxLength (35)]
        public string Description { get; set; }

        
        [Required(ErrorMessage = "price is required")]
        [Range(typeof(decimal),"1","150", ErrorMessage ="value for {0} must be between {1} and {2}")]
            
        public decimal Price { get; set; }
        
        
        public string ImageName { get; set; }
    }
}
