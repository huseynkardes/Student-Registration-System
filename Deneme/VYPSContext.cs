using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VYPS.Mvc.Models;

namespace Domain
{
    class VYPSContext : DbContext

    {
        public VYPSContext()
        {
            Configuration.LazyLoadingEnabled = false;
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
        public DbSet<Aka_ders> Aka_Ders { get; set; }
        public DbSet<Akademik> Akademiks { get; set; }
        public DbSet<Bolumler> Bolumlers { get; set; }
        public DbSet<Ders> Ders { get; set; }
        public DbSet<Notlar> Notlar { get; set; }
        public DbSet<Ogrenci> Ogrencis { get; set; }
    }
}
