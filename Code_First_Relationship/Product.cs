using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Relationship
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // 1'er 1'er arttırma olayıdır.
        public int UrunID { get; set; }

        [MaxLength(50)]
        [Required]
        public string UrunAdi { get; set; }

        public decimal? Fiyat { get; set; }
        public short? StokMiktari { get; set; }

        // Ürünün bir kategorisi olabilir. Ürün tablosu ve kategori tablosu arasında bire çok bir    ilişki vardır. Bu tanımlamayı virtual olarak yazdığımız property belirler.
        public int KategoriID { get; set; }

        [ForeignKey("KategoriID")]
        public virtual Category Kategori { get; set; }
    }
}