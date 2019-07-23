using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppTeachSolu.Backend.Models;
using AppTeachSolu.Common.Models;

namespace AppTeachSolu.Backend.Controllers
{
    public class ProyectsController : Controller
    {
        private LocalDataContext db = new LocalDataContext();

        // GET: Proyects
        public async Task<ActionResult> Index()
        {
            return View(await db.Proyects.ToListAsync());
        }

        // GET: Proyects/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proyect proyect = await db.Proyects.FindAsync(id);
            if (proyect == null)
            {
                return HttpNotFound();
            }
            return View(proyect);
        }

        // GET: Proyects/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proyects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ProyectId,description,IsAvailable,PublishOn")] Proyect proyect)
        {
            if (ModelState.IsValid)
            {
                db.Proyects.Add(proyect);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(proyect);
        }

        // GET: Proyects/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proyect proyect = await db.Proyects.FindAsync(id);
            if (proyect == null)
            {
                return HttpNotFound();
            }
            return View(proyect);
        }

        // POST: Proyects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ProyectId,description,IsAvailable,PublishOn")] Proyect proyect)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proyect).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(proyect);
        }

        // GET: Proyects/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proyect proyect = await db.Proyects.FindAsync(id);
            if (proyect == null)
            {
                return HttpNotFound();
            }
            return View(proyect);
        }

        // POST: Proyects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Proyect proyect = await db.Proyects.FindAsync(id);
            db.Proyects.Remove(proyect);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
