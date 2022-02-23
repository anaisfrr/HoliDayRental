using HoliDayRental.BLL.Entities;
using HoliDayRental.BLL.Handlers;
using HoliDayRental.Common.Repositories;
using HoliDayRental.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Membre = HoliDayRental.DAL.Entities.Membre;

namespace HoliDayRental.BLL.Services
{
    public class MembreService : IMembreRepository<BLL.Entities.Membre>
    {
        private readonly IMembreRepository<DAL.Entities.Membre> _membreRepository;

        public MembreService(IMembreRepository<DAL.Entities.Membre> repository)
        {
            _membreRepository = repository;
        }
        public void Delete(int id)
        {
            _membreRepository.Delete(id);
        }

        public Entities.Membre Get(int id)
        {
            return _membreRepository.Get(id).ToBLL();
        }

        public IEnumerable<Entities.Membre> Get()
        {
            return _membreRepository.Get().Select(c => c.ToBLL());
        }

        public IEnumerable<Entities.Membre> GetByBienEchange(int idBien)
        {
            return _membreRepository.GetByBienEchange(idBien).Select(c => c.ToBLL());
        }

        public int Insert(Entities.Membre entity)
        {
            return _membreRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, Entities.Membre entity)
        {
            _membreRepository.Update(id, entity.ToDAL());
        }
    }
}
