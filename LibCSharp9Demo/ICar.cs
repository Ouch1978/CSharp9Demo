using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCSharp9Demo
{
    interface ICar
    {
        string Brand { get; init; }
        string TypeName { get; init; }
        int Year { get; init; }
        string Color { get; set; }
    }
}
