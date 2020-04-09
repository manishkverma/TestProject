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
                    _customerRegistration.Add(new Customer { FirstName = "Manish", LastName = "Verma", Age = 30, ShoppingCategory = "Dairy", RegistrationNumber = 1 });
                    _customerRegistration.Add(new Customer { FirstName = "Mitansh", LastName = "Verma", Age = 7, ShoppingCategory = "Cookies", RegistrationNumber = 2 });
                    _customerRegistration.Add(new Customer { FirstName = "Abhishek", LastName = "Verma", Age = 32, ShoppingCategory = "Frozen", RegistrationNumber = 3 });
                    _customerRegistration.Add(new Customer { FirstName = "Pratham", LastName = "Verma", Age = 16, ShoppingCategory = "Fresh Vegetable", RegistrationNumber = 4 });
                }
                
                return _customerRegistration;
            }
            else
            {
                return _customerRegistration;
            }
        }

        //This method is to add Customer in collection
        public string Add(Customer customer)
        {
            string sResultStatus = string.Empty;
            try
            {
                lCustomerList.Add(customer);
                return sResultStatus = "Customer Added successfully";
            }
            catch (Exception e)
            {
                return sResultStatus = e.Message;
            }
            

        }

        //This method is to find Customer from collection
        public List<Customer> GetCustomer(int iRegistrationNumber)
        {
            return lCustomerList.FindAll(x => x.RegistrationNumber == iRegistrationNumber);// ();
        }

        //This method is to Delete Customer from list of customers based on Registration number
        public string Remove(int registrationNumber)
        {
            string sStatus = "Customer not found";
            for (int iCustomerIndex = 0; iCustomerIndex < lCustomerList.Count; iCustomerIndex++)
            {
                Customer customer = lCustomerList.ElementAt(iCustomerIndex);
                if (customer.RegistrationNumber.Equals(registrationNumber))
                {
                    lCustomerList.RemoveAt(iCustomerIndex);//update the new record
                    sStatus = "Successful removed Customer";
                }
            }
            return sStatus;
        }

        //This method is to Get list of all Customers
        public List<Customer> GetAllCustomer()
        {
            return lCustomerList;
        }

        //This method is to update Customer details based on Registration number
        public void UpdateCustomer(int iRegistrationNumber, string sShoppingCategory)
        {
            for (int iCustomerIndex = 0; iCustomerIndex < lCustomerList.Count; iCustomerIndex++)
            {
                Customer oCustomer = lCustomerList.ElementAt(iCustomerIndex);
                if (oCustomer.RegistrationNumber.Equals(iRegistrationNumber))
                {
                    oCustomer.ShoppingCategory = sShoppingCategory;
                }
            }
            
        }


    }
}