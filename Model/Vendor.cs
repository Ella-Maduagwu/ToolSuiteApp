using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolsuiteapp.Model
{

    public class Vendor
    {
        public string VendorName { get; set; }
        public string? CategoryName { get; set; }

        public Vendor(string vendorName, string? categoryName)
        {
            VendorName = vendorName;
            CategoryName = categoryName;
        }
    }
}