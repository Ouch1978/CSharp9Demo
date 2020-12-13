using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCSharp9Demo
{
    public record VipMember : Member
    {
        public int VipLevel { get; }

        public VipMember( string first , string last , int vipLevel )
            : base( first , last ) => VipLevel = vipLevel;
    }
}
