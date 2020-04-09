using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomerManagement.Models;
using Newtonsoft.Json;

namespace CustomerManagement.Controllers
{
    public class CustomerManagementController : ApiController
    {
        // GET: api/CustomerManagement
        public List<Customer> Get()
        {
            return CustomerRegistration.GetInstance().GetAllCustomer();
        }

        // GET: api/CustomerManagement/5
        public string Get(int id)
        {
            return CustomerRegistration.GetInstance().GetCustomer(id)[0].FirstName.ToString();
        }

       
        // POST: api/CustomerManagement
        public string  Post(HttpRequestMessage request)//[FromBody]string value)
        {
            return CustomerRegistration.GetInstance().Add(JsonConvert.DeserializeObject<Customer>(request.Content.ReadAsStringAsync().Result));
        }

        [HttpPut]
        // PUT: api/CustomerManagement/5
        public void Put(int id, HttpRequestMessage request)
        {
            CustomerRegistration.GetInstance().UpdateCustomer(id, JsonConvert.DeserializeObject<Customer>(request.Content.ReadAsStringAsync().Result).ShoppingCategory);
        }

        // DELETE: api/CustomerManagement/5
        public string Delete(int id)
        {
            return CustomerRegistration.GetInstance().Remove(id);
        }
    }
}
