using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class BtStandart
    {
        [Key]
        public int btStandartId { get; set; }

        public float btStandart { get; set; }

        public ICollection<Kulaklik> Kulakliklar { get; set; }
    }
}
