using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace CustomerManagement.Models
{
    public class CustomerRegistrationReply
    {
        string sFname, sLname, sShoppingCategory, sRegistrationNumber, sRegistrationStatus = string.Empty;
        private int iAge = 0;

        public string FirstName
        {
            get { return sFname; }
            set { sFname = value; }
        }

        public string LastName
        {
            get { return sLname; }
            set { sLname = value; }
        }

        
        public int Age
        {
            get { return iAge; }
            set { iAge = value; }
        }

        public string ShoppingCategory
        {
            get { return sShoppingCategory; }
            set { sShoppingCategory = value; }
        }

        public string RegistrationNumber
        {
            get { return sRegistrationNumber; }
            set { sRegistrationNumber = value; }
        }
        
        public string RegistrationStatus
        {
            get { return sRegistrationStatus; }
            set { sRegistrationStatus = value; }
        }
    }
}