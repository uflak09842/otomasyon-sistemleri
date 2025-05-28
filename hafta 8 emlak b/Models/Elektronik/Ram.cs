using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class Ram
    {
        [Key]
        public int ramId { get; set; }  

        public int ramMiktari { get; set; }

        public ICollection<Telefon> Telefonlar { get; set; }
    }
}
