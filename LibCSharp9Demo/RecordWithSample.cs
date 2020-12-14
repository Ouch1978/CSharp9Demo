using System;

namespace LibCSharp9Demo
{
    public class RecordWithSample
    {
        public void BuildRecord()
        {
            Member member = new Member( "Ouch" , "Liu" );

            Member clone = member with { }; //建立一模一樣的
            
            //透過 with 運算式複製一個，並且修改 FirstName 的值。
            Member anotherMember = clone with { FirstName = "Nicolas" };
        }
    }
}
