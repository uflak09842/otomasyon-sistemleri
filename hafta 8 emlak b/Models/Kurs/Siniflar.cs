using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Kurs
{
    public class Siniflar
    {
        [Key]
        public int sinifId { get; set; }

        public string sinifAdi { get; set; }

        public ICollection<Kurs> Kurslar { get; set; }
    }
}
