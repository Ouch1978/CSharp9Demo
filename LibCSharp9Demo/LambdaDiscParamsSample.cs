using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCSharp9Demo
{
    public class LambdaDiscParamsSample
    {
        //兩個參數都不使用
        Func<int , int , int> myNumber = ( _ , _ ) => 27;
        
        //只使用第一和第三個參數
        Func<int , int , int , int , int> firstPlusThird = ( x , _ , y , _ ) => x + y;
        
        //_會被當成參數名稱
        Func<int , int> doubleNumber = ( _ ) => _ * 2;
    }
}
