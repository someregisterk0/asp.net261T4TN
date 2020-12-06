using System;
using System.Collections.Generic;
using System.Text;

namespace Class_GetSet_Properties
{
    class Employee
    {
        private string fullName;
        private string email;

        // Set method
        public void SetFullName(string fn)
        {
            fullName = fn;
        }

        // Get method
        public string GetFullName()
        {
            return fullName;
        }

        // Properties
        public string Email
        {
            set
            {
                email = value;
            }
            get
            {
                return email;
            }
        }
    }
}
