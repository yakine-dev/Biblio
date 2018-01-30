using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biblio.Models;

namespace Biblio.Controllers
{
    public class ClientController : Controller
    {
        // GET: biblio.com/Client/
        // GET: biblio.com/Client/Index
        public ActionResult Index()
        {
            var clients = new List<Client>();
            for (int i = 1; i < 11; i++)
            {
                var client = new Client()
                {
                    Id =i,
                    Nom = "Client "+i,
                    Prenom = "Prenom "+i,
                };
                clients.Add(client);
            }
            return View(clients);
        }
    }
}