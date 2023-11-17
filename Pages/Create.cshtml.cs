using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesPizz.Data;
using RazorPagesPizz.Models;

namespace RazorPagesPizz.Pages
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesPizz.Data.RazorPagesPizzaContext _context;

        public CreateModel(RazorPagesPizz.Data.RazorPagesPizzaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pizza Pizza { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Pizzas == null || Pizza == null)
            {
                return Page();
            }

            _context.Pizzas.Add(Pizza);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
