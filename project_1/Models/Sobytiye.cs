using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace project_1.Models
{
    public class Sobytiye
    {
        [PrimaryKey]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Description { get; set; }
  
        public string Category { get; set; }
        [Required]
        public string Location { get; set; }
    }
}

//[ForeignKey("Company")]
//[Required]
//public int CompanyId { get; set; }
//[Required]