using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Assigment.Model.Concrete
{
    internal class User
    {
        public string IdentityNumber { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public User(string identityNumber, string firstName, string lastName)
        {
            IdentityNumber = identityNumber;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
