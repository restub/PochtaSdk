using System;
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
        public void CalculateTariffAndDeliveryTerms()
        {
            var result = Client.Calculate(new TariffRequest
            {
                ObjectType = ObjectType.WrapperRegular,
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
        public void CalculateTariff()
        {
            var result = Client.CalculateTariff(new TariffRequest
            {
                ObjectType = ObjectType.WrapperRegular,
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
        public void CalculateDeliveryTerms()
        {
            var result = Client.CalculateDelivery(new TariffRequest
            {
                ObjectType = ObjectType.WrapperRegular,
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
        public void CalculateJsonTariff()
        {
            var json = Client.Calculate(ResponseFormat.Json, new TariffRequest
            {
                ObjectType = ObjectType.WrapperRegular,
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
        public void CalculateTextTariff()
        {
            var text = Client.Calculate(ResponseFormat.Text, new TariffRequest
            {
                ObjectType = ObjectType.WrapperRegular,
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
        public void CalculateHtmlTariff()
        {
            var html = Client.Calculate(ResponseFormat.Html, new TariffRequest
            {
                ObjectType = ObjectType.WrapperRegular,
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
        public void CalculateParcelTariffWithServices()
        {
            var result = Client.Calculate(new TariffRequest
            {
                ObjectType = ObjectType.ParcelStandard,
                FromPostCode = 344038,
                ToPostCode = 115162,
                Weight = 1000,
                Date = DateTime.Now,
                Time = TimeSpan.FromHours(2.5),
                PackageType = PackageType.BoxS,
                Services =
                { 
                    ServiceType.FreeStorageForUpTo7Days, 
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
            Assert.That(result.GroundAmount, Is.Not.Null);
            Assert.That(result.GroundAmount.Value, Is.Not.EqualTo(0));
            Assert.That(result.GroundAmount.ValueNds, Is.Not.EqualTo(0));
        }

        [Test]
        public void CalculateWrapperTariffWithServices()
        {
            var result = Client.Calculate(new TariffRequest
            {
                ObjectType = ObjectType.WrapperRegistered,
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
                    ServiceType.MaintenanceOfConsolidators,
                }
            });

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Weight, Is.EqualTo(1000));
            Assert.That(result.Caption, Is.EqualTo("Расчет тарифов, контрольных сроков доставки"));
            Assert.That(result.Name, Is.EqualTo("Бандероль заказная"));
            Assert.That(result.GroundAmount, Is.Not.Null);
            Assert.That(result.GroundAmount.Value, Is.Not.EqualTo(0));
            Assert.That(result.GroundAmount.ValueNds, Is.Not.EqualTo(0));
            Assert.That(result.Items, Is.Not.Null.Or.Empty);

            // check if we have tariffs for the services
            var svc = result.Items.FirstOrDefault(c => c.ServiceOn.Contains(ServiceType.SmsNotificationOfArrivalAtTheBranch));
            Assert.That(svc, Is.Not.Null);
            Assert.That(svc.Name, Is.EqualTo("СМС-уведомление о прибытии в отделение"));

            svc = result.Items.FirstOrDefault(c => c.ServiceOn.Contains(ServiceType.SmsNotificationOfDelivery));
            Assert.That(svc, Is.Not.Null);
            Assert.That(svc.Name, Is.EqualTo("СМС-уведомление о вручении"));
        }

        [Test]
        [TestCase(ObjectType.ParcelOnlineRegular, 10)] // ПосылкаОнлайнОбыкновенная
        [TestCase(ObjectType.CourierOnlineRegular, 12.5)] // КурьерОнлайнОбыкновенный
        [TestCase(ObjectType.ParcelEasyReturnRegular, 2.1)] // ПосылкаЛегкийВозвратОбыкновенная
        [TestCase(ObjectType.ParcelOnlineWithDeclaredValue, 0.2)] // ПосылкаОнлайнСОбъявленнойЦенностью
        public void CalculatePackageTariffsWithServices(ObjectType objectType, double hourOfDay)
        {
            var result = Client.Calculate(new TariffRequest
            {
                ObjectType = objectType,
                FromPostCode = 344038,
                ToPostCode = 115162,
                Weight = 1000,
                Date = DateTime.Today.AddDays(1),
                Time = TimeSpan.FromHours(hourOfDay),
                PackageType = PackageType.BoxM,
                SumOc = 1000,
                Services =
                {
                    ServiceType.RegisteredDeliveryNotification,
                    ServiceType.SmsNotificationOfArrivalAtTheBranch,
                    ServiceType.SmsNotificationOfDelivery,
                    ServiceType.MaintenanceOfConsolidators,
                }
            });

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Weight, Is.EqualTo(1000));
            Assert.That(result.Caption, Is.EqualTo("Расчет тарифов, контрольных сроков доставки"));
            Assert.That(result.GroundAmount, Is.Not.Null);
            Assert.That(result.GroundAmount.Value, Is.Not.EqualTo(0));
            Assert.That(result.GroundAmount.ValueNds, Is.Not.EqualTo(0));
            Assert.That(result.Items, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void GetCategories()
        {
            var cat = Client.GetCategories();
            Assert.That(cat, Is.Not.Null.Or.Empty);

            var html = Client.GetCategories(ResponseFormat.Html);
            Assert.That(html, Is.Not.Null.Or.Empty);

            var text = Client.GetCategories(ResponseFormat.Text);
            Assert.That(text, Is.Not.Null.Or.Empty);
        }

        [Test]
        [TestCase(0)]
        [TestCase(100)]
        [TestCase(200)]
        [TestCase(400)]
        [TestCase(612)]
        public void GetCategoryDescription(int id)
        {
            var cat = Client.GetCategoryDescription(id);
            Assert.That(cat, Is.Not.Null.Or.Empty);

            var html = Client.GetCategoryDescription(ResponseFormat.Html, id);
            Assert.That(html, Is.Not.Null.Or.Empty);

            var text = Client.GetCategoryDescription(ResponseFormat.Text, id);
            Assert.That(text, Is.Not.Null.Or.Empty);
        }

        [Test]
        [TestCase(400)]
        [TestCase(100)]
        [TestCase(200)]
        [TestCase(400)]
        [TestCase(207)]
        public void GetObjectTypes(int id)
        {
            var cat = Client.GetObjectTypes(id);
            Assert.That(cat, Is.Not.Null.Or.Empty);

            var html = Client.GetObjectTypes(ResponseFormat.Html, id);
            Assert.That(html, Is.Not.Null.Or.Empty);

            var text = Client.GetObjectTypes(ResponseFormat.Text, id);
            Assert.That(text, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void GetServices()
        {
            var services = Client.GetServices();
            Assert.That(services, Is.Not.Null.Or.Empty);

            services = Client.GetServices(ServiceType.Administrative, ServiceType.Billing, ServiceType.CombinedDelivery);
            Assert.That(services, Is.Not.Null.Or.Empty);

            var html = Client.GetServices(ResponseFormat.Html);
            Assert.That(html, Is.Not.Null.Or.Empty);

            var text = Client.GetServices(ResponseFormat.Text, ServiceType.Administrative, ServiceType.Billing, ServiceType.CombinedDelivery);
            Assert.That(text, Is.Not.Null.Or.Empty);
        }
    }
}
