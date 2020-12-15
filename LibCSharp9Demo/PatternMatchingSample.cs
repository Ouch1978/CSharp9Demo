using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace LibCSharp9Demo
{
    public class PatternMatchingSample
    {
        private static bool IsNightTime( DateTime time ) =>
            time.Hour switch
            {
                > 6 and < 23 => true,
                _ => false
            };
    }

    public class FareCalculator
    {
        public int CalculateFare( object vehicle ) =>
            vehicle switch
            {

                Taxi { IsNightTime: true } or Uber { IsNightTime: true } => 70 + 20,
                Uber or Taxi => 70,

                Bus b when( b.Segments > 1 ) => 15 * b.Segments,

                Mrt { IsTransfer: true } => 20 - 8,
                Mrt => 20,

                { } => throw new ArgumentException( message: "Not a known vehicle type" , paramName: nameof( vehicle ) ),

                null => throw new ArgumentNullException( nameof( vehicle ) )
            };
    }

    public class Taxi
    {
        public bool IsNightTime { get; set; }
    }

    public class Uber : Taxi
    {
    }

    public class Mrt
    {
        public bool IsTransfer { get; set; }
    }

    public class Bus
    {
        public bool IsTransfer { get; set; }
        public int Segments { get; set; }
    }

}
