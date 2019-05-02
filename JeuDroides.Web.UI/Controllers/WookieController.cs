using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JeuAttaqueDesClones.Models;
using JeuDroides.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace JeuDroides.Web.UI.Controllers
{
    public class WookieController : Controller
    {
        #region Public methods
        public IActionResult Index()
        {
            //Famille maFamille = new Famille() {
            //    Libelle = "Les chewies"
            //};

            //// Simule l'appel à la base de données (sql serveur, ou api)
            //List<Wookie> wookies = new List<Wookie>() {
            //    new Wookie() {
            //        Nom = "DIWILKP",
            //        Prenom = "Chewie",
            //        MaFamille = maFamille,
            //        MesCombats = new List<Combat>() 
            //    },
            //    new Wookie() {
            //        Nom = "DIWILKP",
            //        Prenom = "Chouk",
            //        MaFamille = maFamille,
            //        MesCombats = new List<Combat>()
            //    },
            //    new Wookie() {
            //        Nom = "DIWILKP",
            //        Prenom = "TIFFFF",
            //        MaFamille = maFamille
            //    }
            //};

            //wookies[0].MesCombats.Add(new Combat() {
            //    LeWookie = wookies[0],
            //    LeDroide = new Clone() {  Nom = "Toto" },
            //    Date = DateTime.Now,
            //    WookieGagnant = true
            //});

            //wookies[1].MesCombats.Add(new Combat() {
            //    LeWookie = wookies[1],
            //    LeDroide = new Clone() { Nom = "Toto" },
            //    Date = DateTime.Now
            //});

            //wookies[1].MesCombats.Add(new Combat() {
            //    LeWookie = wookies[1],
            //    LeDroide = new Clone() { Nom = "Gros minet" },
            //    Date = DateTime.Now.AddDays(-30),
            //    WookieGagnant = true
            //});



            return this.View(MaFausseBaseDeDonnees.WookieList);
        }

        public IActionResult Create() => this.View();
        public IActionResult Update(int  id)
        {
            return this.View(MaFausseBaseDeDonnees.WookieList.Single(item => item.Id == id));
        }

        [HttpPost]
        public IActionResult Create(Wookie wookie)
        {

            MaFausseBaseDeDonnees.WookieList.Add(wookie);

            return this.View();
        }

        [HttpPost]
        public IActionResult Update(Wookie wookie)
        {
            Wookie leWookieAMettreAjour = wookie;

            if (ModelState.IsValid)
            {
                var requete = from wook in MaFausseBaseDeDonnees.WookieList
                              where wook.Id == wookie.Id
                              select wook;

                leWookieAMettreAjour = requete.Single();
                leWookieAMettreAjour.Nom = wookie.Nom;
                leWookieAMettreAjour.Prenom = wookie.Prenom;

                // monService sera de type WookieService.
                //monService.Save(wookie);
            }

            return this.View(leWookieAMettreAjour);
        }
        #endregion
    }
}
