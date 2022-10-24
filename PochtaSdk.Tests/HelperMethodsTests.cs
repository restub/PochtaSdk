using NUnit.Framework;
using PochtaSdk.Toolbox;

namespace PochtaSdk.Tests
{
    [TestFixture]
    public class HelperMethodsTests
    {
        [Test]
        public void CoalesceReturnsTheFirstNonEmptyString()
        {
            Assert.That("".Coalesce(null, "  ", "Hello", "World"), Is.EqualTo("Hello"));
            Assert.That(default(string).Coalesce(null, "  ", "", "hi"), Is.EqualTo("hi"));
            Assert.That("  ".Coalesce(null, "  ", "", null, ""), Is.EqualTo(""));
            Assert.That("".Coalesce(null, null), Is.EqualTo(null));
            Assert.That("".Coalesce(null), Is.EqualTo(""));
        }
    }
}
