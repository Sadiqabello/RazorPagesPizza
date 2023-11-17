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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesPizz.Data.RazorPagesPizzaContext _context;

        public IndexModel(RazorPagesPizz.Data.RazorPagesPizzaContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pizzas != null)
            {
                Pizza = await _context.Pizzas.ToListAsync();
            }
        }
    }
}
