using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartinPosso_Authentication.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int PersonID { get; set; }
        public virtual Person Person { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}