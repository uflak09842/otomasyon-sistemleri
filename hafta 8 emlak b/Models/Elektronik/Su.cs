using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class Su
    {
        [Key]
        public int suDayanId { get; set; }

        public bool suDayananikli {  get; set; }

        public ICollection<Telefon> Telefonlar  { get; set; }
    }
}
