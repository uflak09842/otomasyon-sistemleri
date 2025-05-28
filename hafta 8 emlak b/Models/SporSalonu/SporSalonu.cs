using System.ComponentModel.DataAnnotations;
using hafta_8_emlak_b.Models.SporSalonu;

namespace hafta_8_emlak_b.Models.SporSalonu
{
    public class SporSalonu
    {
        [Key]
        public int salonId { get; set; }

        public string salonAdi { get; set; }

        public decimal fiyat { get; set; }

        public int uyelikId { get; set; }
        public UyelikTip UyelikTip { get; set; }

        public int aktiviteId { get; set; }
        public Aktivite Aktivite { get; set; }

        public int olanakId { get; set; }
        public Olanak Olanak { get; set; }

        public int ilceId { get; set; }
        public Ilce Ilce { get; set; }
    }
}
