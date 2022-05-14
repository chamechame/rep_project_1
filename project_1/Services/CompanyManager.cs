using project_1.Models;
using project_1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_1.Services
{
    public class CompanyManager : ICompanyManager
    {
        public ICompanyRepository _companyRepository;
        public CompanyManager(ICompanyRepository companyRepository)
        {
            this._companyRepository = companyRepository;
        }
        public IEnumerable<Company> GetAll()
        {
            return _companyRepository.GetAll();
        }
        public Company Get(int id)
        {
            return _companyRepository.Get(id);
        }
        public Company Update(Company sobytiye)
        {
            return _companyRepository.Update(sobytiye);
        }
        public void Add(Company sobytiye)
        {
            _companyRepository.Add(sobytiye);
        }
        public void Delete(int id)
        {
            _companyRepository.Delete(id);
        }

    }


}
