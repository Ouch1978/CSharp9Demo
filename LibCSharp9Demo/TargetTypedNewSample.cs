using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibCSharp9Demo
{
    public class TargetTypedNewSample
    {

        public void TestTargetTypedNew()
        {
            Member member = new Member( "Ouch" , "Liu" ); //C# 3.0 之前，我們得這樣寫
            var member2 = new Member( "Niqolas" , "Liu" ); //C# 3.0 之後，我們可以這樣寫
            Member member3 = new( "Rex" , "Liu" ); //C# 9.0 之後，我們可以這樣寫

            //C#  9.0之後，還可以這樣寫
            List<Member> members = new()
            {
                new( "Ouch" , "Liu" ) ,
                new( "Niqolas" , "Liu" ) ,
                new( "Rex" , "Liu" )
            };

            //當然，這樣寫也是可以的
            MemoryStream reader = new();
            XmlReader.Create( reader , new() { IgnoreWhitespace = true } );
        }
    }
}
