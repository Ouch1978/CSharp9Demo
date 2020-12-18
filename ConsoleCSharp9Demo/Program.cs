namespace ConsoleCSharp9Demo
{
    class Program
    {
        static void Main( string[] args )
        {
            static void PrintText( string text )
            {
                System.Console.WriteLine( text );
            }

#if DEBUG
            PrintText("之前大概會這樣寫");
#endif
        }
    }
}