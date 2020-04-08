using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomerManagement.Models;

namespace CustomerManagement.Controllers
{
    public class CustomerRegistrationController : ApiController
    {
        //This method is to register a new customer
        public CustomerRegistrationReply RegisterCustomer(Customer customerRegistration)
        {
            Console.WriteLine("Register New Customer");
            CustomerRegistrationReply customerRegistrationReply = new CustomerRegistrationReply();
            CustomerRegistration.GetInstance().Add(customerRegistration);
            customerRegistrationReply.FirstName = customerRegistration.FirstName;
            customerRegistrationReply.LastName = customerRegistration.LastName;
            customerRegistrationReply.Age = customerRegistration.Age;
            customerRegistrationReply.ShoppingCategory = customerRegistration.ShoppingCategory;
            customerRegistrationReply.RegistrationNumber = customerRegistration.RegistrationNumber;
            customerRegistrationReply.RegistrationStatus = "Successful";
            return customerRegistrationReply;
        }
    }
}
