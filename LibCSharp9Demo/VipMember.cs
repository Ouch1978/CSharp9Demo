using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCSharp9Demo
{
    public record VipMember : Member
    {
        public int VipLevel { get; init; }

        public VipMember( string firstName , string lastName , int vipLevel )
            : base( firstName , lastName ) => VipLevel = vipLevel;
    }
}
