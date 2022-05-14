using project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_1.Repositories
{
    public interface ISobytiyeRepository
    {
        //методы получающий события по запросу
        public IEnumerable<Sobytiye> GetAll();
        public Sobytiye Get(int id);
        public void Update(SobytiyeViewModel sobytiye);
        public void Add(SobytiyeViewModel sobytiye);
        public void Delete(int id);
    }
}
