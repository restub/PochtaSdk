﻿using System;
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
                Object = 23030,
                From = 344038,
                To = 115162,
                Weight = 1000,
                Date = DateTime.Now,
                Time = "0223",
            });

            Assert.That(tariff, Is.Not.Null);
            Assert.That(tariff.FromIndex, Is.EqualTo(344038));
            Assert.That(tariff.ToIndex, Is.EqualTo(115162));
        }

        [Test]
        public void TariffClientCalculatesJsonTariff()
        {
            var json = Client.Calculate(TariffResponseFormat.Json, new TariffRequest
            {
                Object = 23030,
                From = 344038,
                To = 115162,
                Weight = 1000,
                Date = DateTime.Now,
                Time = "0223",
            });

            Assert.That(json, Is.Not.Null.Or.Empty);
            Assert.That(json, Does.StartWith("{").And.EndWith("}"));
            Assert.That(json, Does.Contain("344038"));
            Assert.That(json, Does.Contain("115162"));
        }

        [Test]
        public void TariffClientCalculatesHtmlTariff()
        {
            var html = Client.Calculate(TariffResponseFormat.Html, new TariffRequest
            {
                Object = 23030,
                From = 344038,
                To = 115162,
                Weight = 1000,
                Date = DateTime.Now,
                Time = "0223",
            });

            Assert.That(html, Is.Not.Null.Or.Empty);
            Assert.That(html.Trim(), Does.StartWith("<").And.EndWith(">"));
            Assert.That(html, Does.Contain("<p>"));
            Assert.That(html, Does.Contain("344038"));
            Assert.That(html, Does.Contain("115162"));
        }
    }
}
