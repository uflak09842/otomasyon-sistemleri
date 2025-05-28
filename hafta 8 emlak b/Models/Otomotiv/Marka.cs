using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Otomotiv
{
    public class Marka
    {
        [Key]
        public int markaId { get; set; }

        public string markaAd { get; set; }

        public ICollection<Otomotiv> Otomotivler { get; set; }

    }
}
