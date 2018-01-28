using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biblio.Models;

namespace Biblio.Controllers
{
    public class LivreController : Controller
    {
        //GET biblio.com/Livre/Populaire
        public ActionResult Populaire()
        {
            var livre = new Livre() {Titre = "ASP.NET MVC 5", Page = 1500};

            return View(livre);
        }


        
        public ActionResult ParDate(int mois,int annee,string nomLivre)
        {
            return Content(mois + "-"+annee+"-"+nomLivre );
        }

        

    }
}