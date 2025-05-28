using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.IkinciEl
{
    public class UrunDurum
    {
        [Key]
        public int durumId { get; set; }

        public string durumAdi { get; set; }

        public ICollection<IkinciEl> IkinciEller { get; set; }
    }
}
