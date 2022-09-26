using System;
using NUnit.Framework;
using PochtaSdk.Tariff;

namespace PochtaSdk.Tests
{
    [TestFixture]
    public class TariffClientTests
    {
        private TariffClient Client { get; } = new TariffClient
        {
            Tracer = TestContext.Progress.WriteLine
        };

        [Test]
        public void TariffClientCalculatesTariff()
        {
            var tariff = Client.Calculate(new TariffRequest
            {
                Object = TariffObjectType.WrapperRegular,
                From = 344038,
                To = 115162,
                Weight = 100,
                Date = DateTime.Now,
                Time = "0223",
            });

            Assert.That(tariff, Is.Not.Null);
            Assert.That(tariff.Weight, Is.EqualTo(100));
            Assert.That(tariff.Caption, Is.EqualTo("Расчет тарифов"));
            Assert.That(tariff.Name, Is.EqualTo("Бандероль простая"));
        }

        [Test]
        public void TariffClientCalculatesJsonTariff()
        {
            var json = Client.Calculate(TariffResponseFormat.Json, new TariffRequest
            {
                Object = TariffObjectType.WrapperRegular,
                From = 344038,
                To = 115162,
                Weight = 100,
                Date = DateTime.Now,
                Time = "0223",
            });

            Assert.That(json, Is.Not.Null.Or.Empty);
            Assert.That(json, Does.StartWith("{").And.EndWith("}"));
            Assert.That(json, Does.Contain("Расчет тарифов"));
            Assert.That(json, Does.Contain("Бандероль простая"));
        }

        [Test]
        public void TariffClientCalculatesHtmlTariff()
        {
            var html = Client.Calculate(TariffResponseFormat.Html, new TariffRequest
            {
                Object = TariffObjectType.WrapperRegular,
                From = 344038,
                To = 115162,
                Weight = 100,
                Date = DateTime.Now,
                Time = "0223",
            });

            Assert.That(html, Is.Not.Null.Or.Empty);
            Assert.That(html.Trim(), Does.StartWith("<").And.EndWith(">"));
            Assert.That(html, Does.Contain("<p>"));
            Assert.That(html, Does.Contain("Исходные данные"));
            Assert.That(html, Does.Contain("Бандероль простая"));
        }
    }
}
