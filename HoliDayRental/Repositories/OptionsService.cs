using HoliDayRental.Common.Repositories;
using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.DAL.Repositories
{
    class OptionsService : ServiceBase, IOptionsRepository<Options>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Options Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Options> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Options> GetByBienEchange(int idBien)
        {
            throw new NotImplementedException();
        }

        public int Insert(Options entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Options entity)
        {
            throw new NotImplementedException();
        }
    }
}
