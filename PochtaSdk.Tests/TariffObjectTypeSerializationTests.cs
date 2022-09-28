using NUnit.Framework;
using PochtaSdk.Tariff;
using RestSharp.Serialization;

namespace PochtaSdk.Tests
{
    [TestFixture]
    public class TariffObjectTypeSerializationTests
    {
        private IRestSerializer Serializer { get; } = new TariffClient().Serializer;

        [Test]
        public void TariffObjectTypeEnglishAndRussianNamesAreEquivalent()
        {
            Assert.That(ObjectType.LetterRegular, Is.EqualTo(ObjectType.ПисьмоПростое));
            Assert.That(Serializer.Serialize(ObjectType.LetterRegular), Is.EqualTo("2000"));
            Assert.That(Serializer.Serialize(ObjectType.ПисьмоПростое), Is.EqualTo("2000"));

            Assert.That(ObjectType.LetterRegistered, Is.EqualTo(ObjectType.ПисьмоЗаказное));
            Assert.That(Serializer.Serialize(ObjectType.LetterRegistered), Is.EqualTo("2010"));
            Assert.That(Serializer.Serialize(ObjectType.ПисьмоЗаказное), Is.EqualTo("2010"));

            Assert.That(ObjectType.LetterTrackedPostcard, Is.EqualTo(ObjectType.ПисьмоТрекОткрытка));
            Assert.That(Serializer.Serialize(ObjectType.LetterTrackedPostcard), Is.EqualTo("36000"));
            Assert.That(Serializer.Serialize(ObjectType.ПисьмоТрекОткрытка), Is.EqualTo("36000"));
        }
    }
}
