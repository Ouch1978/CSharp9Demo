using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCSharp9Demo
{
    public record Member
    {
        public string LastName;
        public string FirstName;

        public Member( string firstName , string lastName ) => (FirstName, LastName) = (firstName, lastName);

        public void Deconstruct( out string firstName , out string lastName )
            => (firstName, lastName) = (FirstName, LastName);
    }
}
