using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomerManagement.Models;
using Microsoft.Ajax.Utilities;

namespace CustomerManagement.Controllers
{
    public class CustomerDeleteController : ApiController
    {
        //This method is to Delete customer from collection
        [Route("customer/remove/{customerNum}")]
        public String DeleteStudentRecord(String customerNum)
        {
            Console.WriteLine("Customer deletion is in progress....");
            return CustomerRegistration.GetInstance().Remove(customerNum);
        }
    }
}
