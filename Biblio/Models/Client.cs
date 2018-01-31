using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblio.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public Plan Plan { get; set; }
        public int PlanId { get; set; }
    }
}