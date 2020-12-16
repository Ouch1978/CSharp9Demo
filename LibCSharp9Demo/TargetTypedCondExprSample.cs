using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibCSharp9Demo.Models;

namespace LibCSharp9Demo
{
    public class TargetTypedCondExprSample
    {
        public IVehicle BuildVehicleWithNullCoalescing( IVehicle vehicle)
        {
            return vehicle ?? new Uber(); //在 C# 9.0 之前會錯，現在可以這樣寫了。
        }

        public IVehicle BuildVehicleWithTernary( bool isReal )
        {
            return isReal ? new Uber() : null; //在 C# 9.0 之前會錯，現在可以這樣寫了。
        }

        public void AnotherSample()
        {
            int? x = new Random().NextDouble() > 0.5 ? 1 : null;

            IEnumerable<int> _ = x is null ? null : new int[] { 2 , 3 };
        }
    }
}
