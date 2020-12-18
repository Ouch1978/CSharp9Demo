using System;

namespace LibCSharp9Demo
{
    public class NativeIntSample
    {
        public void TestNativeInt()
        {
            nint myNint = 27;
            int myInt = 27;
            nuint myNuint = 27;

            long myLong = 10;

            const nint myConst = int.MaxValue; //可以(myConst=2147483647)

            //const nint myConst2 = nint.MaxValue; //會錯，nint.MaxValue 不是常數

            bool isMyNintAndMyIntEquals = nint.Equals( myNint , myInt ); //False
            bool isMyNintAndCastedIntEquals = nint.Equals( myNint , ( nint ) myInt ); //True

            Type typeOfNint = typeof( nint ); //System.IntPtr
            Type typeOfNnint = typeof( nuint ); // System.UIntPtr
            Type typeOfNintAddInt = ( myNint + myInt ).GetType(); //System.IntPtr
            Type typeOfNintAddLong = ( myNint + myLong ).GetType(); // System.Int64

            dynamic myDynamic = 1;
            Type typeOfDynamic = myDynamic.GetType(); //System.Int32
            Type typeOfNintAddNint = ( myNint + myNint ).GetType();
            //Type typeOfNintAddNuint = ( myNint + myNuint ).GetType(); //會錯，nint 和 nuint 不能相加
            Type typeOfNintAddDynamic = ( myNint + myDynamic + myNuint ).GetType(); //RuntimeBinderException: 'Operator '+' cannot be applied to operands of type 'System.IntPtr' and 'System.UIntPtr''
        }

    }
}
