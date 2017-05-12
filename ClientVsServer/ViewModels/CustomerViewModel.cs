using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClientVsServer.Models;

namespace ClientVsServer.ViewModels
{
    public class CustomerViewModel
    {
        public List<Customer> Customers { get; set; }

        public CustomerViewModel()
        {
            Customers = new List<Customer>();
        }
    }
}