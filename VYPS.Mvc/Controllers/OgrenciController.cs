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
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        IRepository<Ogrenci> repositoryOgrenci = new VYPSRepository<Ogrenci>();
        public ActionResult Index()
        {
            IEnumerable<Ogrenci> ogrenciList = repositoryOgrenci.SelectAll();
            return View(ogrenciList);
        }

        public ActionResult Delete(int id)
        {
            var deleteOgrenci = repositoryOgrenci.SelectSingle(x => x.no == id);
            repositoryOgrenci.Delete(deleteOgrenci);
            return RedirectToAction("Index");
        }
        
        public ActionResult Update(int id)
        {
            var updateOgrenci = repositoryOgrenci.SelectSingle(x => x.no == id);
            return View(updateOgrenci);
        }
        [HttpPost]
        public RedirectToRouteResult Update(Ogrenci ogr)
        {
            repositoryOgrenci.update(0, ogr);
            return RedirectToAction("Index");
        }
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult Insert(Ogrenci ogr)
        {
            repositoryOgrenci.Add(ogr);
            return RedirectToAction("Index");
        }
    }
}