using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblio.Models
{
    public class UniqueName :ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var db = new ApplicationDbContext();
            var client = validationContext.ObjectInstance as Client;
            if (client.Id==0)
            {
                if (db.Clients.SingleOrDefault(c=>c.Nom==client.Nom)==null)
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                if (db.Clients.SingleOrDefault(c => c.Id!=client.Id && c.Nom == client.Nom) == null)
                {
                    return ValidationResult.Success;
                }
            }

            return  new ValidationResult("un client avec le meme nom trouvé");

        }
    }
}