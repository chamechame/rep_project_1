using Microsoft.EntityFrameworkCore;
using project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_1
{
    public class SobytiyeContext: DbContext
    {
        public SobytiyeContext(DbContextOptions<SobytiyeContext> options) : base(options)
        {

        }
        public DbSet<Sobytiye> Sobytiye { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}
