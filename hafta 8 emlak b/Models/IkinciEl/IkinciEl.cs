using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.IkinciEl
{
    public class IkinciEl
    {
        [Key]
        public int urunId { get; set; }

        public string urunBaslik { get; set; }

        public int urunFiyat { get; set; }

        public int ukId { get; set; }
        public UrunKategori UrunKategori { get; set; }

        public int durumId { get; set; }
        public UrunDurum UrunDurum { get; set; }

        public int ilceId { get; set; }
        public Ilce Ilce { get; set; }

    }
}
