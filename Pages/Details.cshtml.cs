using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPizz.Data;
using RazorPagesPizz.Models;

namespace RazorPagesPizz.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesPizz.Data.RazorPagesPizzaContext _context;

        public DetailsModel(RazorPagesPizz.Data.RazorPagesPizzaContext context)
        {
            _context = context;
        }

      public Pizza Pizza { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pizzas == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas.FirstOrDefaultAsync(m => m.Id == id);
            if (pizza == null)
            {
                return NotFound();
            }
            else 
            {
                Pizza = pizza;
            }
            return Page();
        }
    }
}
