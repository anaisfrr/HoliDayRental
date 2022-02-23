using HoliDayRental.BLL.Entities;
using HoliDayRental.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using HoliDayRental.DAL.Entities;
using HoliDayRental.BLL.Handlers;
using System.Linq;
//using AvisMembreBien = HoliDayRental.DAL.Entities.AvisMembreBien;

namespace HoliDayRental.BLL.Services
{
    public class AvisMembreBienService : IAvisMembreBienRepository<BLL.Entities.AvisMembreBien>
    {

        private readonly IBienEchangeRepository<DAL.Entities.AvisMembreBien> _avisMembreBienRepository;

        public AvisMembreBienService(IBienEchangeRepository<DAL.Entities.AvisMembreBien> repository)
        {
            _avisMembreBienRepository = repository;
        }

        public void Delete(int id)
        {
            _avisMembreBienRepository.Delete(id);
        }

        public Entities.AvisMembreBien Get(int id)
        {
            return _avisMembreBienRepository.Get(id).ToBLL();
        }

        public IEnumerable<Entities.AvisMembreBien> Get()
        {
            return _avisMembreBienRepository.Get().Select(c => c.ToBLL());
        }

        public IEnumerable<Entities.AvisMembreBien> GetByMembreId(int membre_id)
        {
            return _avisMembreBienRepository.GetByMembreId(membre_id).Select(c => c.ToBLL());
        }

        public int Insert(Entities.AvisMembreBien entity)
        {
            return _avisMembreBienRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, Entities.AvisMembreBien entity)
        {
            _avisMembreBienRepository.Update(id, entity.ToDAL());
        }
    }
}
