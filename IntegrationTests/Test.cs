using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using NUnit.Framework;

namespace IntegrationTests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void Test2()
        {
            "".Should().BeEmpty();
        }
    }
}
