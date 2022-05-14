using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project_1.Models;
using project_1.Services;

//namespace project_1.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CompanyController : ControllerBase
//    {
//        private readonly ICompanyManager companyManager;
//        public CompanyController(ICompanyManager companyManager)
//        {
//            this.companyManager = companyManager;
//        }
//        // GET: api/Company
//        [HttpGet]
//        public Task<IEnumerable<Company>> GetCompany()
//        {
//            return Task.FromResult(companyManager.GetAll());
//        }
//        // GET: api/Company/5
//        [HttpGet("{id}")]
//        public Task<Company> GetCompany(int id)
//        {
//            var company = companyManager.Get(id);
//            return Task.FromResult(company);
//        }
//        // POST: api/Company
//        [HttpPost("company")]
//        public void PostCompany(Company company)
//        {
//            companyManager.Add(company);
//        }
//        // PUT: api/Company/5
//        [HttpPut("{id}")]
//        public void PutCompany(int id, Company company)
//        {
//            company.Id = id;
//            companyManager.Update(company);
//        }
//        // DELETE: api/Company/5
//        [HttpDelete("company/{id}")]
//        public void DeleteCompany(int id, Company company)
//        {
//            company.Id = id;
//            companyManager.Delete(id);
//        }

//    }
//}
