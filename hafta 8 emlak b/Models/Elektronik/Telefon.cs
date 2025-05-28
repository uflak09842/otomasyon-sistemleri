using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class Telefon
    {
        [Key]
        public int telId { get; set; }

        public string telAdi { get; set; }

        public float fiyat { get; set; }

        public int telMarkaId { get; set; }
        public TelMarka TelMarka { get; set; }

        public int depolamaId { get; set; }
        public Depolama Depolama { get; set; }

        public int ramId { get; set; }
        public Ram Ram { get; set; }

        public int bataryaId { get; set; }
        public Batarya Batarya { get; set; }

        public int hatId { get; set; }
        public Hat Hat { get; set; }

        public int hSarjId { get; set; }
        public HizliSarj HizliSarj { get; set; }

        public int comp5GId { get; set; }
        public Compability5G Compability5G { get; set; }

        public int suDayanId { get; set; }
        public Su Su { get; set; }

        public int suSertifikaId { get; set; }
        public SuSertifika SuSertifika { get; set; }

        public int cpuHzId { get; set; }
        public CpuHz CpuHz { get; set; }

        public int kameraCozId { get; set; }
        public KameraCoz KameraCoz { get; set; }

        public int ekranCozId { get; set; }
        public EkranCoz EkranCoz { get; set; }

        public int parmakIziId { get; set; }
        public ParmakIzi ParmakIzi { get; set; }
    }
}
