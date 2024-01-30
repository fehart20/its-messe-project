using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Messe_Projekt_Client
{
    public class MesseDbContext : DbContext
    {
        public DbSet<Kunde> Kunde {  get; set; }
        public DbSet<Anschrift> Anschrift { get; set;}
        public DbSet<Interesse> Interesse { get; set; }
        public DbSet<Firma> Firma { get; set;}

        public string DbPath { get; }

        public MesseDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "messe.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
