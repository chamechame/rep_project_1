using project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_1.Repositories
{
    public class CompanyRepository: ICompanyRepository
    {
        private readonly SobytiyeContext _context;
        public CompanyRepository(SobytiyeContext context)
        {
            _context = context;
        }
        public IEnumerable<Company> GetAll()
        {
            return _context.Company.AsEnumerable();
        }

        public void Add(Company company)
        {
            _context.Company.Add(company);
            _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var company = _context.Company.Find(id);
            if (company != null)
            {
                _context.Company.Remove(company);
                _context.SaveChangesAsync();
            }
        }

        public Company Get(int id)
        {
            var company = _context.Company.Find(id);
            return company;
        }

        public Company Update(Company company)
        {
            var oldCompany = _context.Company.Find(company.Id);
            oldCompany = company;
            _context.SaveChangesAsync();
            return oldCompany;
        }
    }
}
