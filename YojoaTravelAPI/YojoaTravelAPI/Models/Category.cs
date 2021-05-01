using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YojoaTravelAPI.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ClassificationId { get; set; }
        [ForeignKey("ClassificationId")]
        public Classification Classification { get; set; }

    }
}
