using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Models
{
    public class BienRegisterForm
    {

        [Required(ErrorMessage = "Le titre est obligatoire.")]
        public string titre { get; set; }

        [Required(ErrorMessage = "Mettez une courte description")]
        public string DescCourte { get; set; }

        [Required(ErrorMessage = "Mettez une description")]
        public string DescLong { get; set; }

        [Required(ErrorMessage = "Ajoutez un nombre de personne")]
        public string NombrePerson { get; set; }

        [Required(ErrorMessage = "Sélectionnez le pays")]
        public string Pays { get; set; }

        [Required(ErrorMessage = "La ville est obligatoire.")]
        public string Ville { get; set; }

        [Required(ErrorMessage = "La rue est obligatoire.")]
        public string Rue { get; set; }

        [Required(ErrorMessage = "Le numero est obligatoire.")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Le code postal est obligatoire.")]
        public string CodePostal { get; set; }

        [Required(ErrorMessage = "La photo est obligatoire.")]
        public string Photo { get; set; }

        public string AssuranceObligatoire { get; set; }
        public string isEnabled { get; set; }
        public string DisabledDate { get; set; }

        [Required(ErrorMessage = "L'emplacement est obligatoire.")]
        public string Latitude { get; set; }

        [Required(ErrorMessage = "L'emplacement est obligatoire.")]
        public string Longitude { get; set; }

        [Required(ErrorMessage = "L'id est obligatoire.")]
        public string idMembre { get; set; }


        [Required(ErrorMessage = "La date est obligatoire.")]
        public string DateCreation { get; set; }


    }
}
