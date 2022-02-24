using HoliDayRental.DAL.Entities;
using HoliDayRental.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using HoliDayRental.Common.Repositories;
using HoliDayRental.BLL.Handlers;
using System.Linq;

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
            _bienEchangeRepository.Delete(id);
        }

        public Entities.BienEchange Get(int id)
        {
            return _bienEchangeRepository.Get(id).ToBLL();
        }

        public IEnumerable<Entities.BienEchange> Get()
        {
            return _bienEchangeRepository.Get().Select(c => c.ToBLL());
        }

        public IEnumerable<Entities.BienEchange> GetByMembreId(int membre_id)
        {
            return _bienEchangeRepository.GetByMembreId(membre_id).Select(c => c.ToBLL());
        }

        public int Insert(Entities.BienEchange entity)
        {
            return _bienEchangeRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, Entities.BienEchange entity)
        {
            _bienEchangeRepository.Update(id, entity.ToDAL());
        }
    }
}
