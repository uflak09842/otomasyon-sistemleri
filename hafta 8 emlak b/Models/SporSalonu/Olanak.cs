using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.SporSalonu
{
    public class Olanak
    {
        [Key]
        public int olanakId { get; set; }

        public string olanakAdi { get; set; }

        public ICollection<SporSalonu> SporSalonlar { get; set; }
    }
}
