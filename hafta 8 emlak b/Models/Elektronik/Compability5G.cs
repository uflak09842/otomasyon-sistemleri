using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class Compability5G
    {
        [Key]
        public int comp5GId { get; set; }

        public bool comp5GVar { get; set; }

        public ICollection<Telefon> Telefonlar { get; set; }
    }
}
