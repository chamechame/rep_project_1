using project_1.Models;
using project_1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_1.Services
{
    public class SobytiyeManager : ISobytiyeManager
    {
        public ISobytiyeRepository _sobytiyeRepository;
        public SobytiyeManager(ISobytiyeRepository sobytiyeRepository)
        {
            this._sobytiyeRepository = sobytiyeRepository;
        }
        public IEnumerable<Sobytiye> GetAll()
        {
            return _sobytiyeRepository.GetAll();
        }
        public Sobytiye Get(int id)
        {
            return _sobytiyeRepository.Get(id);
        }
        public void Update(SobytiyeViewModel sobytiye)
        {
            _sobytiyeRepository.Update(sobytiye);
        }
        public void Add(SobytiyeViewModel sobytiye)
        {
            _sobytiyeRepository.Add(sobytiye);
        }
        public void Delete(int id)
        {
            _sobytiyeRepository.Delete(id);
        }
    }
}
