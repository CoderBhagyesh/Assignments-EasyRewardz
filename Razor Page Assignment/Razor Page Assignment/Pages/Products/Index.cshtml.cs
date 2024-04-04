using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Page_Assignment.Pages.Products
{
    public class IndexModel : PageModel
    {
        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Price = 10.99 },
                new Product { Id = 2, Name = "Product 2", Price = 20.99 },
                new Product { Id = 3, Name = "Product 3", Price = 15.99 }
            };
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }
    }
}
