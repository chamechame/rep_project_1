using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project_1.Models
{
    public static class SobytiyeViewModelExtentionsMethods
    {
        public static SobytiyeViewModel ToViewModel(this Sobytiye sobytiye)
        {
            return new SobytiyeViewModel
            { 
                Id = sobytiye.Id,
                Name = sobytiye.Name,
                Date = sobytiye.Date,
                Description = sobytiye.Description,
                Category = sobytiye.Category,
                Location = sobytiye.Location
            };
        }

    }
}
