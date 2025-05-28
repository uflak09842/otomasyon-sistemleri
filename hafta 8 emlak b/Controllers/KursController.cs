using hafta_8_emlak_b.Models.Emlak;
using hafta_8_emlak_b.Models.Kurs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hafta_8_emlak_b.Controllers
{
    public class KursController : Controller
    {
        private readonly Models.AppContext _context;

        public KursController(Models.AppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? sinifId, int? ilceId, decimal? minFiyat, decimal? maxFiyat)
        {
            ViewBag.Siniflar = _context.Siniflar.ToList();
            ViewBag.Sehirler = _context.Sehirler.ToList();

            var cumle = _context.Kurslar
                .Include(p => p.Siniflar)
                .Include(p => p.Ilce)
                    .ThenInclude(ilce => ilce.Sehir)
                .AsQueryable();

            if (sinifId.HasValue)
            {
                cumle = cumle.Where(p => p.sinifId == sinifId.Value);
            }

            if (ilceId.HasValue)
            {
                cumle = cumle.Where(p => p.ilceId == ilceId.Value);
            }

            if (minFiyat.HasValue)
            {
                cumle = cumle.Where(p => p.fiyat >= minFiyat.Value);
            }

            if (maxFiyat.HasValue)
            {
                cumle = cumle.Where(p => p.fiyat <= maxFiyat.Value);
            }

            var kurslar = await cumle.ToListAsync();

            return View(kurslar);
        }

        public IActionResult GetIlceler(int Plaka)
        {
            var ilceler = _context.Ilceler.Where(i => i.Plaka == Plaka).ToList();
            return Json(ilceler);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            ViewBag.Siniflar = _context.Siniflar.ToList();
            ViewBag.Sehirler = _context.Sehirler.ToList();


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle(Kurs kurs)
        {
            try
            {
                _context.Kurslar.Add(kurs);

                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Siniflar = _context.Siniflar.ToList();
                ViewBag.Sehirler = _context.Sehirler.ToList();

                return View();
            }

        }

        [HttpGet]
        public async Task<IActionResult> Duzenle(int kursId)
        {
            ViewBag.Siniflar = _context.Siniflar.ToList();

            ViewBag.Sehirler = _context.Sehirler.ToList();

            var kurs = _context.Kurslar.Find(kursId);

            if (kurs == null)
            {
                return NotFound();
            }
            else
            {
                var ilce = _context.Ilceler
                    .Include(p => p.Sehir)
                    .FirstOrDefault(p => p.ilceId == kurs.ilceId);

                var sehir = ilce?.Sehir;

                var seciliSehirId = sehir != null ? sehir.Plaka : 1;

                ViewBag.SeciliSehirAd = sehir != null ? sehir.SehirAdi : string.Empty;
                ViewBag.SeciliSehirId = seciliSehirId;

                ViewBag.SeciliIlceAd = ilce != null ? ilce.ilceAdi : string.Empty;
                ViewBag.SeciliIlceId = ilce != null ? ilce.ilceId : 1;

                var sehirlerList = _context.Sehirler
                    .Where(s => s.Plaka != seciliSehirId)
                    .ToList();
                ViewBag.Sehirler = sehirlerList;

                return View(kurs);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Duzenle(Kurs kurs)
        {
            try
            {
                _context.Kurslar.Update(kurs);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Siniflar = _context.Siniflar.ToList();

                ViewBag.Sehirler = _context.Sehirler.ToList();

                return View();
            }
        }

        public async Task<IActionResult> Sil(int kursId)
        {
            var kurs = _context.Kurslar.Find(kursId);

            if (kurs == null)
            {
                return NotFound();
            }
            else
            {
                _context.Kurslar.Remove(kurs);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}
