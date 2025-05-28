using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class Hat
    {
        [Key]
        public int hatId { get; set; }

        public string hatTur {  get; set; }

        public ICollection<Telefon> Telefonlar { get; set; }
    }
}
