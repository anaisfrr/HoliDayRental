using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.Common.Repositories
{
    public interface IOptionsBienRepository<TOptionsBien> : IRepository<TOptionsBien, int>
    {
        public IEnumerable<TOptionsBien> GetByBienEchange(int idBien);
    }
}