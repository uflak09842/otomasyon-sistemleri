using hafta_8_emlak_b.Models.Emlak;
using hafta_8_emlak_b.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using hafta_8_emlak_b.Models.Elektronik;

namespace hafta_8_emlak_b.Controllers
{
    public class ElektronikController : Controller
    {
        private readonly Models.AppContext _context;

        public ElektronikController(Models.AppContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var getTelefonlar = _context.Telefonlar
                .Include(p => p.TelMarka)
                .Include(p => p.Depolama)
                .Include(p => p.Ram)
                .Include(p => p.Batarya)
                .Include(p => p.Hat)
                .Include(p => p.HizliSarj)
                .Include(p => p.Compability5G)
                .Include(p => p.Su)
                .Include(p => p.SuSertifika)
                .Include(p => p.CpuHz)
                .Include(p => p.KameraCoz)
                .Include(p => p.EkranCoz)
                .Include(p => p.ParmakIzi)
                .AsQueryable();

            var getKulakliklar = _context.Kulakliklar
                .Include(k => k.SesCikis)
                .Include(k => k.BaglantiTip)
                .Include(k => k.Bluetooth)
                .Include(k => k.BtStandart)
                .Include(k => k.Mikrofon);

            var telefonlar = await getTelefonlar.ToListAsync();
            var kulakliklar = await getKulakliklar.ToListAsync();

            ViewBag.Telefonlar = telefonlar;
            ViewBag.Kulakliklar = kulakliklar;

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Telefonlar(int? marka, int? ram, int? depolama, int? batarya, bool? besG)
        {
            var getTelefonlar = _context.Telefonlar
                .Include(p => p.TelMarka)
                .Include(p => p.Depolama)
                .Include(p => p.Ram)
                .Include(p => p.Batarya)
                .Include(p => p.Hat)
                .Include(p => p.HizliSarj)
                .Include(p => p.Compability5G)
                .Include(p => p.Su)
                .Include(p => p.SuSertifika)
                .Include(p => p.CpuHz)
                .Include(p => p.KameraCoz)
                .Include(p => p.EkranCoz)
                .Include(p => p.ParmakIzi)
                .AsQueryable();

            if (marka.HasValue)
            {
                getTelefonlar = getTelefonlar.Where(p => p.telMarkaId == marka.Value);
            }

            if (ram.HasValue)
            {
                getTelefonlar = getTelefonlar.Where(p => p.ramId == ram.Value);
            }

            if (depolama.HasValue)
            {
                getTelefonlar  = getTelefonlar.Where(p => p.depolamaId == depolama.Value);
            }

            if(batarya.HasValue)
            {
                getTelefonlar = getTelefonlar.Where(p => p.bataryaId == batarya.Value);
            }

            if(besG.HasValue)
            {
                getTelefonlar = getTelefonlar.Where(p => p.Compability5G.comp5GVar == besG.Value);
            }

            var telefonlar = await getTelefonlar.ToListAsync();

            ViewBag.TelMarkalar = _context.TelMarkalar.ToList();
            ViewBag.Depolamalar = _context.Depolamalar.ToList();
            ViewBag.Ramler = _context.Ramler.ToList();
            ViewBag.Bataryalar = _context.Bataryalar.ToList();
            ViewBag.Compability5Gler = _context.Compability5Gler.ToList();

            return View(telefonlar);
        }

        [HttpGet]
        public async Task<IActionResult> Kulakliklar(int? sesCikis, int? baglantiTip, bool? bluetooth, int? btStandart, bool? mikrofon)
        {
            var getKulakliklar = _context.Kulakliklar
                .Include(k => k.SesCikis)
                .Include(k => k.BaglantiTip)
                .Include(k => k.Bluetooth)
                .Include(k => k.BtStandart)
                .Include(k => k.Mikrofon)
                .AsQueryable();

            if (sesCikis.HasValue)
            {
                getKulakliklar = getKulakliklar.Where(p => p.sesCikisId == sesCikis.Value);
            }

            if (baglantiTip.HasValue)
            {
                getKulakliklar = getKulakliklar.Where(p => p.baglantiTipId == baglantiTip.Value);
            }

            if (bluetooth.HasValue)
            {
                getKulakliklar = getKulakliklar.Where(p => p.Bluetooth.btVar == bluetooth.Value);
            }

            if (btStandart.HasValue)
            {
                getKulakliklar = getKulakliklar.Where(p => p.btStandartId == btStandart.Value);
            }

            if (mikrofon.HasValue)
            {
                getKulakliklar = getKulakliklar.Where(p => p.Mikrofon.mikrofonVar == mikrofon.Value);
            }

            var kulakliklar = await getKulakliklar.ToListAsync();

            ViewBag.SesCikislar = _context.SesCikislar.ToList();
            ViewBag.BaglantiTipler = _context.BaglantiTipler.ToList();
            ViewBag.Bluetoothlar = _context.Bluetoothlar.ToList();
            ViewBag.BtStandartlar = _context.BtStandartlar.ToList();
            ViewBag.Mikrofonlar = _context.Mikrofonlar.ToList();

            return View(kulakliklar);
        }

        public IActionResult Ekle()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> TelefonEkle()
        {
            var getTelefonlar = _context.Telefonlar
                .Include(p => p.TelMarka)
                .Include(p => p.Depolama)
                .Include(p => p.Ram)
                .Include(p => p.Batarya)
                .Include(p => p.Hat)
                .Include(p => p.HizliSarj)
                .Include(p => p.Compability5G)
                .Include(p => p.Su)
                .Include(p => p.SuSertifika)
                .Include(p => p.CpuHz)
                .Include(p => p.KameraCoz)
                .Include(p => p.EkranCoz)
                .Include(p => p.ParmakIzi)
                .AsQueryable();

            var telefonlar = await getTelefonlar.ToListAsync();

            ViewBag.TelMarkalar = await _context.TelMarkalar.ToListAsync();
            ViewBag.Depolamalar = await _context.Depolamalar.ToListAsync();
            ViewBag.Ramler = await _context.Ramler.ToListAsync();
            ViewBag.Bataryalar = await _context.Bataryalar.ToListAsync();
            ViewBag.Hatlar = await _context.Hatlar.ToListAsync();
            ViewBag.HizliSarjlar = await _context.HizliSarjlar.ToListAsync();
            ViewBag.Compability5Gler = await _context.Compability5Gler.ToListAsync();
            ViewBag.Sular = await _context.Sular.ToListAsync();
            ViewBag.SuSertifikalar = await _context.SuSertifikalar.ToListAsync();
            ViewBag.CpuHzler = await _context.CpuHzler.ToListAsync();
            ViewBag.KameraCozler = await _context.KameraCozler.ToListAsync();
            ViewBag.EkranCozler = await _context.EkranCozler.ToListAsync();
            ViewBag.ParmakIzler = await _context.ParmakIzler.ToListAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TelefonEkle(Telefon telefon)
        {
            try
            {
                _context.Telefonlar.Add(telefon);

                await _context.SaveChangesAsync();

                return RedirectToAction("Telefonlar");
            }
            catch (Exception ex)
            {
                ViewBag.TelMarkalar = await _context.TelMarkalar.ToListAsync();
                ViewBag.Depolamalar = await _context.Depolamalar.ToListAsync();
                ViewBag.Ramler = await _context.Ramler.ToListAsync();
                ViewBag.Bataryalar = await _context.Bataryalar.ToListAsync();
                ViewBag.Hatlar = await _context.Hatlar.ToListAsync();
                ViewBag.HizliSarjlar = await _context.HizliSarjlar.ToListAsync();
                ViewBag.Compability5Gler = await _context.Compability5Gler.ToListAsync();
                ViewBag.Sular = await _context.Sular.ToListAsync();
                ViewBag.SuSertifikalar = await _context.SuSertifikalar.ToListAsync();
                ViewBag.CpuHzler = await _context.CpuHzler.ToListAsync();
                ViewBag.KameraCozler = await _context.KameraCozler.ToListAsync();
                ViewBag.EkranCozler = await _context.EkranCozler.ToListAsync();
                ViewBag.ParmakIzler = await _context.ParmakIzler.ToListAsync();

                return View();
            }

        }

        [HttpGet]
        public async Task<IActionResult> TelefonDuzenle(int telefonId)
        {
            ViewBag.TelMarkalar = await _context.TelMarkalar.ToListAsync();
            ViewBag.Depolamalar = await _context.Depolamalar.ToListAsync();
            ViewBag.Ramler = await _context.Ramler.ToListAsync();
            ViewBag.Bataryalar = await _context.Bataryalar.ToListAsync();
            ViewBag.Hatlar = await _context.Hatlar.ToListAsync();
            ViewBag.HizliSarjlar = await _context.HizliSarjlar.ToListAsync();
            ViewBag.Compability5Gler = await _context.Compability5Gler.ToListAsync();
            ViewBag.Sular = await _context.Sular.ToListAsync();
            ViewBag.SuSertifikalar = await _context.SuSertifikalar.ToListAsync();
            ViewBag.CpuHzler = await _context.CpuHzler.ToListAsync();
            ViewBag.KameraCozler = await _context.KameraCozler.ToListAsync();
            ViewBag.EkranCozler = await _context.EkranCozler.ToListAsync();
            ViewBag.ParmakIzler = await _context.ParmakIzler.ToListAsync();

            var telefon = _context.Telefonlar.Find(telefonId);

            if (telefon == null)
            {
                return NotFound();
            }
            else
            {
                var getTelefonlar = _context.Telefonlar
                .Include(p => p.TelMarka)
                .Include(p => p.Depolama)
                .Include(p => p.Ram)
                .Include(p => p.Batarya)
                .Include(p => p.Hat)
                .Include(p => p.HizliSarj)
                .Include(p => p.Compability5G)
                .Include(p => p.Su)
                .Include(p => p.SuSertifika)
                .Include(p => p.CpuHz)
                .Include(p => p.KameraCoz)
                .Include(p => p.EkranCoz)
                .Include(p => p.ParmakIzi)
                .AsQueryable();

                return View(telefon);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TelefonDuzenle(Telefon telefon)
        {
            try
            {
                _context.Telefonlar.Update(telefon);
                await _context.SaveChangesAsync();
                return RedirectToAction("Telefonlar");
            }
            catch (Exception ex)
            {
                ViewBag.TelMarkalar = await _context.TelMarkalar.ToListAsync();
                ViewBag.Depolamalar = await _context.Depolamalar.ToListAsync();
                ViewBag.Ramler = await _context.Ramler.ToListAsync();
                ViewBag.Bataryalar = await _context.Bataryalar.ToListAsync();
                ViewBag.Hatlar = await _context.Hatlar.ToListAsync();
                ViewBag.HizliSarjlar = await _context.HizliSarjlar.ToListAsync();
                ViewBag.Compability5Gler = await _context.Compability5Gler.ToListAsync();
                ViewBag.Sular = await _context.Sular.ToListAsync();
                ViewBag.SuSertifikalar = await _context.SuSertifikalar.ToListAsync();
                ViewBag.CpuHzler = await _context.CpuHzler.ToListAsync();
                ViewBag.KameraCozler = await _context.KameraCozler.ToListAsync();
                ViewBag.EkranCozler = await _context.EkranCozler.ToListAsync();
                ViewBag.ParmakIzler = await _context.ParmakIzler.ToListAsync();

                return View();
            }
        }

        public async Task<IActionResult> TelefonSil(int telefonId)
        {
            var telefon = _context.Telefonlar.Find(telefonId);

            if (telefon == null)
            {
                return NotFound();
            }
            else
            {
                _context.Telefonlar.Remove(telefon);
                await _context.SaveChangesAsync();
                return RedirectToAction("Telefonlar");
            }
        }

        [HttpGet]
        public async Task<IActionResult> KulaklikEkle()
        {
            var getKulakliklar = _context.Kulakliklar
                .Include(k => k.SesCikis)
                .Include(k => k.BaglantiTip)
                .Include(k => k.Bluetooth)
                .Include(k => k.BtStandart)
                .Include(k => k.Mikrofon)
                .AsQueryable();

            var kulakliklar = await getKulakliklar.ToListAsync();

            ViewBag.SesCikislar = _context.SesCikislar.ToList();
            ViewBag.BaglantiTipler = _context.BaglantiTipler.ToList();
            ViewBag.Bluetoothlar = _context.Bluetoothlar.ToList();
            ViewBag.BtStandartlar = _context.BtStandartlar.ToList();
            ViewBag.Mikrofonlar = _context.Mikrofonlar.ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KulaklikEkle(Kulaklik kulaklik)
        {
            try
            {
                _context.Kulakliklar.Add(kulaklik);

                await _context.SaveChangesAsync();

                return RedirectToAction("Kulakliklar");
            }
            catch (Exception ex)
            {
                ViewBag.SesCikislar = _context.SesCikislar.ToList();
                ViewBag.BaglantiTipler = _context.BaglantiTipler.ToList();
                ViewBag.Bluetoothlar = _context.Bluetoothlar.ToList();
                ViewBag.BtStandartlar = _context.BtStandartlar.ToList();
                ViewBag.Mikrofonlar = _context.Mikrofonlar.ToList();

                return View();
            }

        }

        [HttpGet]
        public async Task<IActionResult> KulaklikDuzenle(int kulaklikId)
        {
            ViewBag.SesCikislar = _context.SesCikislar.ToList();
            ViewBag.BaglantiTipler = _context.BaglantiTipler.ToList();
            ViewBag.Bluetoothlar = _context.Bluetoothlar.ToList();
            ViewBag.BtStandartlar = _context.BtStandartlar.ToList();
            ViewBag.Mikrofonlar = _context.Mikrofonlar.ToList();

            var kulaklik = _context.Kulakliklar.Find(kulaklikId);

            if (kulaklik == null)
            {
                return NotFound();
            }
            else
            {
                var getKulakliklar = _context.Kulakliklar
                .Include(k => k.SesCikis)
                .Include(k => k.BaglantiTip)
                .Include(k => k.Bluetooth)
                .Include(k => k.BtStandart)
                .Include(k => k.Mikrofon)
                .AsQueryable();

                return View(kulaklik);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KulaklikDuzenle(Kulaklik kulaklik)
        {
            try
            {
                _context.Kulakliklar.Update(kulaklik);
                await _context.SaveChangesAsync();
                return RedirectToAction("Kulakliklar");
            }
            catch (Exception ex)
            {
                ViewBag.SesCikislar = _context.SesCikislar.ToList();
                ViewBag.BaglantiTipler = _context.BaglantiTipler.ToList();
                ViewBag.Bluetoothlar = _context.Bluetoothlar.ToList();
                ViewBag.BtStandartlar = _context.BtStandartlar.ToList();
                ViewBag.Mikrofonlar = _context.Mikrofonlar.ToList();

                return View();
            }
        }

        public async Task<IActionResult> KulaklikSil(int kulaklikId)
        {
            var kulaklik = _context.Kulakliklar.Find(kulaklikId);

            if (kulaklik == null)
            {
                return NotFound();
            }
            else
            {
                _context.Kulakliklar.Remove(kulaklik);
                await _context.SaveChangesAsync();
                return RedirectToAction("Kulakliklar");
            }
        }
    }
}
