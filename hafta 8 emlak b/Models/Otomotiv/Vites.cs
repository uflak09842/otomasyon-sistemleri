using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Otomotiv
{
    public class Vites
    {
        [Key]
        public int vitesId { get; set; }

        public string vitesAdi { get; set; }

        public ICollection<Otomotiv> Otomotivler { get; set; }
    }
}