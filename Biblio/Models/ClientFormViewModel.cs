using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblio.Models
{
    public class ClientFormViewModel
    {
        public Client Client { get; set; }
        public List<Plan> Plans { get; set; }


    }
}