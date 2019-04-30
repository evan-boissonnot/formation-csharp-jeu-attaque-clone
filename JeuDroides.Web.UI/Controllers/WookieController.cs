using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JeuDroides.Web.UI.Controllers
{
    public class WookieController : Controller
    {
        #region Public methods
        public IActionResult Index()
        {
            List<string> wookies = new List<string>() {
                "Chewie",
                "Attichitcuk",
                "Bacca",
                "Chak"
            };

            this.ViewBag.ListeWookies = wookies;

            return this.View();
        }
        #endregion
    }
}
