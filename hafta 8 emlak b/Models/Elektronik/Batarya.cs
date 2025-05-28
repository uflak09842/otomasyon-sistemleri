using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class Batarya
    {
        [Key]
        public int bataryaId { get; set; }

        public int bataryaMiktarı { get; set; }

        public ICollection<Telefon> Telefonlar { get; set; }
    }
}
