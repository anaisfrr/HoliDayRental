﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.DAL.Entities
{
    public class OptionsBien
    {
        public int idOption { get; set; }
        public int idBien { get; set; }
        public string Valeur { get; set; }
    }
}
