using System;
using System.Collections.Generic;
using System.Text;

namespace JeuAttaqueDesClones.Models
{
    public class Combat
    {
        #region Properties
        public DateTime Date { get; set; }
        public Wookie LeWookie { get; set; }
        public Clone LeDroide { get; set; }

        public bool WookieGagnant { get; set; } 
        #endregion
    }
}
