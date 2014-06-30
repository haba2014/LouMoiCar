using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LouMoiCar.Controllers
{
    public class ExempleController : Controller
    {

        //
        // GET: /Exemple/

        public ActionResult Index()
        {
           return View();
        }

        public int test() {
            return 7;
        } 

        //
        // GET: /Exemple/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Exemple/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Exemple/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Exemple/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Exemple/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Exemple/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Exemple/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
