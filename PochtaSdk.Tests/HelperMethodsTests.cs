using System.Linq;
using NUnit.Framework;
using PochtaSdk.Toolbox;

namespace PochtaSdk.Tests
{
    [TestFixture]
    public class HelperMethodsTests
    {
        [Test]
        public void ToTitleCaseConvertsStringToTitleCase()
        {
            string tt(string s) => HelperMethods.ToTitleCase(s);

            Assert.That(tt("Hello, world"), Is.EqualTo("HelloWorld"));
            Assert.That(tt("Доставка почтового перевода получателю на дом"), Is.EqualTo("ДоставкаПочтовогоПереводаПолучателюНаДом"));
            Assert.That(tt(null), Is.Null);
            Assert.That(tt(string.Empty), Is.Empty);
        }

        [Test]
        public void DistinctByRemovesTheDuplicates()
        {
            var source = new[]
            {
                new { id = 1, name = "One" },
                new { id = 1, name = "Two" },
                new { id = 3, name = "Three" },
                new { id = 4, name = "Three" },
            };

            var x1 = string.Join(", ", source.DistinctBy(s => s.id).Select(s => $"{s.id}:{s.name}"));
            Assert.That(x1, Is.EqualTo("1:One, 3:Three, 4:Three"));

            var x2 = string.Join(", ", source.DistinctBy(s => s.name).Select(s => $"{s.id}:{s.name}"));
            Assert.That(x2, Is.EqualTo("1:One, 1:Two, 3:Three"));
        }
    }
}
