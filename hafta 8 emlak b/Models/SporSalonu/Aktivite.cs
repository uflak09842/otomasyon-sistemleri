using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.SporSalonu
{
    public class Aktivite
    {
        [Key]
        public int aktiviteId { get; set; }

        public string aktiviteAdi { get; set; }

        public ICollection<SporSalonu> SporSalonlar { get; set; }
    }
}
