using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.IkinciEl
{
    public class UrunKategori
    {
        [Key]
        public int ukId { get; set; }

        public string ukAdi { get; set; }

        public ICollection<IkinciEl> IkinciEller {  get; set; } 
    }
}
