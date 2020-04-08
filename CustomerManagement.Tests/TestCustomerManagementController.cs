using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerManagement.Models;
using CustomerManagement.Controllers;

namespace CustomerManagement.Tests
{
    
    [TestClass]
    public class TestCustomerManagementController
    {
        //Get all customers details
        [TestMethod]
        public void GetAllCustomers_ShouldReturnAllCustomers()
        {
            var testProducts = GetTestProducts();
            var controller = new CustomerRetrieveController();

            var result = controller.GetAllCustomers() as List<Customer>;
            Assert.AreEqual(testProducts.Count, result.Count);
        }

        //Check for a customer exists or not
        [TestMethod]
        public void AddNewCustomer_ShouldAddAndReturnAllCustomers()
        {
            var testProducts = GetTestProducts();
            var controller = new CustomerRetrieveController();

            var result = controller.GetCustomer("12345") as List<Customer>;
            Assert.AreEqual(testProducts[0].FirstName, result[0].FirstName);
        }
        //Loading default customer data
        private List<Customer> GetTestProducts()
        {
            var testProducts = new List<Customer>();
            testProducts.Add(new Customer { FirstName = "Manish", LastName = "Verma", Age = 30, ShoppingCategory = "Dairy", RegistrationNumber = "12345"});
            testProducts.Add(new Customer { FirstName = "Mitansh", LastName = "Verma", Age = 7, ShoppingCategory = "Cookies", RegistrationNumber = "12346" });
            testProducts.Add(new Customer { FirstName = "Abhishek", LastName = "Verma", Age = 32, ShoppingCategory = "Frozen", RegistrationNumber = "12347" });
            testProducts.Add(new Customer { FirstName = "Pratham", LastName = "Verma", Age = 16, ShoppingCategory = "Fresh Vegetable", RegistrationNumber = "12348" });

            return testProducts;
        }
    }
}
    