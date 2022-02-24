using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.BLL.Entities
{
    public class OptionsBien
    {
        public int idOption { get; set; }
        public int idBien { get; set; }
        public string Valeur { get; set; }
        public OptionsBien(int idOpt, int idB, string valeur)
        {
            idOption = idOpt;
            idBien = idB;
            Valeur = valeur;
        }
    }
}
