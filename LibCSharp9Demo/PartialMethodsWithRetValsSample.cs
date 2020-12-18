using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCSharp9Demo
{
    public class PartialMethodsWithRetValsSample
    {
        partial class MyService
        {
            partial void MyFirstFunction(); //可以，沒存取子的話不用有實作方法
            //private partial void MySecondFunction(); //會錯，有存取子的話得要有實作方法
            private partial object MyThirdFunction(); //可以
            private partial void MyFourthFunction( out int result ); 
        }

        partial class MyService
        {
            private partial object MyThirdFunction() { return new { }; } //可以

            private partial void MyFourthFunction( out int result )
            {
                result = 0;
            }
        }
    }
}
