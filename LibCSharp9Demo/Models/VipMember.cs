namespace LibCSharp9Demo.Models
{
    public record VipMember : Member
    {
        public int VipLevel { get; init; }

        public VipMember( string firstName , string lastName , int vipLevel )
            : base( firstName , lastName ) => VipLevel = vipLevel;
    }
}
