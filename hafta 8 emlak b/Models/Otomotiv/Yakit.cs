using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Otomotiv
{
    public class Yakit
    {
        [Key] 
        public int yakitId { get; set; }

        public string yakitName { get; set; }

        public ICollection<Otomotiv> Otomotivler {  get; set; }   
    }
}
