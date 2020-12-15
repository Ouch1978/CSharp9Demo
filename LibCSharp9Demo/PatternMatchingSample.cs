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

                Bus b when( ( double ) b.Riders / ( double ) b.Capacity ) < 0.50 => 5 + 2,

                Mrt => 1,

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
    }

    public class Bus
    {
        public double Riders { get; set; }
        public double Capacity { get; set; }
    }

}
