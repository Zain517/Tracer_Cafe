using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TracerCafe.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string PostCode { get; set; }
        public string Telephone { get; set; }
        public int Age { get; set; }
    }
}