using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class Depolama
    {
        [Key]
        public int depolamaId { get; set; }

        public string depolamaAdi { get; set; }

        public ICollection<Telefon> Telefonlar { get; set; }
    }
}
