using Microsoft.EntityFrameworkCore;
using OkulApp.Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OkulApp
{
    public class OkulDataContext : DbContext
    {
        //Tabloları bağla

        public DbSet<DbSinif> Siniflar { get; set; }

        public DbSet<DbÖğrenci> Ogrenciler { get; set; }

        //Veritabanı bağlantı ayarları

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=" + Application.StartupPath + "\\mydb.db;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbSinif>()
                .HasMany(s => s.Ogrenciler)
                .WithOne(o => o.Sinif)
                .HasForeignKey(o => o.SinifId)
                .HasPrincipalKey(s => s.Id);
        }
    }
}
