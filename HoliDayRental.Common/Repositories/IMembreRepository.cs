using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.Common.Repositories
{
    public interface IMembreRepository<TMembre> : IRepository<TMembre, int>
    {
        public IEnumerable<TMembre> GetByBienEchange(int idBien);
    }
}


