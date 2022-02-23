using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Models
{
    public class MembreDetails
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idMembre { get; set; }
        [DisplayName("Nom de famille")]
        public string Nom { get; set; }
        [DisplayName("Prénom")]
        public string Prenom { get; set; }
        [DisplayName("Adresse mail")]
        public string Email { get; set; }
        public int Pays { get; set; }
        [DisplayName("Numéro de téléphone")]
        public string Telephone { get; set; }
        public string Login { get; set; }
        [DisplayName("Mot de passe")]
        public string Password { get; set; }
    }
}
