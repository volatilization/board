using Board.Models;
using Board.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Board.Controllers
{
    public class AdvertController : Controller
    {
        AdvertRepository advRepository = new AdvertRepository();

        // GET: Advert
        public ActionResult Index()
        {
            IEnumerable<Advert> adverts = advRepository.GetAll();
            return View(adverts);
        }

        // GET: Advert/Details/5
        public ActionResult Details(int id)
        {
            Advert advert = advRepository.Get(id);
            return View(advert);
        }

        // GET: Advert/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Advert/Create
        [HttpPost]
        public ActionResult Create(Advert advert)
        {
            try
            {
                advRepository.Save(advert);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Advert/Edit/5
        public ActionResult Edit(int id)
        {
            Advert advert = advRepository.Get(id);
            return View(advert);
        }

        // POST: Advert/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Advert advert)
        {
            try
            {
                advRepository.Update(advert);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(advert);
            }
        }

        // GET: Advert/Delete/5
        public ActionResult Delete(int id)
        {
            advRepository.Rremove(id);
            return RedirectToAction("Index");
        }

        // POST: Advert/Delete/5
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
