using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibCSharp9Demo;

namespace Tests
{
    [TestFixture()]
    public class NativeIntSampleTests
    {
        [Test()]
        public void TestNativeIntTest()
        {
            new NativeIntSample().TestNativeInt();
        }
    }
}