using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.BLL.Entities
{
    public class AvisMembreBien
    {
        public int idAvis { get; set; }
        public int note { get; set; }
        public string message { get; set; }
        public int idMembre { get; set; }
        public int idBien { get; set; }
        public DateTime DateAvis { get; set; }
        public bool Approuve { get; set; }
        public AvisMembreBien(int idA, int not, string mess, int idMemb, int idB, DateTime date, bool appro)
        {
            idAvis = idA;
            note = not;
            message = mess;
            idMembre = idMemb;
            idBien = idB;
            DateAvis = date;
            Approuve = appro;
        }
    }
}
