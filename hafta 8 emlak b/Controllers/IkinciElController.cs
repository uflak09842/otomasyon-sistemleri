using hafta_8_emlak_b.Models.Emlak;
using hafta_8_emlak_b.Models.IkinciEl;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hafta_8_emlak_b.Controllers
{
    public class IkinciElController : Controller
    {

        private readonly Models.AppContext _context;

        public IkinciElController(Models.AppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? ukId,int? dId, int? ilceId, decimal? minFiyat, decimal? maxFiyat)
        {
            ViewBag.UrunKategoriler = _context.UrunKategoriler.ToList();

            ViewBag.UrunDurumlar = _context.UrunDurumlar.ToList();

            ViewBag.Sehirler = _context.Sehirler.ToList();

            var cumle = _context.IkinciEller
                .Include(p => p.UrunKategori)
                .Include(p => p.Ilce)
                    .ThenInclude(ilce => ilce.Sehir)
                .AsQueryable();

            if (ukId.HasValue)
            {
                cumle = cumle.Where(p => p.ukId == ukId.Value);
            }

            if(dId.HasValue)
            {
                cumle = cumle.Where(p => p.durumId == dId.Value);
            }

            if (ilceId.HasValue)
            {
                cumle = cumle.Where(p => p.ilceId == ilceId.Value);
            }

            if (minFiyat.HasValue)
            {
                cumle = cumle.Where(p => p.urunFiyat >= minFiyat.Value);
            }

            if (maxFiyat.HasValue)
            {
                cumle = cumle.Where(p => p.urunFiyat <= maxFiyat.Value);
            }

            var ikinciEller = await cumle.ToListAsync();

            return View(ikinciEller);
        }

        public IActionResult GetIlceler(int Plaka)
        {
            var ilceler = _context.Ilceler.Where(i => i.Plaka == Plaka).ToList();
            return Json(ilceler);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            ViewBag.Kategoriler = _context.UrunKategoriler.ToList();

            ViewBag.UrunDurumlar = _context.UrunDurumlar.ToList();

            ViewBag.Sehirler = _context.Sehirler.ToList();


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ekle(IkinciEl ikinciEl)
        {
            try
            {
                _context.IkinciEller.Add(ikinciEl);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            } catch (Exception ex)
            {
                ViewBag.Kategoriler = _context.UrunKategoriler.ToList();

                ViewBag.UrunDurumlar = _context.UrunDurumlar.ToList();

                ViewBag.Sehirler = _context.Sehirler.ToList();

                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Duzenle(int ikId)
        {
            ViewBag.Kategoriler = _context.UrunKategoriler.ToList();

            ViewBag.UrunDurumlar = _context.UrunDurumlar.ToList();

            ViewBag.Sehirler = _context.Sehirler.ToList();

            var ikinciEl = _context.IkinciEller.Find(ikId);

            if (ikinciEl == null)
            {
                return NotFound();
            }
            else
            {
                var ilce = _context.Ilceler
                    .Include(p => p.Sehir)
                    .FirstOrDefault(p => p.ilceId == ikinciEl.ilceId);

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

                return View(ikinciEl);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Duzenle(IkinciEl ikinciEl)
        {
            try
            {
                _context.IkinciEller.Update(ikinciEl);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Kategoriler = _context.UrunKategoriler.ToList();

                ViewBag.UrunDurumlar = _context.UrunDurumlar.ToList();

                ViewBag.Sehirler = _context.Sehirler.ToList();

                return View();
            }
        }

        public async Task<IActionResult> Sil(int ikId)
        {
            var ikinciEl = _context.IkinciEller.Find(ikId);

            if (ikinciEl == null)
            {
                return NotFound();
            }
            else
            {
                _context.IkinciEller.Remove(ikinciEl);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}
