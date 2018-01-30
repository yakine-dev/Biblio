using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblio.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public float PrixAnnuel { get; set; }
        public int DureeLocation { get; set; }
        public int LocationSemaineMax { get; set; }
        public List<Client> Clients { get; set; }
    }
}