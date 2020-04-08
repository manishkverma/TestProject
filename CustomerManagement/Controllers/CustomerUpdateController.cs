using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomerManagement.Models;

namespace CustomerManagement.Controllers
{
    public class CustomerUpdateController : ApiController
    {
        //Update customer details using PUT method
        public String PutCustomerRecord(Customer customer)
        {
            Console.WriteLine("Customer details are updating...");
            return CustomerRegistration.GetInstance().UpdateCustomer(customer);
        }
    }
}
