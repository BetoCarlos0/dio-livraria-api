using LivrariaApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaApi.Data
{
    public class LivrariaApiContext : DbContext
    {
        public LivrariaApiContext(DbContextOptions<LivrariaApiContext> option)
             : base(option)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
