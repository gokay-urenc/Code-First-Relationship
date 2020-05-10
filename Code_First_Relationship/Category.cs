using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Relationship
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // 1'er 1'er arttırma olayıdır.
        public int KategoriID { get; set; } // ID dendiğinde sistem otomatik Key olduğunu algılar.

        [Required]
        [MaxLength(50)]
        public string KategoriAdi { get; set; }

        [MaxLength(200)]
        public string Aciklama { get; set; }

        public virtual List<Product> Urunler { get; set; }
    }
}