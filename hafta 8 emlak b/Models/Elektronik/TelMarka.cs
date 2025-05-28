using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class TelMarka
    {
        [Key]
        public int telMarkaId { get; set; }

        public string telMarkaAdi { get; set; }

        public ICollection<Telefon> Telefonlar { get; set; }
    }
}
