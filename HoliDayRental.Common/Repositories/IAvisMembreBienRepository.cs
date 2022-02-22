using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.Common.Repositories
{
    public interface IAvisMembreBienRepository<TAvisMembreBien> : IRepository<TAvisMembreBien, int>
    {
        public IEnumerable<TAvisMembreBien> GetByMembreId(int membre_id);
    }
}