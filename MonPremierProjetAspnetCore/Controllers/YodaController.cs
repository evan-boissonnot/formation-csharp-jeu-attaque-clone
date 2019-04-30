using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonPremierProjetAspnetCore.Models;

namespace MonPremierProjetAspnetCore.Controllers
{
    public class YodaController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.NombreDeGlaces = 4;
            this.ViewData["NombreDeGlaces"] = 4;



            return View();
        }

        public IActionResult Index2()
        {
            List<string> images = new List<string>() 
            {
                "http://img.over-blog.com/375x500/3/98/73/39/Fonds-d-ecran-Ipad/Deux-parfums-jpg-fond-d-ecran-gratuit-pour-Ipad-2-et-Ipad.jpeg",
                "http://img.over-blog.com/375x500/3/98/73/39/Fonds-d-ecran-Ipad/Deux-parfums-jpg-fond-d-ecran-gratuit-pour-Ipad-2-et-Ipad.jpeg",
                "http://img.over-blog.com/375x500/3/98/73/39/Fonds-d-ecran-Ipad/Deux-parfums-jpg-fond-d-ecran-gratuit-pour-Ipad-2-et-Ipad.jpeg",
                "http://img.over-blog.com/375x500/3/98/73/39/Fonds-d-ecran-Ipad/Deux-parfums-jpg-fond-d-ecran-gratuit-pour-Ipad-2-et-Ipad.jpeg"
            };

            this.ViewBag.ListePhotos = images;


            return View();
        }

        public IActionResult IndexAvecModel()
        {
            List<Glace> listGlaces = new List<Glace>() {
                new Glace() { Url =  "http://img.over-blog.com/375x500/3/98/73/39/Fonds-d-ecran-Ipad/Deux-parfums-jpg-fond-d-ecran-gratuit-pour-Ipad-2-et-Ipad.jpeg" },
                new Glace() { Url =  "http://img.over-blog.com/375x500/3/98/73/39/Fonds-d-ecran-Ipad/Deux-parfums-jpg-fond-d-ecran-gratuit-pour-Ipad-2-et-Ipad.jpeg" },
                new Glace() { Url =  "http://img.over-blog.com/375x500/3/98/73/39/Fonds-d-ecran-Ipad/Deux-parfums-jpg-fond-d-ecran-gratuit-pour-Ipad-2-et-Ipad.jpeg" },
                new Glace() { Url =  "http://img.over-blog.com/375x500/3/98/73/39/Fonds-d-ecran-Ipad/Deux-parfums-jpg-fond-d-ecran-gratuit-pour-Ipad-2-et-Ipad.jpeg" }
            };

            return View(listGlaces);
        }
    }
}
