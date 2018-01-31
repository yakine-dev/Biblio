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
            var db = new ApplicationDbContext();

            var clients = db.Clients.Include("Plan").ToList();
            
            return View(clients);
        }

        public ActionResult Detail(int id)
        {
            var db = new ApplicationDbContext();

            var client = db.Clients.Include("Plan").SingleOrDefault(c => c.Id == id);
            if (client==null)
            {
                return HttpNotFound();
            }

            return View(client);
        }
    }
}