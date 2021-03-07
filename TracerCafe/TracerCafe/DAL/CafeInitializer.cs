using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TracerCafe.Models;

namespace TracerCafe.DAL
{
    public class CafeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CafeContext>
    {
        protected override void Seed(CafeContext context)
        {
            var Customers = new List<Customer>
            {
            new Customer{Title="Loyal",Firstname="Alexander",Surname="Hails",Address1="55-B,WD",Address2="77/SecA, YC", Address3="Null", Address4="Null",PostCode="12345",Telephone="+1 123 2345678",Age=24},
            new Customer{Title="Impulse",Firstname="Miller",Surname="Devidson",Address1="98-C,Br",Address2="98/S-A, YC", Address3="Al-nul Velly, Da", Address4="Null",PostCode="16755",Telephone="+1 142 223178",Age=30},
            new Customer{Title="Need-Base",Firstname="Alexander",Surname="Hails",Address1="55-B,WD",Address2="77/SecA, YC", Address3="Null", Address4="Null",PostCode="12345",Telephone="+1 123 2345678",Age=24},
            };

            Customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
            
        }
    }
}