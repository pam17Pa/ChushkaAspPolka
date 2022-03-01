using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChuschkaPolya.Data
{
    public class ChuschkaDbContext: DbContext
    {
        public ChuschkaDbContext(DbContextOptions<ChuschkaDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }

    }
}
