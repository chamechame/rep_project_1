using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using project_1.Models;
using project_1.Services;
//API слой
namespace project_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SobytiyesController : ControllerBase
    {
        private readonly ISobytiyeManager sobytiyeManager;
        public SobytiyesController(ISobytiyeManager sobytiyeManager)
        {
            this.sobytiyeManager = sobytiyeManager;
        }
        // GET: api/sobytiyes
        [HttpGet]
        public Task<IEnumerable<Sobytiye>> GetSobytiye()
        {
            return Task.FromResult(sobytiyeManager.GetAll());
        }
        // GET: api/Sobytiyes/5
        [HttpGet("{id}")]
        public  Task<Sobytiye> GetSobytiye(int id)
        {
            var sobytiye = sobytiyeManager.Get(id);
            //защита от ошибки, так как вводить нужно только цифру из списка
            //var test1 = int.TryParse(sobytiye.Category, out var x);
            //var test2 = int.TryParse(sobytiye.Location, out var y);
            //if (test1 && test2)
            //{
            //    sobytiye.Category = ((Category)x).ToString();
            //    sobytiye.Location = ((Location)y).ToString();
            //}
            return Task.FromResult(sobytiye);
        }
        // GET: api/Category
        [HttpGet("Category")]
        public List<String> GetCategory()
        {
            return Enum.GetNames(typeof(Category)).ToList();
        }
        // GET: api/Location
        [HttpGet("Location")]
        public List<String> GetLocation()
        {
            return Enum.GetNames(typeof(Location)).ToList();
        }
        // POST: api/sobytiyes
        [HttpPost("sobytiye")]
        public void PostSobytiye(SobytiyeViewModel Sobytiye)
        {
           sobytiyeManager.Add(Sobytiye);
        }
        // PUT: api/sobytiyes/5
        [HttpPut("")]
        public void PutSobytiye(SobytiyeViewModel sobytiye)
        {
            sobytiyeManager.Update(sobytiye);
        }
        // DELETE: api/Sobytiyes/5
        [HttpDelete("sobytiye/{id}")]
        public void DeleteSobytiye(int id)
        {
            sobytiyeManager.Delete(id);
        }
    }
}
