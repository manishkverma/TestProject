using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerManagement.Models
{
    public class CustomerRegistration
    {
        List<Customer> lCustomerList;
        static CustomerRegistration _customerRegistration = null;

        private CustomerRegistration()
        {
            lCustomerList = new List<Customer>();
        }
        
        public static CustomerRegistration GetInstance()
        {
            if (_customerRegistration == null)
            {
                _customerRegistration = new CustomerRegistration();
                if (_customerRegistration.lCustomerList.Count < 1)
                {
                    _customerRegistration.Add(new Customer { FirstName = "Manish", LastName = "Verma", Age = 30, ShoppingCategory = "Dairy", RegistrationNumber = "12345" });
                    _customerRegistration.Add(new Customer { FirstName = "Mitansh", LastName = "Verma", Age = 7, ShoppingCategory = "Cookies", RegistrationNumber = "12346" });
                    _customerRegistration.Add(new Customer { FirstName = "Abhishek", LastName = "Verma", Age = 32, ShoppingCategory = "Frozen", RegistrationNumber = "12347" });
                    _customerRegistration.Add(new Customer { FirstName = "Pratham", LastName = "Verma", Age = 16, ShoppingCategory = "Fresh Vegetable", RegistrationNumber = "12348" });
                }
                
                return _customerRegistration;
            }
            else
            {
                return _customerRegistration;
            }
        }

        //This method is to add Customer in collection
        public void Add(Customer customer)
        {
            lCustomerList.Add(customer);
        }

        //This method is to find Customer from collection
        public List<Customer> GetCustomer(String sRegistrationNumber)
        {
            return lCustomerList.FindAll(x => x.RegistrationNumber == sRegistrationNumber);// ();
        }

        //This method is to Delete Customer from list of customers based on Registration number
        public String Remove(String registrationNumber)
        {
            for (int iCustomerIndex = 0; iCustomerIndex < lCustomerList.Count; iCustomerIndex++)
            {
                Customer customer = lCustomerList.ElementAt(iCustomerIndex);
                if (customer.RegistrationNumber.Equals(registrationNumber))
                {
                    lCustomerList.RemoveAt(iCustomerIndex);//update the new record
                    return "Customer deletion from collection successful";
                }
            }
            return "Delete customer operation is un-successful";
        }

        //This method is to Get list of all Customers
        public List<Customer> GetAllCustomer()
        {
            return lCustomerList;
        }

        //This method is to update Customer details based on Registration number
        public String UpdateCustomer(Customer customer)
        {
            for (int iCustomerIndex = 0; iCustomerIndex < lCustomerList.Count; iCustomerIndex++)
            {
                Customer oCustomer = lCustomerList.ElementAt(iCustomerIndex);
                if (oCustomer.RegistrationNumber.Equals(customer.RegistrationNumber))
                {
                    lCustomerList[iCustomerIndex] = customer;//update the new record
                    return "Update customer data is successful";
                }
            }
            return "Update customer information is un-successful";
        }


    }
}