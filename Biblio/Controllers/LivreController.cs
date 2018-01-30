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

        
        
        public ActionResult Index()
        {
            var livres = new List<Livre>();
            for (int i = 1; i < 11; i++)
            {
                var livre = new Livre()
                {
                    Id =i,
                    Titre = "Livre "+i,
                    Page = i*100,
                };
                livres.Add(livre);
            }

            return View(livres);
        }       


        
        

        

    }
}