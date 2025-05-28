using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class SuSertifika
    {
        [Key]
        public int suSertifikaId { get; set; }

        public string suSertifikaAdi { get; set; }

        public ICollection<Telefon> Telefonlar { get; set; }
    }
}
