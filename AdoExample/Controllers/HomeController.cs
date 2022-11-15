using AdoExample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
namespace AdoExample.Controllers
{
    public class HomeController : Controller
    {
        testEntities db = new testEntities();
        //private testEntities _dbContext;
        //public HomeController(testEntities context)
        //{
        //    _dbContext = context;
        //}
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet] 
        public async Task<ActionResult> GetTable()
        {
            var autos = await db.Autos.ToListAsync();
            return View(autos);
        }
        [HttpGet]
        public async Task<ActionResult> CreateAuto()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAuto([Bind(Include = "Brand,Color,ProductionYear,Price,BodyType,EngineVolume,CustomsCLeared,Comment")] Auto info)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Autos.Add(info);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }

            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                ModelState.AddModelError("", "Unable to save changes. " + "Try again or call system admin");
            }

            return View(info);
        }
        public async Task<ActionResult> EditAuto(int Id)
        {
            if (Id == null)
            {
                return HttpNotFoundResult();
            }

            var auto = await db.Autos.FirstOrDefaultAsync(m => m.ID == Id);

            if (auto == null)
            {
                return HttpNotFoundResult();
            }

            return View(auto);
        }
        public async Task<ActionResult> DetailsOfAuto(int id)
        {
            if (id == null)
            {
                return HttpNotFoundResult();
            }

            var auto = await db.Autos.FirstOrDefaultAsync(m => m.ID == id);

            if (auto == null)
            {
                return HttpNotFoundResult();
            }

            return View(auto);
        }

        public async Task<ActionResult> DeleteAuto(int id, bool? Savechangeserror = false)
        {
            if (id == null)
            {
                return HttpNotFoundResult();
            }

            var auto = await db.Autos.AsNoTracking().FirstOrDefaultAsync(m => m.ID == id);

            if (auto == null)
            {
                return HttpNotFoundResult();
            }

            if (Savechangeserror.GetValueOrDefault())
            {
                ViewData["DeleteError"] = "Delete failed, please try again later ... ";
            }

            return View(auto);
        }

        private ActionResult HttpNotFoundResult()
        {
            throw new NotImplementedException();
        }

        public ActionResult Sample()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}