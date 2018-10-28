using System;
using CS6Features;
using Xunit;

namespace CS6FeatureTests
{
    public class AutoPropertyInitializerTests
    {
        [Fact]
        public void Test1()
        {
            User user = new User();

            Assert.NotEqual(Guid.Empty, user.Id);
        }
    }
}
