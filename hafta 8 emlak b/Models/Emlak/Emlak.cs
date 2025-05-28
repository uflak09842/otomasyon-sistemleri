using System.ComponentModel.DataAnnotations;
using hafta_8_emlak_b.Models;

namespace hafta_8_emlak_b.Models.Emlak
{
    public class Emlak
    {
        [Key]
        public int EmlakId { get; set; }

        public string EmlakAdi { get; set; }

        public decimal Fiyat { get; set; }

        public int KatId { get; set; }
        public Kategori Kategori { get; set; }

        public int ilceId { get; set; }
        public Ilce Ilce { get; set; }
    }
}
