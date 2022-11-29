﻿using System;
using NUnit.Framework;
using PochtaSdk.Otpravka;
using PochtaSdk.Tariff;
using Restub;
using DeliveryTerms = PochtaSdk.Tariff.DeliveryTerms;

namespace PochtaSdk.Tests
{
    [TestFixture]
    public class TariffSerializationTests
    {
        private IRestubSerializer Serializer { get; } = new TariffClient().Serializer;

        [Test]
        public void TariffObjectTypeEnglishAndRussianNamesAreEquivalent()
        {
            Assert.That(ObjectType.LetterRegular, Is.EqualTo(ObjectType.ПисьмоПростое));
            Assert.That(Serializer.Serialize(ObjectType.LetterRegular), Is.EqualTo("2000"));
            Assert.That(Serializer.Serialize(ObjectType.ПисьмоПростое), Is.EqualTo("2000"));

            Assert.That(ObjectType.LetterRegistered, Is.EqualTo(ObjectType.ПисьмоЗаказное));
            Assert.That(Serializer.Serialize(ObjectType.LetterRegistered), Is.EqualTo("2010"));
            Assert.That(Serializer.Serialize(ObjectType.ПисьмоЗаказное), Is.EqualTo("2010"));

            Assert.That(ObjectType.TrackPostcard, Is.EqualTo(ObjectType.ТрекОткрытка));
            Assert.That(Serializer.Serialize(ObjectType.TrackPostcard), Is.EqualTo("36000"));
            Assert.That(Serializer.Serialize(ObjectType.ТрекОткрытка), Is.EqualTo("36000"));
        }

        [Test]
        public void DeliveryTermsUsesDatesWithoutDelimiters()
        {
            var json = Serializer.Serialize(new DeliveryTerms
            {
                Min = 1,
                Max = 10,
                Deadline = new DateTime(2022, 12, 10, 11, 30, 00, DateTimeKind.Utc)
            });

            Assert.That(json, Is.Not.Null.And.Not.Empty);
            Assert.That(json, Is.EqualTo("{\"min\":1,\"max\":10,\"deadline\":\"20221210T113000\"}"));

            var info = Serializer.Deserialize<DeliveryTerms>(json);
            Assert.That(info, Is.Not.Null);
            Assert.That(info.Deadline, Is.InRange(new DateTime(2022, 12, 10), new DateTime(2022, 12, 11)));

            var tmp = Serializer.Deserialize<DeliveryTerms>(@"{""min"":4,""max"":4,""deadline"":""20221003T235900""}");
            Assert.That(tmp, Is.Not.Null);
        }

        [Test]
        public void OrderSerializationTests()
        {
            // no null values
            var orderJson = "{\"address-type-to\":\"DEFAULT\"," +
                "\"given-name\":\"Иван\",\"house-to\":\"1\"," +
                "\"index-to\":117463,\"mail-category\":\"ORDINARY\"," +
                "\"mail-direct\":643,\"mail-type\":\"POSTAL_PARCEL\"," +
                "\"mass\":1234,\"middle-name\":\"Иванович\"," +
                "\"order-num\":\"тест 111\",\"place-to\":\"Москва\"," +
                "\"postoffice-code\":\"109012\",\"region-to\":\"Москва\"," +
                "\"street-to\":\"Ул. Паустовского\",\"surname\":\"Иванов\"}";

            var order = Serializer.Deserialize<Order>(orderJson);
            Assert.That(order, Is.Not.Null);
            Assert.That(order.GivenName, Is.EqualTo("Иван"));

            var json = Serializer.Serialize(order);
            Assert.That(json, Is.Not.Null.Or.Empty);
            Assert.That(json, Is.EqualTo(orderJson));
        }
    }
}