using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactData
    {
        private string firstname;
        private string lastname;
        private string mobile;

        public ContactData(string firstname, string lastname, string mobile)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.mobile = mobile;
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public string Mobile 
        {
            get 
            { 
                return mobile; 
            }

            set 
            { 
                mobile = value;
            }
        }
    }
}
