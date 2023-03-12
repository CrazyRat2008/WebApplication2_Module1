using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static WebApplication2.Pages.Index2Model;

namespace WebApplication2.Pages
{
    public class Index2Model : PageModel
    { 
        public List<Country> country = new List<Country>();
        public void OnGet()
        {
            country = new List<Country>{
                new Country { Name = "Country1", Population = "213123", Language = "Country1" },
                new Country { Name = "Country2", Population = "3142134", Language = "Country2", },
                new Country { Name = "Country3", Population = "632452", Language = "Country3"  }
            };
        }
    }
    public class Country
    {
        public string Name { get; set; }
        public string Population { get; set; }
        public string Language { get; set; } 
    }
}
