using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class SesCikis
    {
        [Key]
        public int sesCikisId { get; set; }

        public string sesCikisTur { get; set; }

        public ICollection<Kulaklik> Kulakliklar { get; set; }
    }
}
