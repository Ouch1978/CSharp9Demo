using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCSharp9Demo
{
    public static class CharExtension
    {
        public static IEnumerator<char> GetEnumerator( this char end )
        {
            int count = ( int ) end - ( int ) 'A';

            return Enumerable.Range( 0 , count ).Select( i => Convert.ToChar( 'A' + i ) ).GetEnumerator();
        }
    }
}
