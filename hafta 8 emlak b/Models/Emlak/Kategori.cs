using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Emlak
{
    public class Kategori
    {
        [Key]
        public int KatId { get; set; }

        public string KatAdi { get; set; }

        public ICollection<Emlak> Emlaklar { get; set; }
    }
}
