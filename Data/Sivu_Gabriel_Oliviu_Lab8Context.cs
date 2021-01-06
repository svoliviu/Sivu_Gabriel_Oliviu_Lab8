using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sivu_Gabriel_Oliviu_Lab8.Models;

namespace Sivu_Gabriel_Oliviu_Lab8.Data
{
    public class Sivu_Gabriel_Oliviu_Lab8Context : DbContext
    {
        public Sivu_Gabriel_Oliviu_Lab8Context (DbContextOptions<Sivu_Gabriel_Oliviu_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Sivu_Gabriel_Oliviu_Lab8.Models.Book> Book { get; set; }

        public DbSet<Sivu_Gabriel_Oliviu_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Sivu_Gabriel_Oliviu_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
