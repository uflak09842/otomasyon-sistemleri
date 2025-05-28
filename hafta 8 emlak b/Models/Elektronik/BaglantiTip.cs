using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class BaglantiTip
    {
        [Key]
        public int baglantiTipId { get; set; }

        public string baglatiTipi { get; set; }

        public ICollection<Kulaklik> Kulakliklar { get; set; }
    }
}
