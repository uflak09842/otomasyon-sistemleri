using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class Bluetooth
    {
        [Key]
        public int btId { get; set; }

        public bool btVar {  get; set; }

        public ICollection<Kulaklik> Kulakliklar { get; set; }
    }
}
