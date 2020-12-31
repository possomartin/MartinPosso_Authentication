using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartinPosso_Authentication.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}