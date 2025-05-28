using hafta_8_emlak_b.Models.Emlak;
using hafta_8_emlak_b.Models.Otomotiv;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace hafta_8_emlak_b.Controllers
{
    public class OtomotivController : Controller
    {
        private readonly Models.AppContext _context;

        public OtomotivController(Models.AppContext context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index(int? markaId, int? ilceId, int? vitesId, int? yakitId, int? otoMinKm, int? otoMaxKm, int? otoMinYil, int? otoMaxYil, decimal? minFiyat, decimal? maxFiyat)
        {
            ViewBag.Sehirler = _context.Sehirler.ToList();
            ViewBag.Markalar = _context.Markalar.ToList();
            ViewBag.Vitesler = _context.Vitesler.ToList();
            ViewBag.Yakitlar = _context.Yakitlar.ToList();

            var cumle = _context.Otomotivler
                .Include(p => p.Ilce)
                    .ThenInclude(ilce => ilce.Sehir)
                .Include(p => p.Marka)
                .Include(p => p.Vites)
                .Include(p => p.Yakit)
                .AsQueryable();

            if(markaId.HasValue)
            {
                cumle = cumle.Where(p => p.markaId == markaId.Value);
            }

            if(ilceId.HasValue)
            {
                cumle = cumle.Where(p => p.ilceId == ilceId.Value);
            }

            if(vitesId.HasValue)
            {
                cumle = cumle.Where(p => p.vitesId == vitesId.Value);
            }

            if(yakitId.HasValue)
            {
                cumle = cumle.Where(p => p.yakitId == yakitId.Value);
            }

            if(otoMinKm.HasValue)
            {
                cumle = cumle.Where(p => p.otoKm >= otoMinKm.Value);
            }

            if(otoMaxKm.HasValue)
            {
                cumle = cumle.Where(p => p.otoKm <= otoMaxKm.Value);
            }

            if(otoMinYil.HasValue)
            {
                cumle = cumle.Where(p => p.otoYil >= otoMinYil.Value);
            }

            if (otoMaxYil.HasValue)
            {
                cumle = cumle.Where(p => p.otoYil <= otoMaxYil.Value);
            }

            if (minFiyat.HasValue)
            {
                cumle = cumle.Where(p => p.otoFiyat >= minFiyat.Value);
            }

            if(maxFiyat.HasValue)
            {
                cumle = cumle.Where(p => p.otoFiyat <= maxFiyat.Value);
            }

            var otomotivler = await cumle.ToListAsync();

            return View(otomotivler);
        }

        public IActionResult GetIlceler(int Plaka)
        {
            var ilceler = _context.Ilceler.Where(i => i.Plaka == Plaka).ToList();
            return Json(ilceler);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            ViewBag.Sehirler = _context.Sehirler.ToList();
            ViewBag.Markalar = _context.Markalar.ToList();
            ViewBag.Vitesler = _context.Vitesler.ToList();
            ViewBag.Yakitlar = _context.Yakitlar.ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle(Otomotiv otomobil)
        {
            try
            {
                _context.Otomotivler.Add(otomobil);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            } catch (Exception ex)
            {
                ViewBag.Sehirler = _context.Sehirler.ToList();
                ViewBag.Markalar = _context.Markalar.ToList();
                ViewBag.Vitesler = _context.Vitesler.ToList();
                ViewBag.Yakitlar = _context.Yakitlar.ToList();

                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Duzenle(int otoId)
        {
            ViewBag.Sehirler = _context.Sehirler.ToList();
            ViewBag.Markalar = _context.Markalar.ToList();
            ViewBag.Vitesler = _context.Vitesler.ToList();
            ViewBag.Yakitlar = _context.Yakitlar.ToList();

            var otomobil = _context.Otomotivler.Find(otoId);

            if(otomobil == null)
            {
                return NotFound();
            } else
            {
                var ilce = _context.Ilceler
                    .Include(p => p.Sehir)
                    .FirstOrDefault(p => p.ilceId == otomobil.ilceId);

                var sehir = ilce?.Sehir;

                var seciliSehirId = sehir != null ? sehir.Plaka : 1;

                ViewBag.SeciliSehirAd = sehir != null ? sehir.SehirAdi : string.Empty;
                ViewBag.SeciliSehirId = seciliSehirId;

                ViewBag.SeciliIlceAd = ilce != null ? ilce.ilceAdi : string.Empty;
                ViewBag.SeciliIlceId = ilce != null ? ilce.ilceId : 1;

                var sehirlerList = _context.Sehirler
                    .Where(p => p.Plaka != seciliSehirId)
                    .ToList();
                
                ViewBag.Sehirler = sehirlerList;

                return View(otomobil);

            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Duzenle(Otomotiv otomobil)
        {
            try
            {
                _context.Otomotivler.Update(otomobil);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Sehirler = _context.Sehirler.ToList();
                ViewBag.Markalar = _context.Markalar.ToList();
                ViewBag.Vitesler = _context.Vitesler.ToList();
                ViewBag.Yakitlar = _context.Yakitlar.ToList();

                return View();
            }
        }

        public async Task<IActionResult> Sil(int otoid)
        {
            var otomobil = _context.Otomotivler.Find(otoid);

            if (otomobil == null)
            {
                return NotFound();
            }
            else
            {
                _context.Otomotivler.Remove(otomobil);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }

    }
}
