using IDGS904CONBASE.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904CONBASE.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            using (var dbAlumno = new AlumnoContext()) {

                return View(dbAlumno.Alumnos.ToList());
            }
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int id)
        {
            using (var dbAlumno = new AlumnoContext())
            {
                return View(dbAlumno.Alumnos.Where(x => x.Id == id).FirstOrDefault());
            }
            }

        // GET: Alumnos/Create
        [HttpGet]
        public ActionResult Create()
        {
            
                return View();
            }
        

        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            try
            {
                using (var dbAlumno = new AlumnoContext())
                {
                    dbAlumno.Alumnos.Add(alumno);
                    dbAlumno.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(alumno);
            }
        }


        // GET: Alumnos/Edit/5
        public ActionResult Edit(int id)
        {
            using (var dbAlimno = new AlumnoContext()) {


                return View(dbAlimno.Alumnos.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Alumno alumno)
        {
            try
            {
                // TODO: Add update logic here
                using (var dbAlumnos = new AlumnoContext()) {

                    dbAlumnos.Entry(alumno).State = System.Data.Entity.EntityState.Modified;
                    dbAlumnos.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int id)
        {
            using (var dbAlumno = new AlumnoContext())
            {

                Alumno alum = dbAlumno.Alumnos.Where(X => X.Id == id).FirstOrDefault();
                dbAlumno.Alumnos.Remove(alum);
                dbAlumno.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                using (var dbAlumno = new AlumnoContext()) {

                    Alumno alum = dbAlumno.Alumnos.Where(X => X.Id == id).FirstOrDefault();
                    dbAlumno.Alumnos.Remove(alum);
                    dbAlumno.SaveChanges();
                
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
