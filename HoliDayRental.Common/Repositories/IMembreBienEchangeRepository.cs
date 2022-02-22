using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.Common.Repositories
{
    public interface IMembreBienEchangeRepository<TMembreBienEchange> : IRepository<TMembreBienEchange, int>
    {
        public IEnumerable<TMembreBienEchange> GetByBienEchange(int idBien);
    }
}


