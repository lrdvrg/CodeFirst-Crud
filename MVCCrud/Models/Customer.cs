using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCCrud.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class  CompanyDBContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}