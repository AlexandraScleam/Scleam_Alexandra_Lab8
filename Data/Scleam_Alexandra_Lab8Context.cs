using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Scleam_Alexandra_Lab8.Models;

namespace Scleam_Alexandra_Lab8.Data
{
    public class Scleam_Alexandra_Lab8Context : DbContext
    {
        public Scleam_Alexandra_Lab8Context (DbContextOptions<Scleam_Alexandra_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Scleam_Alexandra_Lab8.Models.Book> Book { get; set; }

        public DbSet<Scleam_Alexandra_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Scleam_Alexandra_Lab8.Models.Category> Category { get; set; }
    }
}
