using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_odata_api.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
