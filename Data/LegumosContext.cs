using ECF_LEGUMOS_CARRIVALE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECF_LEGUMOS_CARRIVALE.Data
{
    public class LegumosContext : DbContext
    {
        public LegumosContext(DbContextOptions<LegumosContext> options) : base(options)
        { }


        public DbSet<Vegetable> Vegetables { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}
