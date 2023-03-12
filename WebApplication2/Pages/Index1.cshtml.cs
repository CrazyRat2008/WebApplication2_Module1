using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace WebApplication2.Pages
{
    public class Res 
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }  
    }
    public class Index1Model : PageModel
    {
        public List<Res> restaurants = new List<Res>();
       
    public void OnGet()
    {
            restaurants = new List<Res>{
                new Res() { Name = "Restaurant 1", Address = "Address 1", Phone = "123-456-7890" },
                new Res() { Name = "Restaurant 2", Address = "Address 2", Phone = "123-456-7891"},
                new Res() { Name = "Restaurant 3", Address = "Address 3", Phone = "123-456-7892" },
            };
        }
    }
}
