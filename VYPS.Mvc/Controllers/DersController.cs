using Domain.Repository;
using Domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VYPS.Mvc.Models;

namespace VYPS.Mvc.Controllers
{
    public class DersController:Controller
    {
        IRepository<Ders> repositoryDers = new VYPSRepository<Ders>();
        public ActionResult Index()
        {
            IEnumerable<Ders> dersList = repositoryDers.SelectAll();
            return View(dersList);
        }
        public ActionResult Delete(int id)
        {
            var deleteDers = repositoryDers.SelectSingle(x => x.dkod == id);
            repositoryDers.Delete(deleteDers);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            var updateDers = repositoryDers.SelectSingle(x => x.dkod == id);
            return View(updateDers);
        }
        [HttpPost]
        public RedirectToRouteResult Update(Ders ders)
        {
            repositoryDers.update(0, ders);
            return RedirectToAction("Index");
        }
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult Insert(Ders ders)
        {
            repositoryDers.Add(ders);
            return RedirectToAction("Index");
        }
    }
}