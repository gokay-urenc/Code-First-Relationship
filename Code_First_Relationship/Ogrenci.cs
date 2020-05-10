using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Relationship
{
    public class Ogrenci
    {
        // Öğretmen ve öğretmen arasında çoka çok bir ilişki vardır.
        public int OgrenciID { get; set; }
        public string OgrenciAdi { get; set; }
        public int Yas { get; set; }
        public virtual List<Ogretmen> Ogretmenleri { get; set; }
    }
}