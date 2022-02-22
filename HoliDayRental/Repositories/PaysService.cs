using HoliDayRental.Common.Repositories;
using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.DAL.Repositories
{
    public class PaysService : ServiceBase, IPaysRepository<Pays>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pays Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pays> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pays> GetByBienEchange(int idBien)
        {
            throw new NotImplementedException();
        }

        public int Insert(Pays entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Pays entity)
        {
            throw new NotImplementedException();
        }
    }
}
