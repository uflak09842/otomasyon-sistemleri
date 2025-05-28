using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class KameraCoz
    {
        [Key]
        public int kameraCozId { get; set; }

        public int kameraCoz {  get; set; }

        public ICollection<Telefon> Telefonlar { get; set; }
    }
}
