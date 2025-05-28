using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class HizliSarj
    {
        [Key]
        public int hSarjId { get; set; }

        public bool hSarjVar { get; set; }

        public ICollection<Telefon> Telefonlar { get; set; }
    }
}
