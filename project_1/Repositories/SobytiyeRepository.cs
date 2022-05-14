using Microsoft.EntityFrameworkCore;
using project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_1.Repositories
{
    public class SobytiyeRepository : ISobytiyeRepository
    {
        private readonly SobytiyeContext _context;

        public SobytiyeRepository(SobytiyeContext context)
        {
            _context = context;
        }

        public IEnumerable<Sobytiye> GetAll()
        {
            return _context.Sobytiye.AsEnumerable();
        }

        public void Add(SobytiyeViewModel sobytiye)
        {
            _context.Sobytiye.Add(ToEntity(sobytiye));
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var sobytiye = _context.Sobytiye.Find(id);
            if (sobytiye != null)
            {
                _context.Sobytiye.Remove(sobytiye);
                _context.SaveChanges();
            }
        }
        public Sobytiye Get(int id)
        {
            var sobytiye = _context.Sobytiye.Find(id);
            return sobytiye;
        }
        public void Update(SobytiyeViewModel sobytiye)
        {
            _context.Sobytiye.Update(ToEntity(sobytiye));
            _context.SaveChanges();
           
        }

        private Sobytiye ToEntity(SobytiyeViewModel sobytiyeDTO)
        {
            return new Sobytiye
            {
                Id = sobytiyeDTO.Id,
                Category = sobytiyeDTO.Category,
                Date = sobytiyeDTO.Date,
                Description = sobytiyeDTO.Description,
                Location = sobytiyeDTO.Location,
                Name = sobytiyeDTO.Name
            };
        }
    }
}
