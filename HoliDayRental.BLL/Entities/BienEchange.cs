using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.BLL.Entities
{
    public class BienEchange
    {
        public int idBien { get; set; }
        public string titre { get; set; }
        public string DescCourte { get; set; }
        public string DescLong { get; set; }
        public int NombrePerson { get; set; }
        public int Pays { get; set; }
        public string Ville { get; set; }
        public string Rue { get; set; }
        public string Numero { get; set; }
        public string CodePostal { get; set; }
        public string Photo { get; set; }
        public bool AssuranceObligatoire { get; set; }
        public bool isEnabled { get; set; }
        public DateTime? DisabledDate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int idMembre { get; set; }
        public DateTime DateCreation { get; set; }
        public BienEchange(int id, string tit, string descCourte, string descLong, int nombrePerson, int pays, string ville, string numero, string codePostal, string photo, bool assuranceObligatoire, bool Enabled, DateTime disabledDate, string latitude, string longitude, int idMemb, DateTime dateCreation)
        {
            idBien = id;
            titre = tit;
            DescCourte = descCourte;
            DescLong = descLong;
            NombrePerson = nombrePerson;
            Pays = pays;
            Ville = ville;
            Rue = Rue;
            Numero = numero;
            CodePostal = codePostal;
            Photo = photo;
            AssuranceObligatoire = assuranceObligatoire;
            isEnabled = Enabled;
            DisabledDate = disabledDate;
            Latitude = latitude;
            Longitude = longitude;
            idMembre = idMemb;
            DateCreation = dateCreation;
        }
    }
}
