using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCSharp9Demo
{
    public record Member
    {
        public string LastName { get; }
        public string FirstName { get; }

        public Member( string first , string last ) => (FirstName, LastName) = (first, last);
    }
}
