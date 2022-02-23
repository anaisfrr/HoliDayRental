using HoliDayRental.BLL.Entities;
using HoliDayRental.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using HoliDayRental.DAL.Entities;
using OptionsBien = HoliDayRental.DAL.Entities.OptionsBien;

namespace HoliDayRental.BLL.Services
{
    public class OptionsBienService : IOptionsBienRepository<OptionsBien>
    {
        private readonly IOptionsBienRepository<DAL.Entities.OptionsBien> _optionsBienRepository;

        public OptionsBienService(IOptionsBienRepository<DAL.Entities.OptionsBien> repository)
        {
            _optionsBienRepository = repository;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OptionsBien Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OptionsBien> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OptionsBien> GetByBienEchange(int idBien)
        {
            throw new NotImplementedException();
        }

        public int Insert(OptionsBien entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, OptionsBien entity)
        {
            throw new NotImplementedException();
        }
    }
}
