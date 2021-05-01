using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YojoaTravelAPI.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string DNI { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string OriginCity { get; set; }
        public string phoneNumber { get; set; }
        public bool IsFirstVisit { get; set; }
        public bool IsOrganizer { get; set; }

    }
}
