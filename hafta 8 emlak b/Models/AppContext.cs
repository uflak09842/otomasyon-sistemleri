using Microsoft.EntityFrameworkCore;
using hafta_8_emlak_b.Models.Emlak;
using hafta_8_emlak_b.Models.Otomotiv;
using hafta_8_emlak_b.Models.IkinciEl;
using hafta_8_emlak_b.Models.Elektronik;
using hafta_8_emlak_b.Models.SporSalonu;
using hafta_8_emlak_b.Models.Kurs;

namespace hafta_8_emlak_b.Models
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }

        public DbSet<Ilce> Ilceler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }

        public DbSet<Emlak.Emlak> Emlaklar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Otomotiv.Otomotiv> Otomotivler { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Vites> Vitesler { get; set; }
        public DbSet<Yakit> Yakitlar { get; set; }

        public DbSet<IkinciEl.IkinciEl> IkinciEller { get; set; }
        public DbSet<UrunKategori> UrunKategoriler { get; set; }
        public DbSet<UrunDurum> UrunDurumlar { get; set; }

        public DbSet<Telefon> Telefonlar { get; set; }
        public DbSet<Kulaklik> Kulakliklar { get; set; }
        public DbSet<BaglantiTip> BaglantiTipler { get; set; }
        public DbSet<Batarya> Bataryalar { get; set; }
        public DbSet<Bluetooth> Bluetoothlar { get; set; }
        public DbSet<BtStandart> BtStandartlar { get; set; }
        public DbSet<Compability5G> Compability5Gler { get; set; }
        public DbSet<CpuHz> CpuHzler { get; set; }
        public DbSet<Depolama> Depolamalar { get; set; }
        public DbSet<EkranCoz> EkranCozler { get; set; }
        public DbSet<Hat> Hatlar { get; set; }
        public DbSet<HizliSarj> HizliSarjlar { get; set; }
        public DbSet<KameraCoz> KameraCozler { get; set; }
        public DbSet<Mikrofon> Mikrofonlar { get; set; }
        public DbSet<ParmakIzi> ParmakIzler { get; set; }
        public DbSet<Ram> Ramler { get; set; }
        public DbSet<SesCikis> SesCikislar { get; set; }
        public DbSet<Su> Sular {  get; set; }
        public DbSet<SuSertifika> SuSertifikalar { get; set; }
        public DbSet<TelMarka> TelMarkalar { get; set; }


        public DbSet<SporSalonu.SporSalonu> SporSalonlar { get; set; }
        public DbSet<UyelikTip> UyelikTipler { get; set; }
        public DbSet<Aktivite> Aktiviteler { get; set; }
        public DbSet<Olanak> Olanaklar { get; set; }


        public DbSet<Kurs.Kurs> Kurslar {  get; set; }
        public DbSet<Siniflar> Siniflar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emlak.Emlak>()
                .HasOne(p => p.Kategori)
                .WithMany(x => x.Emlaklar)
                .HasForeignKey(p => p.KatId);

            modelBuilder.Entity<Emlak.Emlak>()
                .HasOne(p => p.Ilce)
                .WithMany(x => x.Emlaklar)
                .HasForeignKey(p => p.ilceId);

            modelBuilder.Entity<Ilce>()
                .HasOne(p => p.Sehir)
                .WithMany(x => x.Ilceler)
                .HasForeignKey(p => p.Plaka);


            modelBuilder.Entity<Otomotiv.Otomotiv>()
                .HasOne(p => p.Marka)
                .WithMany(x => x.Otomotivler)
                .HasForeignKey(p => p.markaId);

            modelBuilder.Entity<Otomotiv.Otomotiv>()
                .HasOne(p => p.Vites)
                .WithMany(x => x.Otomotivler)
                .HasForeignKey(p => p.vitesId);

            modelBuilder.Entity<Otomotiv.Otomotiv>()
                .HasOne(p => p.Yakit)
                .WithMany(x => x.Otomotivler)
                .HasForeignKey(p => p.yakitId);

            modelBuilder.Entity<Otomotiv.Otomotiv>()
                .HasOne(p => p.Ilce)
                .WithMany(x => x.Otomotivler)
                .HasForeignKey(p => p.ilceId);


            modelBuilder.Entity<IkinciEl.IkinciEl>()
                .HasOne(p => p.UrunKategori)
                .WithMany(x => x.IkinciEller)
                .HasForeignKey(p => p.ukId);

            modelBuilder.Entity<IkinciEl.IkinciEl>()
                .HasOne(p => p.UrunDurum)
                .WithMany(x => x.IkinciEller)
                .HasForeignKey(p => p.durumId);

            modelBuilder.Entity<IkinciEl.IkinciEl>()
                .HasOne(p => p.Ilce)
                .WithMany(x => x.IkinciEller)
                .HasForeignKey(p => p.ilceId);


            modelBuilder.Entity<Telefon>()
                .HasOne(p => p.TelMarka)
                .WithMany(x => x.Telefonlar)
                .HasForeignKey(p => p.telMarkaId);

            modelBuilder.Entity<Telefon>()
                .HasOne(p => p.Depolama)
                .WithMany(x => x.Telefonlar)
                .HasForeignKey(p => p.depolamaId);

            modelBuilder.Entity<Telefon>()
                .HasOne(p => p.Ram)
                .WithMany(x => x.Telefonlar)
                .HasForeignKey(p => p.ramId);

            modelBuilder.Entity<Telefon>()
                .HasOne(p => p.TelMarka)
                .WithMany(x => x.Telefonlar)
                .HasForeignKey(p => p.telMarkaId);

            modelBuilder.Entity<Telefon>()
                .HasOne(p => p.Batarya)
                .WithMany(x => x.Telefonlar)
                .HasForeignKey(p => p.bataryaId);

            modelBuilder.Entity<Telefon>()
                .HasOne(p => p.Hat)
                .WithMany(x => x.Telefonlar)
                .HasForeignKey(p => p.hatId);

            modelBuilder.Entity<Telefon>()
                .HasOne(p => p.HizliSarj)
                .WithMany(x => x.Telefonlar)
                .HasForeignKey(p => p.hSarjId);

            modelBuilder.Entity<Telefon>()
                .HasOne(p => p.Compability5G)
                .WithMany(x => x.Telefonlar)
                .HasForeignKey(p => p.comp5GId);

            modelBuilder.Entity<Telefon>()
                .HasOne(p => p.Su)
                .WithMany(x => x.Telefonlar)
                .HasForeignKey(p => p.suDayanId);

            modelBuilder.Entity<Telefon>()
                .HasOne(p => p.SuSertifika)
                .WithMany(x => x.Telefonlar)
                .HasForeignKey(p => p.suSertifikaId);

            modelBuilder.Entity<Telefon>()
                .HasOne(p => p.CpuHz)
                .WithMany(x => x.Telefonlar)
                .HasForeignKey(p => p.cpuHzId);

            modelBuilder.Entity<Telefon>()
                .HasOne(p => p.KameraCoz)
                .WithMany(x => x.Telefonlar)
                .HasForeignKey(p => p.kameraCozId);

            modelBuilder.Entity<Telefon>()
                .HasOne(p => p.EkranCoz)
                .WithMany(x => x.Telefonlar)
                .HasForeignKey(p => p.ekranCozId);

            modelBuilder.Entity<Telefon>()
                .HasOne(p => p.ParmakIzi)
                .WithMany(x => x.Telefonlar)
                .HasForeignKey(p => p.parmakIziId);


            modelBuilder.Entity<Kulaklik>()
                .HasOne(p => p.SesCikis)
                .WithMany(x => x.Kulakliklar)
                .HasForeignKey(p => p.sesCikisId);

            modelBuilder.Entity<Kulaklik>()
                .HasOne(p => p.BaglantiTip)
                .WithMany(x => x.Kulakliklar)
                .HasForeignKey(p => p.baglantiTipId);

            modelBuilder.Entity<Kulaklik>()
                .HasOne(p => p.Bluetooth)
                .WithMany(x => x.Kulakliklar)
                .HasForeignKey(p => p.btId);

            modelBuilder.Entity<Kulaklik>()
                .HasOne(p => p.BtStandart)
                .WithMany(x => x.Kulakliklar)
                .HasForeignKey(p => p.btStandartId);

            modelBuilder.Entity<Kulaklik>()
                .HasOne(p => p.Mikrofon)
                .WithMany(x => x.Kulakliklar)
                .HasForeignKey(p => p.mikrofonId);


            modelBuilder.Entity<SporSalonu.SporSalonu>()
                .HasOne(p => p.UyelikTip)
                .WithMany(x => x.SporSalonlar)
                .HasForeignKey(p => p.uyelikId);



            modelBuilder.Entity<Kurs.Kurs>()
                .HasOne(p => p.Siniflar)
                .WithMany(x => x.Kurslar)
                .HasForeignKey(p => p.sinifId);

            modelBuilder.Entity<Kurs.Kurs>()
                .HasOne(p => p.Ilce)
                .WithMany(x => x.Kurslar)
                .HasForeignKey(p => p.ilceId);
        }
    }
}
