using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PETUtility.Data.Context;
using PETUtility.Data.Fundamentals.Models;
using PETUtility.Service.Services;
using PETUtility.Data.Fundamentals.Filters;
using System.Web.Helpers;

namespace PETUtility.Web.Controllers
{
    public class PETianoController : Controller
    {
        public IPETianoService _PETianoService;

        public PETianoController(IPETianoService petianoService)
        {
            _PETianoService = petianoService;
        }

        public ActionResult Index()
        {
            List<PETiano> petianos = _PETianoService.GetPETianos();

            return View(petianos);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PETiano petiano)
        {
            petiano.Password = Crypto.HashPassword(petiano.Password);
            _PETianoService.CreatePETiano(petiano);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            PETianoFilter petianoFilter = new PETianoFilter()
            {
                Id = id
            };

            PETiano petiano = _PETianoService.GetPETiano(petianoFilter);
            petiano.Password = Crypto.Hash(petiano.Password);

            if (petiano == null)
                return View();

            return View(petiano);
        }

        [HttpPost]
        public ActionResult Edit(PETiano petiano)
        {
            petiano.Password = Crypto.HashPassword(petiano.Password);
            _PETianoService.EditPETiano(petiano);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            PETianoFilter petianoFilter = new PETianoFilter()
            {
                Id = id
            };

            PETiano petiano = _PETianoService.GetPETiano(petianoFilter);

            if (petiano != null)
                return View(petiano);
            else
                return View();
        }

        [HttpPost]
        public ActionResult Delete(PETiano petiano)
        {
            _PETianoService.DeletePETiano(petiano);

            return RedirectToAction("Index");
        }
    }
}
