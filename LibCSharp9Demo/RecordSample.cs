using System;
using LibCSharp9Demo.Models;

namespace LibCSharp9Demo
{
    public class RecordSample
    {
        public Member BuildMember( string firstName , string lastName )
        {
            return new Member( firstName , lastName );
        }

        public Member CloneMember( Member member )
        {
            return member with { }; //複製一個一樣的
        }

        public Member CloneMemberAndSetFirstName( Member member , string firstName )
        {
            //透過 with 運算式複製一個，並且修改 FirstName 的值。
            return member with { FirstName = firstName };
        }

        public bool IsEqual( Member member , Member memberToCompare )
        {
            return member == memberToCompare;
        }

        //Positional Records
        public record Product( string Name , string Brand , int Price );


        public VipMember BuildProduct( string name , string brand , int price )
        {
            //Construction by position
            return new( name , brand , price );
        }
    }
}
