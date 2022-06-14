using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VYPS.Model2.Models;

namespace VYPS.Domain2
{
    class VYPSContext : DbContext

    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Okul;Integrated Security=True;");
            

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Aka_Ders> Aka_Ders { get; set; }
        public DbSet<Akademik> Akademiks { get; set; }
        public DbSet<Bolumler> Bolumlers { get; set; }
        public DbSet<Ders> Ders { get; set; }
        public DbSet<Notlar> Notlar { get; set; }
        public DbSet<Ogrenci> Ogrencis { get; set; }

        
    }
}
