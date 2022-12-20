using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Storage5.Models;

namespace Storage5.Data
{
    public class Storage5Context : DbContext
    {
        public Storage5Context (DbContextOptions<Storage5Context> options)
            : base(options)
        {
        }

        public DbSet<Storage5.Models.Product> Product { get; set; } = default!;

        public DbSet<Storage5.Models.ProductViewModel> ProductViewModel { get; set; }
    }
}
