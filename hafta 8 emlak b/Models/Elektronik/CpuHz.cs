using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class CpuHz
    {
        [Key]
        public int cpuHzId { get; set; }

        public float cpuHz { get; set; }

        public ICollection<Telefon> Telefonlar { get; set; }
    }
}
