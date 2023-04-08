using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CinemaManager_Oumaima.Models.Cinema;


namespace CinemaManager_Oumaima.Controllers
{
    public class ProducersController : Controller
    {
        CinemaDBContext ctx;

        public ProducersController(CinemaDBContext context)
        {
            ctx = context;
        }


        // GET: HomeController1
        public ActionResult Index()
        {
            return View(ctx.Producers.ToList());
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            Producer prod = ctx.Producers.Find(id);
            return View(prod);
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Producer p)
        {
            try
            {
                ctx.Producers.Add(p);
                ctx.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            Producer prod = ctx.Producers.Find(id);
            return View(prod);
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Producer p)
        {
            try
            {
                ctx.Producers.Update(p);
                ctx.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            Producer prod = ctx.Producers.Find(id);
            return View(prod);
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Producer p)
        {
            try
            {
                ctx.Producers.Remove(p);
                ctx.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
