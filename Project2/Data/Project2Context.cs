using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project2.Modles;

namespace Project2.Data
{
    public class Project2Context : DbContext
    {
        public DbSet<Project2.Modles.Movie> Movie { get; set; }
        public Project2Context (DbContextOptions<Project2Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Modles.Movie>().HasData(new Modles.Movie() { ID = Guid.NewGuid(), Name = "Star Wars III", MovieL = "120 m" });
        }
    }
}
