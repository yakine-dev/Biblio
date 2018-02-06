using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblio.Models
{
    public class Client
    {
        public int Id { get; set; }

        [DisplayName("Nom Client")]
        [Required]
        public string Nom { get; set; }        

        [DisplayName("Plan")]
        public int PlanId { get; set; }

        public Plan Plan { get; set; }
    }
}