using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.Common.Repositories
{
    public interface IPaysRepository<TPays> : IRepository<TPays, int>
    {
        public IEnumerable<TPays> GetByBienEchange(int idBien);
    }
}

