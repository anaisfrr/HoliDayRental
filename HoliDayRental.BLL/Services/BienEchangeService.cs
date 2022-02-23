using HoliDayRental.DAL.Entities;
using HoliDayRental.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using HoliDayRental.Common.Repositories;

namespace HoliDayRental.BLL.Services
{
    public class BienEchangeService : IBienEchangeRepository<BLL.Entities.BienEchange>
    {
        private readonly IBienEchangeRepository<DAL.Entities.BienEchange> _bienEchangeRepository;

        public BienEchangeService(IBienEchangeRepository<DAL.Entities.BienEchange> repository)
        {
            _bienEchangeRepository = repository;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entities.BienEchange Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entities.BienEchange> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entities.BienEchange> GetByMembreId(int membre_id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Entities.BienEchange entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Entities.BienEchange entity)
        {
            throw new NotImplementedException();
        }
    }
}
