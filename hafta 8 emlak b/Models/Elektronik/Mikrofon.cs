using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class Mikrofon
    {
        [Key]
        public int mikrofonId { get; set; }
        
        public bool mikrofonVar {  get; set; }

        public ICollection<Kulaklik> Kulakliklar { get; set; }
    }
}
