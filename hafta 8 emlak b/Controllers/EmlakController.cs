using hafta_8_emlak_b.Models;
using hafta_8_emlak_b.Models.Emlak;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hafta_8_emlak_b.Controllers
{
    public class EmlakController : Controller
    {
        private readonly Models.AppContext _context;

        public EmlakController(Models.AppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? kategoriId, int? ilceId, decimal? minFiyat, decimal? maxFiyat)
        {
            ViewBag.Kategoriler = _context.Kategoriler.ToList();

            ViewBag.Sehirler = _context.Sehirler.ToList();

            var cumle = _context.Emlaklar
                .Include(p => p.Kategori)
                .Include(p => p.Ilce)
                    .ThenInclude(ilce => ilce.Sehir)
                .AsQueryable();

            if (kategoriId.HasValue)
            {
                cumle = cumle.Where(p => p.KatId == kategoriId.Value);
            }

            if (ilceId.HasValue)
            {
                cumle = cumle.Where(p => p.ilceId == ilceId.Value);
            }

            if (minFiyat.HasValue)
            {
                cumle = cumle.Where(p => p.Fiyat >= minFiyat.Value);
            }

            if (maxFiyat.HasValue)
            {
                cumle = cumle.Where(p => p.Fiyat <= maxFiyat.Value);
            }

            var emlaklar = await cumle.ToListAsync();

            return View(emlaklar);
        }

        public IActionResult GetIlceler(int Plaka)
        {
            var ilceler = _context.Ilceler.Where(i => i.Plaka == Plaka).ToList();
            return Json(ilceler);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            ViewBag.Kategoriler = _context.Kategoriler.ToList();

            ViewBag.Sehirler = _context.Sehirler.ToList();


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle(Emlak emlak)
        {
            try
            {
                _context.Emlaklar.Add(emlak);

                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Kategoriler = _context.Kategoriler.ToList();

                ViewBag.Sehirler = _context.Sehirler.ToList();

                return View();
            }

        }

        [HttpGet]
        public async Task<IActionResult> Duzenle(int emlakId)
        {
            ViewBag.Kategoriler = _context.Kategoriler.ToList();

            ViewBag.Sehirler = _context.Sehirler.ToList();

            var emlak = _context.Emlaklar.Find(emlakId);

            if (emlak == null)
            {
                return NotFound();
            }
            else
            {
                var ilce = _context.Ilceler
                    .Include(p => p.Sehir)
                    .FirstOrDefault(p => p.ilceId == emlak.ilceId);

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

                return View(emlak);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Duzenle(Emlak emlak)
        {
            try
            {
                _context.Emlaklar.Update(emlak);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            } catch (Exception ex)
            {
                ViewBag.Kategoriler = _context.Kategoriler.ToList();

                ViewBag.Sehirler = _context.Sehirler.ToList();

                return View();
            }
        }

        public async Task<IActionResult> Sil(int emlakId)
        {
            var emlak = _context.Emlaklar.Find(emlakId);

            if (emlak == null)
            {
                return NotFound();
            } else
            {
                _context.Emlaklar.Remove(emlak);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}
