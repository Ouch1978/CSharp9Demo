using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCSharp9Demo
{
    public class InitOnlySetterSample
    {
        public void InitOnlySetterSample1()
        {
            Alphard alphard = new Alphard { Brand = "Toyota" , TypeName = "Alphard" , Color = "Red" , Year = 2020 };

            //alphard.TypeName = "BMW"; //錯誤
            alphard.Color = "White";
        }
    }
}
