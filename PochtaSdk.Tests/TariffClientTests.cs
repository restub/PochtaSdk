﻿using System;
using System.Linq;
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
        public void TariffClientCalculatesTariffAndDeliveryTerms()
        {
            var result = Client.Calculate(new TariffRequest
            {
                Object = ObjectType.WrapperRegular,
                FromPostCode = 344038,
                ToPostCode = 115162,
                Weight = 100,
                Date = DateTime.Now,
                Time = TimeSpan.FromHours(2.5),
            });

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Weight, Is.EqualTo(100));
            Assert.That(result.Caption, Is.EqualTo("Расчет тарифов, контрольных сроков доставки"));
            Assert.That(result.Name, Is.EqualTo("Бандероль простая"));
        }

        [Test]
        public void TariffClientCalculatesTariff()
        {
            var result = Client.CalculateTariff(new TariffRequest
            {
                Object = ObjectType.WrapperRegular,
                FromPostCode = 344038,
                ToPostCode = 115162,
                Weight = 100,
                Date = DateTime.Now,
                Time = TimeSpan.FromHours(2.5),
            });

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Weight, Is.EqualTo(100));
            Assert.That(result.Caption, Is.EqualTo("Расчет тарифов"));
            Assert.That(result.Name, Is.EqualTo("Бандероль простая"));
        }

        [Test]
        public void TariffClientCalculatesDeliveryTerms()
        {
            var result = Client.CalculateDelivery(new TariffRequest
            {
                Object = ObjectType.WrapperRegular,
                FromPostCode = 344038,
                ToPostCode = 115162,
                Weight = 100,
                Date = DateTime.Now,
                Time = TimeSpan.FromHours(2.5),
            });

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Caption, Is.EqualTo("Расчет контрольных сроков доставки"));
            Assert.That(result.Name, Is.EqualTo("Бандероль простая"));
        }

        [Test]
        public void TariffClientCalculatesJsonTariff()
        {
            var json = Client.Calculate(ResponseFormat.Json, new TariffRequest
            {
                Object = ObjectType.WrapperRegular,
                FromPostCode = 344038,
                ToPostCode = 115162,
                Weight = 100,
                Date = DateTime.Now,
                Time = TimeSpan.FromHours(2.5),
            });

            Assert.That(json, Is.Not.Null.Or.Empty);
            Assert.That(json, Does.StartWith("{").And.EndWith("}"));
            Assert.That(json, Does.Contain("Расчет тарифов"));
            Assert.That(json, Does.Contain("Бандероль простая"));
        }

        [Test]
        public void TariffClientCalculatesTextTariff()
        {
            var text = Client.Calculate(ResponseFormat.Text, new TariffRequest
            {
                Object = ObjectType.WrapperRegular,
                FromPostCode = 344038,
                ToPostCode = 115162,
                Weight = 100,
                Date = DateTime.Now,
                Time = TimeSpan.FromHours(2.5),
            });

            Assert.That(text, Is.Not.Null.Or.Empty);
            Assert.That(text, Does.StartWith("[Расчет тарифов, контрольных сроков доставки]"));
            Assert.That(text, Does.Contain("Бандероль простая"));
            Assert.That(text, Does.Contain("[Процесс расчета]"));
            Assert.That(text, Does.Contain("[Результат расчета]"));
        }

        [Test]
        public void TariffClientCalculatesHtmlTariff()
        {
            var html = Client.Calculate(ResponseFormat.Html, new TariffRequest
            {
                Object = ObjectType.WrapperRegular,
                FromPostCode = 344038,
                ToPostCode = 115162,
                Weight = 100,
                Date = DateTime.Now,
                Time = TimeSpan.FromHours(2.5),
            });

            Assert.That(html, Is.Not.Null.Or.Empty);
            Assert.That(html.Trim(), Does.StartWith("<").And.EndWith(">"));
            Assert.That(html, Does.Contain("<p>"));
            Assert.That(html, Does.Contain("Исходные данные"));
            Assert.That(html, Does.Contain("Бандероль простая"));
        }

        [Test]
        public void TariffClientCalculatesParcelTariffWithServices()
        {
            var result = Client.Calculate(new TariffRequest
            {
                Object = ObjectType.ParcelStandard,
                FromPostCode = 344038,
                ToPostCode = 115162,
                Weight = 1000,
                Date = DateTime.Now,
                Time = TimeSpan.FromHours(2.5),
                PackageType = PackageType.BoxS,
                Services =
                { 
                    ServiceType.FreeStorageUpTo7Days, 
                    ServiceType.SafetyGuarantee,
                    ServiceType.Delivery,
                    ServiceType.RegisteredDeliveryNotification,
                    ServiceType.SmsNotificationOfArrivalAtTheBranch,
                    ServiceType.SmsNotificationOfDelivery,
                }
            });

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Weight, Is.EqualTo(1000));
            Assert.That(result.Caption, Is.EqualTo("Расчет тарифов, контрольных сроков доставки"));
            Assert.That(result.Name, Is.EqualTo("Посылка стандарт"));
            Assert.That(result.Amount, Is.Not.Null);
            Assert.That(result.Amount.Value, Is.Not.EqualTo(0));
            Assert.That(result.Amount.ValueNds, Is.Not.EqualTo(0));
        }

        [Test]
        public void TariffClientCalculatesWrapperTariffWithServices()
        {
            var result = Client.Calculate(new TariffRequest
            {
                Object = ObjectType.WrapperRegistered,
                FromPostCode = 344038,
                ToPostCode = 115162,
                Weight = 1000,
                Date = DateTime.Now,
                Time = TimeSpan.FromHours(2.5),
                PackageType = PackageType.BoxS,
                Services =
                {
                    ServiceType.RegisteredDeliveryNotification,
                    ServiceType.SmsNotificationOfArrivalAtTheBranch,
                    ServiceType.SmsNotificationOfDelivery,
                    ServiceType.MaintenanceofConsolidators,
                }
            });

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Weight, Is.EqualTo(1000));
            Assert.That(result.Caption, Is.EqualTo("Расчет тарифов, контрольных сроков доставки"));
            Assert.That(result.Name, Is.EqualTo("Бандероль заказная"));
            Assert.That(result.Amount, Is.Not.Null);
            Assert.That(result.Amount.Value, Is.Not.EqualTo(0));
            Assert.That(result.Amount.ValueNds, Is.Not.EqualTo(0));
            Assert.That(result.Services, Is.Not.Null.Or.Empty);

            // check if we have tariffs for the services
            var svc = result.Services.FirstOrDefault(c => c.ServiceOn.Contains(ServiceType.SmsNotificationOfArrivalAtTheBranch));
            Assert.That(svc, Is.Not.Null);
            Assert.That(svc.Name, Is.EqualTo("СМС-уведомление о прибытии в отделение"));

            svc = result.Services.FirstOrDefault(c => c.ServiceOn.Contains(ServiceType.SmsNotificationOfDelivery));
            Assert.That(svc, Is.Not.Null);
            Assert.That(svc.Name, Is.EqualTo("СМС-уведомление о вручении"));
        }
    }
}
