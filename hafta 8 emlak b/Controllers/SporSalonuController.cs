using hafta_8_emlak_b.Models.Emlak;
using hafta_8_emlak_b.Models.SporSalonu;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hafta_8_emlak_b.Controllers
{
    public class SporSalonuController : Controller
    {
        private readonly Models.AppContext _context;

        public SporSalonuController(Models.AppContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? uyelikId, int? ilceId, int? aktiviteId, int? olanakId, decimal? minFiyat, decimal? maxFiyat)
        {
            ViewBag.UyelikTipler = _context.UyelikTipler.ToList();
            ViewBag.Aktiviteler = _context.Aktiviteler.ToList();
            ViewBag.Olanaklar = _context.Olanaklar.ToList();
            ViewBag.Sehirler = _context.Sehirler.ToList();

            var cumle = _context.SporSalonlar
                .Include(p => p.UyelikTip)
                .Include(p => p.Aktivite)
                .Include(p => p.Olanak)
                .Include(p => p.Ilce)
                    .ThenInclude(ilce => ilce.Sehir)
                .AsQueryable();

            if (uyelikId.HasValue)
            {
                cumle = cumle.Where(p => p.uyelikId == uyelikId.Value);
            }

            if (ilceId.HasValue)
            {
                cumle = cumle.Where(p => p.ilceId == ilceId.Value);
            }

            if(aktiviteId.HasValue)
            {
                cumle = cumle.Where(p => p.aktiviteId == aktiviteId.Value);
            }

            if(olanakId.HasValue)
            {
                cumle = cumle.Where(p => p.olanakId == olanakId.Value);
            }

            if (minFiyat.HasValue)
            {
                cumle = cumle.Where(p => p.fiyat >= minFiyat.Value);
            }

            if (maxFiyat.HasValue)
            {
                cumle = cumle.Where(p => p.fiyat <= maxFiyat.Value);
            }

            var sporSalonlar = await cumle.ToListAsync();

            return View(sporSalonlar);
        }

        public IActionResult GetIlceler(int Plaka)
        {
            var ilceler = _context.Ilceler.Where(i => i.Plaka == Plaka).ToList();
            return Json(ilceler);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            ViewBag.UyelikTipler = _context.UyelikTipler.ToList();
            ViewBag.Aktiviteler = _context.Aktiviteler.ToList();
            ViewBag.Olanaklar = _context.Olanaklar.ToList();
            ViewBag.Sehirler = _context.Sehirler.ToList();


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle(SporSalonu sporSalonu)
        {
            try
            {
                _context.SporSalonlar.Add(sporSalonu);

                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.UyelikTipler = _context.UyelikTipler.ToList();
                ViewBag.Aktiviteler = _context.Aktiviteler.ToList();
                ViewBag.Olanaklar = _context.Olanaklar.ToList();
                ViewBag.Sehirler = _context.Sehirler.ToList();

                return View();
            }

        }

        [HttpGet]
        public async Task<IActionResult> Duzenle(int salonId)
        {
            ViewBag.UyelikTipler = _context.UyelikTipler.ToList();
            ViewBag.Aktiviteler = _context.Aktiviteler.ToList();
            ViewBag.Olanaklar = _context.Olanaklar.ToList();
            ViewBag.Sehirler = _context.Sehirler.ToList();

            var salon = _context.SporSalonlar.Find(salonId);

            if (salon == null)
            {
                return NotFound();
            }
            else
            {
                var ilce = _context.Ilceler
                    .Include(p => p.Sehir)
                    .FirstOrDefault(p => p.ilceId == salon.ilceId);

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

                return View(salon);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Duzenle(SporSalonu salon)
        {
            try
            {
                _context.SporSalonlar.Update(salon);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.UyelikTipler = _context.UyelikTipler.ToList();
                ViewBag.Aktiviteler = _context.Aktiviteler.ToList();
                ViewBag.Olanaklar = _context.Olanaklar.ToList();
                ViewBag.Sehirler = _context.Sehirler.ToList();

                return View();
            }
        }

        public async Task<IActionResult> Sil(int salonId)
        {
            var salon = _context.SporSalonlar.Find(salonId);

            if (salon == null)
            {
                return NotFound();
            }
            else
            {
                _context.SporSalonlar.Remove(salon);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}
