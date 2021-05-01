using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YojoaTravelAPI.Models
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime InitTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }

    }
}
