using project_1.Models;
using System.Collections.Generic;

namespace project_1.Services
{
    public interface ISobytiyeManager
    {
        public IEnumerable<Sobytiye> GetAll();
        public Sobytiye Get(int id);
        public void Update(SobytiyeViewModel sobytiye);
        public void Add(SobytiyeViewModel sobytiye);
        public void Delete(int id);
    }
}
