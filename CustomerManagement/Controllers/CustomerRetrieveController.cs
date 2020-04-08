using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CustomerManagement.Models;

namespace CustomerManagement.Controllers
{
    public class CustomerRetrieveController : ApiController
    {
        //GET api/customerretrive
        public List<Customer> GetAllCustomers()
        {
            return CustomerRegistration.GetInstance().GetAllCustomer();
        }


        public List<Customer> GetCustomer(String sRegistrationNumber)
        {
            return CustomerRegistration.GetInstance().GetCustomer(sRegistrationNumber);
        }
    }
}
