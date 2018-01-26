using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblio.Models
{
    public class Livre
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public int Page { get; set; }
    }
}