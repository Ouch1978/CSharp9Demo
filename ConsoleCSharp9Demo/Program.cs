using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ConsoleCSharp9Demo
{
    class Program
    {
        public static string Name;

        static void Main( string[] args )
        { System.Console.WriteLine( $"{Name} rocks!!!" ); }

        [ModuleInitializer]
        public static async void Init()
        { Name = await GetName( "Ouch" ); }

        [ModuleInitializer]
        public static async void Init2()
        { Name = await GetName( "Niqolas" ); }

        public static Task<string> GetName( string name ) => Task.FromResult( name );
    }
}