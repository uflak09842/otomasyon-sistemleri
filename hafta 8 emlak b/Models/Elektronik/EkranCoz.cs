using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class EkranCoz
    {
        [Key]
        public int ekranCozId { get; set;}

        public int ekranCozYatay { get; set;}

        public int ekranCozDikey { get; set;}

        public ICollection<Telefon> Telefonlar { get; set;}
    }
}
