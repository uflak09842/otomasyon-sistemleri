using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.SporSalonu
{
    public class UyelikTip
    {
        [Key]
        public int uyelikId { get; set; }

        public string uyelikAdi { get; set; }

        public ICollection<SporSalonu> SporSalonlar { get; set; }
    }
}
