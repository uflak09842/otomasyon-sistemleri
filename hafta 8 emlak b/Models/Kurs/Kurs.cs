using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Kurs
{
    public class Kurs
    {
        [Key]
        public int kursId { get; set; }

        public string kursAdi { get; set; }

        public decimal fiyat {  get; set; }

        public int sinifId { get; set; }
        public Siniflar Siniflar { get; set; }

        public int ilceId { get; set; }
        public Ilce Ilce { get; set; }
    }
}
