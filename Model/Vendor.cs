using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolsuiteapp.Model
{
    public record Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Locations { get; set; }
        public DateOnly DateEstablished { get; set; }
        public string ContactNumbers { get; set; }
        public string WebsiteUrl { get; set; }
        public int EmployeeAmount { get; set; }
    }
}
