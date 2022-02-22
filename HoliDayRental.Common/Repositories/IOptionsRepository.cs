using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.Common.Repositories
{
    public interface IOptionsRepository<TOptions> : IRepository<TOptions, int>
    {
        public IEnumerable<TOptions> GetByBienEchange(int idBien);
    }
}