using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.Common.Repositories
{
    public interface IBienEchangeRepository<TBienEchange> : IRepository<TBienEchange,int>
    {
        public IEnumerable<TBienEchange> GetByMembreId(int membre_id);

    }
}
