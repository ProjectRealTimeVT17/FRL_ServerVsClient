using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ClientVsServer.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}