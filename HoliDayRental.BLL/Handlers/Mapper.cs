using System;
using System.Collections.Generic;
using System.Text;
using D = HoliDayRental.DAL.Entities;
using B = HoliDayRental.BLL.Entities;

namespace HoliDayRental.BLL.Handlers
{
    public static class Mapper
    {
        public static B.Membre ToBLL(this D.Membre entity)
        {
            if (entity == null) return null;
            return new B.Membre(
                entity.idMembre,
                entity.Nom,
                entity.Prenom,
                entity.Email,
                entity.Pays,
                entity.Telephone,
                entity.Login,
                entity.Password
                );
        }

        public static D.Membre ToDAL(this B.Membre entity)
        {
            if (entity == null) return null;
            return new D.Membre
            {
                idMembre = entity.idMembre,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                Pays = entity.Pays,
                Telephone = entity.Telephone,
                Login = entity.Login,
                Password = entity.Password
            };
        }
        public static B.BienEchange ToBLL(this D.BienEchange entity)
        {
            if (entity == null) return null;
            return new B.BienEchange(
                entity.idBien,
                entity.titre,
                entity.DescCourte,
                entity.DescLong,
                entity.NombrePerson,
                entity.Pays,
                entity.Ville,
                entity.Rue,
                entity.Numero,
                entity.CodePostal,
                entity.Photo,
                entity.AssuranceObligatoire,
                entity.isEnabled,
                entity.DisabledDate,
                entity.Latitude,
                entity.Longitude,
                entity.idMembre,
                entity.DateCreation
                );
        }


        public static D.BienEchange ToDAL(this B.BienEchange entity)
        {
            if (entity == null) return null;
            return new D.BienEchange
            {
                idBien = entity.idBien,
                titre = entity.titre,
                DescCourte = entity.DescCourte,
                DescLong = entity.DescLong,
                NombrePerson = entity.NombrePerson,
                Pays = entity.Pays,
                Ville = entity.Ville,
                Rue = entity.Rue,
                Numero = entity.Numero,
                CodePostal = entity.CodePostal,
                Photo = entity.Photo,
                AssuranceObligatoire = entity.AssuranceObligatoire,
                isEnabled = entity.isEnabled,
                DisabledDate = entity.DisabledDate,
                Latitude = entity.Latitude,
                Longitude = entity.Longitude,
                idMembre = entity.idMembre,
                DateCreation = entity.DateCreation
            };
        }
        public static B.OptionsBien ToBLL(this D.OptionsBien entity)
        {
            if (entity == null) return null;
            return new B.OptionsBien(
                entity.idOption,
                entity.idBien,
                entity.Valeur
                );
        }

        public static D.OptionsBien ToDAL(this B.OptionsBien entity)
        {
            if (entity == null) return null;
            return new D.OptionsBien
            {
                idOption = entity.idOption,
                idBien = entity.idBien,
                Valeur = entity.Valeur
            };
        }
    }
}
