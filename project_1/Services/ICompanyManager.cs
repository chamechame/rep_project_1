using project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_1.Services
{
    public interface ICompanyManager
    {
        public IEnumerable<Company> GetAll();
        public Company Get(int id);
        public Company Update(Company company);
        public void Add(Company company);
        public void Delete(int id);
    }
}
