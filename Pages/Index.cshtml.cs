using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApp.Data;
using MyWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> ProductList { get; set; } = default!;

        public void OnGet()
        {
            ProductList = _context.Products.ToList();
        }
    } // <-- cierre de la clase
} // <-- cierre del namespace


