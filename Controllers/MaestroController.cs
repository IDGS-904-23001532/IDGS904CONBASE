using IDGS904CONBASE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904CONBASE.Controllers
{
    public class MaestroController : Controller
    {
        // GET: Maestro
        public ActionResult Index()
        {
            using (var dbAlumno = new MaestroContext())
            {

                return View(dbAlumno.Maestros.ToList());
            }
        }

        // GET: Maestro/Details/5
        public ActionResult Details(int id)
        {

            using (var dbAlumno = new MaestroContext())
            {
                return View(dbAlumno.Maestros.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // GET: Maestro/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Maestro/Create
        [HttpPost]
        public ActionResult Create(Maestro maestro)
        {
            try
            {
                using (var dbMaestro = new MaestroContext())
                {
                    dbMaestro.Maestros.Add(maestro);
                    dbMaestro.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Maestro/Edit/5
        public ActionResult Edit(int id)
        {
            using (var dbMaestro = new MaestroContext())
            {


                return View(dbMaestro.Maestros.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Maestro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Maestro maestro)
        {
            try
            {
                // TODO: Add update logic here
                using (var dbMaestro = new MaestroContext())
                {

                    dbMaestro.Entry(maestro).State = System.Data.Entity.EntityState.Modified;
                    dbMaestro.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Maestro/Delete/5
        public ActionResult Delete(int id)
        {
            using (var dbMaestro = new MaestroContext())
            {


                return View(dbMaestro.Maestros.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Maestro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (var dbMaestro = new MaestroContext())
                {

                    Maestro maes = dbMaestro.Maestros.Where(X => X.id == id).FirstOrDefault();
                    dbMaestro.Maestros.Remove(maes);
                    dbMaestro.SaveChanges();


                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
