using System;
using System.Data.Entity;
using System.Linq;
using WindowsFormsAppEFCodeFirst.Entites;

namespace WindowsFormsAppEFCodeFirst
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Kategori> Kategoriler { get; set; } //Category
        public virtual DbSet<Urun> Urunler { get; set; }
    }    
}