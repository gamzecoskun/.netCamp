using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netCampWeb.Models.Entities;
using netCampWeb.Models.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace netCampWeb.Controllers
{
    public class OgrenciController : Controller
    {
        OgrenciServisi servis;
        public OgrenciController(OgrenciServisi _servis)
        {
            servis = _servis;
        }
       
        public IActionResult List()
        {
            return View(servis.GetList());
        }

        public IActionResult Insert()
        {
            return View(new Ogrenci());
        }

        [HttpPost]
        public IActionResult Insert(Ogrenci model)
        {
            if (!ModelState.IsValid)
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        ViewBag.Error = error.ErrorMessage;
                    }
                }
                return View(model);
            }
            else
            {
                servis.Insert(model);
                model = servis.Insert(model);
            }
            return RedirectToAction("List");  
        }

        //action üzerinde root tanımı yaparken aynı isme sahip diğer actionlarda etkilenir.
        //[Route("/ogrenci-guncelle/{ogrenciId}")]
        public IActionResult Update(long ogrenciId)
        {
            return View(servis.Get(ogrenciId));
        }

        [HttpPost]
        public IActionResult Update(Ogrenci model)
        {
            if (!ModelState.IsValid)
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        ViewBag.Error = error.ErrorMessage;
                    }
                }
                return View(model);
            }
            else
            {
                servis.Update(model);
                model = servis.Update(model);
            }
            return RedirectToAction("List");
        }


        public IActionResult Delete(long id)
        {
            var sonuc = servis.Delete(id);
            return RedirectToAction("List");
        }

       
    }
}
