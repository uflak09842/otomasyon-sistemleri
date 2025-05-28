using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models
{
    public class Sehir
    {
        [Key]
        public int Plaka { get; set; }

        public string SehirAdi { get; set; }

        public ICollection<Ilce> Ilceler {  get; set; }
    }
}
