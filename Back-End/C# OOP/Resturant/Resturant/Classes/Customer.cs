using System.Collections.Generic;
namespace Resturant.Classes
{
    class Customer : Person
    {
        public List<Bill> customerBIlls = new List<Bill>();
        public List<Bill> CustomerBIlls
        {
            get
            {
                return customerBIlls;
            }
        }
        //private string userName;
        //public string UserName
        //{
        //    get
        //    {
        //        return userName;
        //    }
        //    set
        //    {
        //        userName = value; // there is a validation here
        //    }
        //}
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value; // there is a validation here
            }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


    }
}