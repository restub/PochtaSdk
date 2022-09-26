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
            Assert.That(TariffObjectType.LetterRegular, Is.EqualTo(TariffObjectType.ПисьмоПростое));
            Assert.That(Serializer.Serialize(TariffObjectType.LetterRegular), Is.EqualTo("2000"));
            Assert.That(Serializer.Serialize(TariffObjectType.ПисьмоПростое), Is.EqualTo("2000"));

            Assert.That(TariffObjectType.LetterRegistered, Is.EqualTo(TariffObjectType.ПисьмоЗаказное));
            Assert.That(Serializer.Serialize(TariffObjectType.LetterRegistered), Is.EqualTo("2010"));
            Assert.That(Serializer.Serialize(TariffObjectType.ПисьмоЗаказное), Is.EqualTo("2010"));

            Assert.That(TariffObjectType.LetterTrackedPostcard, Is.EqualTo(TariffObjectType.ПисьмоТрекОткрытка));
            Assert.That(Serializer.Serialize(TariffObjectType.LetterTrackedPostcard), Is.EqualTo("36000"));
            Assert.That(Serializer.Serialize(TariffObjectType.ПисьмоТрекОткрытка), Is.EqualTo("36000"));
        }
    }
}
