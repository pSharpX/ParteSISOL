using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ParteSISOL.Controllers
{
    public class DenominacionCotroller : Controller
    {
        // GET: DenominacionCotroller
        public ActionResult Index()
        {
            return View();
        }

        // GET: DenominacionCotroller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DenominacionCotroller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DenominacionCotroller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DenominacionCotroller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DenominacionCotroller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DenominacionCotroller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DenominacionCotroller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
