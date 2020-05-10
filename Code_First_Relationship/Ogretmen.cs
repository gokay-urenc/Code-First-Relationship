using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Relationship
{
    public class Ogretmen
    {
        // Öğretmen ve öğretmen arasında çoka çok bir ilişki vardır.
        public int OgretmenID { get; set; }
        public string Adi { get; set; }
        public int Yas { get; set; }
        public virtual List<Ogrenci> Ogrencileri { get; set; }
    }
}