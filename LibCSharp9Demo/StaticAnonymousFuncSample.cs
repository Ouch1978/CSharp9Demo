using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCSharp9Demo
{
    public class StaticAnonymousFuncSample
    {
        readonly string _message = "{0} 好帥!";

        const string ConstMessage = "{0} 超級帥!!!";


        public void PraiseSomeone( Func<string , string> func )
        {
            var names = new List<string> { "Ouch" , "Nicolas" , "Rex" };

            foreach( var name in names )
            {
                Console.WriteLine( func( name ) );
            }
        }

        public void Praise()
        {
            PraiseSomeone( name => string.Format( _message , name ) ); //_message 變數會不小心的被保存，或是佔用額外的記憶體
        }

        public void PraiseWithStatic()
        {
            PraiseSomeone( static name => string.Format( ConstMessage , name ) ); //ConstMessage 常數並不會被捕捉
        }
    }
}
