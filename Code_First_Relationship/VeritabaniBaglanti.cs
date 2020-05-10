using System;
using System.Collections.Generic;
using System.Data.Entity; //
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Relationship
{
    public class VeritabaniBaglanti : DbContext
    {
        public VeritabaniBaglanti()
        {
            Database.Connection.ConnectionString = "Server=.;Database=CodeFirst2;Trusted_Connection=true";
        }
        public DbSet<Category> Kategoriler { get; set; }
        public DbSet<Product> Urunler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
    }
}