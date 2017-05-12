using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ClientVsServer.Models;
using ClientVsServer.ViewModels;

namespace ClientVsServer.Services
{
    public class AsyncServices
    {
        public static ApplicationDbContext db = new ApplicationDbContext();
        public static async Task<bool> GetCustomer(CustomerViewModel vm )
        {
            vm.Customers = await db.Customers.ToListAsync();
            return true;
        }
    }
}