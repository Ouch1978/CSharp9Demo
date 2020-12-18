using System;

namespace OldConsoleApp
{
    class Program
    {
        static void Main( string[] args )
        {
            [System.Diagnostics.Conditional( "DEBUG" )]
            static void PrintText( string text )
            {
                System.Console.WriteLine( text );
            }

            PrintText( ".NET Core 3.1 也能這樣寫 ^___^" );
        }
    }
}

