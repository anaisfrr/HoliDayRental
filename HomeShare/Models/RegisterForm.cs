using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HoliDayRental.Models
{
    public class RegisterForm
    {
        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [DisplayName("Nom : ")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le prénom est obligatoire.")]
        [DisplayName("Prénom : ")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "L'adresse email est obligatoire.")]
        [DisplayName("Adresse électronique : ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le pays est obligatoire.")]
        [DisplayName("Pays : ")]
        public int Pays { get; set; }

        [Required(ErrorMessage = "Le numéro de téléphone est obligatoire.")]
        [DisplayName("Téléphone : ")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Le login est obligatoire.")]
        [DisplayName("Login : ")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Le mot de passe est obligatoire.")]
        [DisplayName("Mot de passe : ")]
        [RegularExpression(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\S+$).{8,20}$", ErrorMessage = "Le mot de passe doit au minimum un nombre, une minuscule, une majuscule, un caractère parmis '@#$%^&-+=()', aucun espace blanc, compris entre 8 et 20 caractères.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}




// Si notre formulaire contient une liste de checkbox, et que ces dernières ont une valeur : alors chaque valeur cochée seront stocké dans un tableau
//public string[] Checkboxes { get; set; }