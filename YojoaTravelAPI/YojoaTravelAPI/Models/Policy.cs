using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YojoaTravelAPI.Models
{
    public class Policy
    {
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public string Description { get; set; }
        public int CancellationDeadlineHours { get; set; }
    }
}
