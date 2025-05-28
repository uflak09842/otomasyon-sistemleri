using hafta_8_emlak_b.Models.IkinciEl;
using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models
{
    public class Ilce
    {
        [Key]
        public int ilceId { get; set; }

        public string ilceAdi { get; set; }

        public int Plaka { get; set; }
        public Sehir Sehir { get; set; }

        public ICollection<Emlak.Emlak> Emlaklar { get; set; }
        
        public ICollection<Otomotiv.Otomotiv> Otomotivler { get; set;}

        public ICollection<IkinciEl.IkinciEl> IkinciEller { get; set; }

        public ICollection<SporSalonu.SporSalonu> SporSalonlar { get; set; }

        public ICollection<Kurs.Kurs> Kurslar { get; set; }
    }
}
