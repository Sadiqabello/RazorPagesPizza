using System;
using Microsoft.EntityFrameworkCore;
using RazorPagesPizz.Models;

namespace RazorPagesPizz.Data
{
    public class RazorPagesPizzaContext : DbContext
    {
        public RazorPagesPizzaContext(DbContextOptions<RazorPagesPizzaContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}

