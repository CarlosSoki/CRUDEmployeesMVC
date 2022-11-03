using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUDEmployeesMVC;


namespace CRUDEmployeesMVC.Controllers
{
    public class tabla_EmpleadosController : Controller
    {
        private CRUDDBEntities db = new CRUDDBEntities();

        // GET: tabla_Empleados
        public ActionResult Index()
        {
            return View(db.tabla_Empleados.ToList());
        }

        // GET: tabla_Empleados/Details/
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tabla_Empleados tabla_Empleados = db.tabla_Empleados.Find(id);
            if (tabla_Empleados == null)
            {
                return HttpNotFound();
            }
            return View(tabla_Empleados);
        }

        // GET: tabla_Empleados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tabla_Empleados/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombres,Apellidos,CI,Fecha_Nacimiento,Edad,Rol,Salario")] tabla_Empleados tabla_Empleados)
        {
            if (ModelState.IsValid)
            {
                db.tabla_Empleados.Add(tabla_Empleados);
                db.SaveChanges();
                ViewBag.NameLastName = String.Concat(tabla_Empleados.Nombres, " ", tabla_Empleados.Apellidos);
                Response.Write("<script>alert('El Empleado " + ViewBag.NameLastName + " ha sido CREADO con éxito!'); window.location.pathname = '';</script>");

            }

            return View(tabla_Empleados);
        }

        // GET: tabla_Empleados/Edit/
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tabla_Empleados tabla_Empleados = db.tabla_Empleados.Find(id);
            if (tabla_Empleados == null)
            {
                return HttpNotFound();
            }
            return View(tabla_Empleados);
        }

        // POST: tabla_Empleados/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombres,Apellidos,CI,Fecha_Nacimiento,Edad,Rol,Salario")] tabla_Empleados tabla_Empleados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tabla_Empleados).State = EntityState.Modified;
                db.SaveChanges();
                ViewBag.NameLastName = String.Concat(tabla_Empleados.Nombres, " ", tabla_Empleados.Apellidos);
                Response.Write("<script>alert('El Empleado " + ViewBag.NameLastName + " ha sido EDITADO con éxito!'); window.location.pathname = '';</script>");

            }
            return View(tabla_Empleados);
        }

        // GET: tabla_Empleados/Delete/
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tabla_Empleados tabla_Empleados = db.tabla_Empleados.Find(id);
            if (tabla_Empleados == null)
            {
                return HttpNotFound();
            }
            return View(tabla_Empleados);
        }

        // POST: tabla_Empleados/Delete/
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tabla_Empleados tabla_Empleados = db.tabla_Empleados.Find(id);
            db.tabla_Empleados.Remove(tabla_Empleados);
            db.SaveChanges();
            db.SaveChanges();
            ViewBag.NameLastName = String.Concat(tabla_Empleados.Nombres, " ", tabla_Empleados.Apellidos);
            Response.Write("<script>alert('El Empleado " + ViewBag.NameLastName + " ha sido ELIMINADO con éxito!'); window.location.pathname = '';</script>");

            return null;
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
