using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShopping_Bit.Models;

namespace OnlineShopping_Bit.Data
{
    public class OnlineShopping_BitContext : DbContext
    {
        public OnlineShopping_BitContext (DbContextOptions<OnlineShopping_BitContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<OnlineShopping_Bit.Models.User> User { get; set; } = default!;
    }
}
