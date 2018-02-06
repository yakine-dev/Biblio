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

        public ActionResult Add()
        {
            var db = new ApplicationDbContext();
            var viewModel = new ClientFormViewModel()
            {
                Client = new Client(),
                Plans = db.Plans.ToList()
            };

            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Save(Client client)
        {
            var db = new ApplicationDbContext();

            if (db.Clients.SingleOrDefault(c => c.Nom == client.Nom) != null)
            {
                var viewModel = new ClientFormViewModel()
                {
                    Client = new Client(),
                    Plans = db.Plans.ToList()
                };
                return View("Add",viewModel);
            }
            db.Clients.Add(client);
            db.SaveChanges();

            return RedirectToAction("Index");
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