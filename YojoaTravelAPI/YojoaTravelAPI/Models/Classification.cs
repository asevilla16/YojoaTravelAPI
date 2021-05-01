using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YojoaTravelAPI.Models
{
    public class Classification
    {
        [Key]
        public int ClassificationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
