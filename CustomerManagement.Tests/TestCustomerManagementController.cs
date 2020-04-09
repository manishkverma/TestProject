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
            var controller = new CustomerManagementController();

            var result = controller.Get() as List<Customer>;
            Assert.AreEqual(testProducts.Count, result.Count);
        }

        //Check for a customer First Name exists or not
        [TestMethod]
        public void AddNewCustomer_ShouldReturnCustomerFirstName()
        {
            var testProducts = GetTestProducts();
            var controller = new CustomerManagementController();

            var result = controller.Get(1);
            Assert.AreEqual(testProducts[0].FirstName, result);
        }
        //Loading default customer data
        private List<Customer> GetTestProducts()
        {
            var testProducts = new List<Customer>();
            testProducts.Add(new Customer { FirstName = "Manish", LastName = "Verma", Age = 30, ShoppingCategory = "Dairy", RegistrationNumber = 1});
            testProducts.Add(new Customer { FirstName = "Mitansh", LastName = "Verma", Age = 7, ShoppingCategory = "Cookies", RegistrationNumber = 2 });
            testProducts.Add(new Customer { FirstName = "Abhishek", LastName = "Verma", Age = 32, ShoppingCategory = "Frozen", RegistrationNumber = 3 });
            testProducts.Add(new Customer { FirstName = "Pratham", LastName = "Verma", Age = 16, ShoppingCategory = "Fresh Vegetable", RegistrationNumber = 4 });

            return testProducts;
        }
    }
}
    