using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartinPosso_Authentication.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}