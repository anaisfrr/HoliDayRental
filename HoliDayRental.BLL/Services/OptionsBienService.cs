using HoliDayRental.BLL.Entities;
using HoliDayRental.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using HoliDayRental.DAL.Entities;
//using OptionsBien = HoliDayRental.DAL.Entities.OptionsBien;
using HoliDayRental.BLL.Handlers;
using System.Linq;

namespace HoliDayRental.BLL.Services
{
    public class OptionsBienService : IOptionsBienRepository<BLL.Entities.OptionsBien>
    {
        private readonly IOptionsBienRepository<DAL.Entities.OptionsBien> _optionsBienRepository;

        public OptionsBienService(IOptionsBienRepository<DAL.Entities.OptionsBien> repository)
        {
            _optionsBienRepository = repository;
        }
        public void Delete(int id)
        {
            _optionsBienRepository.Delete(id);
        }

        public Entities.OptionsBien Get(int id)
        {
            return _optionsBienRepository.Get(id).ToBLL();
        }

        public IEnumerable<Entities.OptionsBien> Get()
        {
            return _optionsBienRepository.Get().Select(c => c.ToBLL());
        }

        public IEnumerable<Entities.OptionsBien> GetByBienEchange(int idBien)
        {
            return _optionsBienRepository.GetByBienEchange(idBien).Select(c => c.ToBLL());
        }

        public int Insert(Entities.OptionsBien entity)
        {
            return _optionsBienRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, Entities.OptionsBien entity)
        {
            _optionsBienRepository.Update(id, entity.ToDAL());
        }
    }
}
