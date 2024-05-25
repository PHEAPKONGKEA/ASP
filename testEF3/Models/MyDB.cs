using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace testEF3.Models
{
    public class MyDB : DbContext
    {
        public DbSet<Category> category { get; set; }

        public System.Data.Entity.DbSet<testEF3.Models.Client> Clients { get; set; }
    }
}