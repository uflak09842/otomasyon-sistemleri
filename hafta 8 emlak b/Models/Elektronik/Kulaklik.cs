using System.ComponentModel.DataAnnotations;

namespace hafta_8_emlak_b.Models.Elektronik
{
    public class Kulaklik
    {
        [Key]
        public int kulaklikId { get; set; }

        public string kulaklikAdi { get; set; }

        public float fiyat {  get; set; }

        public int sesCikisId { get; set; }
        public SesCikis SesCikis { get; set; }

        public int baglantiTipId {  get; set; }
        public BaglantiTip BaglantiTip { get; set; }

        public int btId { get; set; }
        public Bluetooth Bluetooth { get; set; }

        public int btStandartId { get; set; }
        public BtStandart BtStandart { get; set; }

        public int mikrofonId { get; set; }
        public Mikrofon Mikrofon { get; set; }
    }
}
