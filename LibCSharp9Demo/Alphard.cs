using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCSharp9Demo
{
    public class Alphard : ICar
    {
        public string Brand { get; init; }
        public string TypeName { get; init; }
        public int Year { get; init; }
        public string Color { get; set; }
    }
}
