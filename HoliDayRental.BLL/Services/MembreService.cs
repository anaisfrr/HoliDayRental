using HoliDayRental.BLL.Entities;
using HoliDayRental.Common.Repositories;
using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoliDayRental.BLL.Services
{
    public class MembreService : IMembreRepository<Membre>
    {
        private readonly IMembreRepository<DAL.Entities.Membre> _membreRepository;

        public MembreService(IMembreRepository<DAL.Entities.Membre> repository)
        {
            _membreRepository = repository;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Membre Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Membre> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Membre> GetByBienEchange(int idBien)
        {
            throw new NotImplementedException();
        }

        public int Insert(Membre entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Membre entity)
        {
            throw new NotImplementedException();
        }
    }
}
