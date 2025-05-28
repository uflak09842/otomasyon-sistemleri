using System.ComponentModel.DataAnnotations;
using hafta_8_emlak_b.Models;

namespace hafta_8_emlak_b.Models.Otomotiv
{
    public class Otomotiv
    {
        [Key]
        public int otoId { get; set; }

        public string otoAd { get; set; }

        public int otoYil { get; set; }

        public int otoKm { get; set; }

        public string otoRenk { get; set; }

        public decimal otoFiyat { get; set; }

        public int markaId { get; set; }
        public Marka Marka { get; set; }

        public int yakitId { get; set; }
        public Yakit Yakit { get; set; }

        public int vitesId { get; set; }
        public Vites Vites { get; set; }

        public int ilceId { get; set; }
        public Ilce Ilce { get; set; }
    }
}
