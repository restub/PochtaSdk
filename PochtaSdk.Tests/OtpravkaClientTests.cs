using System.Linq;
using System.Net;
using System.Text;
using NUnit.Framework;
using PochtaSdk.Otpravka;
using Restub;

namespace PochtaSdk.Tests
{
    [TestFixture]
    public class OtpravkaClientTests : TestBase
    {
        private OtpravkaClient Client { get; } = new OtpravkaClient(new OtpravkaCredentials
        {
            AccessToken = Env("OTPRAVKA_ACCESS_TOKEN"),
            UserName = Env("OTPRAVKA_USER_EMAIL"),
            Password = Env("OTPRAVKA_USER_PASSWORD"),
        })
        {
            Tracer = TestContext.Progress.WriteLine
        };

        [Test]
        public void OtpravkaClientAuthorizesUsingUserEmail()
        {
            var sb = new StringBuilder();
            var client = new OtpravkaClient(new OtpravkaCredentials
            {
                AccessToken = Env("OTPRAVKA_ACCESS_TOKEN"),
                UserName = Env("OTPRAVKA_USER_EMAIL"),
                Password = Env("OTPRAVKA_USER_PASSWORD"),
            })
            {
                Tracer = (fmt, args) => sb.AppendFormat(fmt, args)
            };

            var limit = client.GetApiLimit();
            Assert.That(limit, Is.Not.Null.Or.Empty);

            var log = sb.ToString();
            Assert.That(log.Length, Is.GreaterThan(0));
            Assert.That(log, Does.Contain("Authorization = AccessToken"));
            Assert.That(log, Does.Contain("X-User-Authorization"));
            Assert.That(log, Does.Contain("<- OK 200 (OK) https://otpravka-api.pochta.ru/1.0/settings/limit"));
        }

        [Test]
        public void OtpravkaClientAuthorizesUsingUserPhone()
        {
            var sb = new StringBuilder();
            var client = new OtpravkaClient(new OtpravkaCredentials
            {
                AccessToken = Env("OTPRAVKA_ACCESS_TOKEN"),
                UserName = Env("OTPRAVKA_USER_PHONE"),
                Password = Env("OTPRAVKA_USER_PASSWORD"),
            })
            {
                Tracer = (fmt, args) => sb.AppendFormat(fmt, args)
            };

            var limit = client.GetApiLimit();
            Assert.That(limit, Is.Not.Null.Or.Empty);

            var log = sb.ToString();
            Assert.That(log.Length, Is.GreaterThan(0));
            Assert.That(log, Does.Contain("Authorization = AccessToken"));
            Assert.That(log, Does.Contain("X-User-Authorization"));
            Assert.That(log, Does.Contain("<- OK 200 (OK) https://otpravka-api.pochta.ru/1.0/settings/limit"));
        }

        [Test]
        public void OtpravkaClientGetsApiLimits()
        {
            var limit = Client.GetApiLimit();
            Assert.That(limit, Is.Not.Null.Or.Empty);
            Assert.That(limit.AllowedCount, Is.GreaterThan(0));
            Assert.That(limit.CurrentCount, Is.GreaterThan(0));
            Assert.That(limit.AllowedCount, Is.GreaterThan(limit.CurrentCount));
            TestContext.Progress.WriteLine("Current API counter: {0} out of {1}", limit.CurrentCount, limit.AllowedCount);
        }

        [Test]
        public void OtpravkaClientAddressCleanup()
        {
            var address = Client.CleanAddress("Москва, Варшавское шоссе, 37");
            Assert.That(address, Is.Not.Null);
            Assert.That(address.AddressType, Is.EqualTo(AddressType.Default));
            Assert.That(address.QualityCode, Is.EqualTo(AddressQuality.Good));
            Assert.That(address.ValidationCode, Is.EqualTo(AddressValidation.Validated));
            Assert.That(address.PostCode, Is.EqualTo("117105"));
            Assert.That(address.Region, Is.EqualTo("г Москва"));
            Assert.That(address.Place, Is.EqualTo("г Москва"));
            Assert.That(address.Street, Is.EqualTo("ш Варшавское"));
            Assert.That(address.House, Is.EqualTo("37"));
            Assert.That(address.RegionGuid, Is.EqualTo("0c5b2444-70a0-4932-980c-b4dc0d3f02b5"));
            Assert.That(address.PlaceGuid, Is.EqualTo("0c5b2444-70a0-4932-980c-b4dc0d3f02b5"));
            Assert.That(address.StreetGuid, Is.EqualTo("8fc06b0b-5de3-4a72-9e6f-9e0647a37a66"));
            Assert.That(address.AddressGuid, Is.EqualTo("990231d5-4bd1-4323-997a-217002c4094e"));
        }

        [Test]
        public void OtpravkaClientAddressBatchCleanup()
        {
            var addresses = Client.CleanAddress("Москва, Варшавское шоссе, 37", "ул. Мясницкая, д. 26, г. Москва");
            Assert.That(addresses, Is.Not.Null);
            Assert.That(addresses.Length, Is.EqualTo(2));

            var address = addresses[0];
            Assert.That(address.AddressType, Is.EqualTo(AddressType.Default));
            Assert.That(address.QualityCode, Is.EqualTo(AddressQuality.Good));
            Assert.That(address.ValidationCode, Is.EqualTo(AddressValidation.Validated));
            Assert.That(address.PostCode, Is.EqualTo("117105"));
            Assert.That(address.Region, Is.EqualTo("г Москва"));
            Assert.That(address.Place, Is.EqualTo("г Москва"));
            Assert.That(address.Street, Is.EqualTo("ш Варшавское"));
            Assert.That(address.House, Is.EqualTo("37"));
            Assert.That(address.RegionGuid, Is.EqualTo("0c5b2444-70a0-4932-980c-b4dc0d3f02b5"));
            Assert.That(address.PlaceGuid, Is.EqualTo("0c5b2444-70a0-4932-980c-b4dc0d3f02b5"));
            Assert.That(address.StreetGuid, Is.EqualTo("8fc06b0b-5de3-4a72-9e6f-9e0647a37a66"));
            Assert.That(address.AddressGuid, Is.EqualTo("990231d5-4bd1-4323-997a-217002c4094e"));
            Assert.That(address.OriginalAddress, Is.EqualTo("Москва, Варшавское шоссе, 37"));

            address = addresses[1];
            Assert.That(address.AddressType, Is.EqualTo(AddressType.Default));
            Assert.That(address.QualityCode, Is.EqualTo(AddressQuality.Good));
            Assert.That(address.ValidationCode, Is.EqualTo(AddressValidation.Validated));
            Assert.That(address.PostCode, Is.EqualTo("101000"));
            Assert.That(address.Region, Is.EqualTo("г Москва"));
            Assert.That(address.Place, Is.EqualTo("г Москва"));
            Assert.That(address.Street, Is.EqualTo("ул Мясницкая"));
            Assert.That(address.House, Is.EqualTo("26"));
            Assert.That(address.RegionGuid, Is.EqualTo("0c5b2444-70a0-4932-980c-b4dc0d3f02b5"));
            Assert.That(address.PlaceGuid, Is.EqualTo("0c5b2444-70a0-4932-980c-b4dc0d3f02b5"));
            Assert.That(address.StreetGuid, Is.EqualTo("757b544e-3c93-424c-b717-6f9813f123a9"));
            Assert.That(address.AddressGuid, Is.EqualTo("c511f9b0-5117-11ec-87e6-1bcdc4503f64"));
            Assert.That(address.OriginalAddress, Is.EqualTo("ул. Мясницкая, д. 26, г. Москва"));
        }

        [Test]
        public void OtpravkaFullNameCleanup()
        {
            var person = Client.CleanFullName("Христофор Бонифатиевич Врунгель");
            Assert.That(person, Is.Not.Null);
            Assert.That(person.QualityCode, Is.EqualTo(FullNameQuality.NotSure));
            Assert.That(person.OriginalFullName, Is.EqualTo("Христофор Бонифатиевич Врунгель"));
            Assert.That(person.Name, Is.EqualTo("Христофор"));
            Assert.That(person.MiddleName, Is.EqualTo("Бонифатиевич"));
            Assert.That(person.Surname, Is.EqualTo("Врунгель"));

            person = Client.CleanFullName("Иван Рылов");
            Assert.That(person, Is.Not.Null);
            Assert.That(person.QualityCode, Is.EqualTo(FullNameQuality.NotSure));
            Assert.That(person.OriginalFullName, Is.EqualTo("Иван Рылов"));
            Assert.That(person.Name, Is.EqualTo("Иван"));
            Assert.That(person.MiddleName, Is.Null);
            Assert.That(person.Surname, Is.EqualTo("Рылов"));

            person = Client.CleanFullName("Иванка Петкова");
            Assert.That(person, Is.Not.Null);
            Assert.That(person.QualityCode, Is.EqualTo(FullNameQuality.NotSure));
            Assert.That(person.OriginalFullName, Is.EqualTo("Иванка Петкова"));
            Assert.That(person.Name, Is.EqualTo("Иванка"));
            Assert.That(person.MiddleName, Is.Null);
            Assert.That(person.Surname, Is.EqualTo("Петкова"));

            person = Client.CleanFullName("Марфа Васильевна");
            Assert.That(person, Is.Not.Null);
            Assert.That(person.QualityCode, Is.EqualTo(FullNameQuality.NotSure));
            Assert.That(person.OriginalFullName, Is.EqualTo("Марфа Васильевна"));
            Assert.That(person.Name, Is.EqualTo("Марфа"));
            Assert.That(person.MiddleName, Is.EqualTo("Васильевна"));
            Assert.That(person.Surname, Is.Null);
        }

        [Test]
        public void OtpravkaFullNameBatchCleanup()
        {
            var people = Client.CleanFullName("Христофор Бонифатьевич Врунгель", "Иван Рылов",
                "Иванка Петкова", "Марфа Васильевна", "Достоевский Константин Константинович");

            Assert.That(people, Is.Not.Null.Or.Empty);
            Assert.That(people.Length, Is.EqualTo(5));

            var person = people[0];
            Assert.That(person, Is.Not.Null);
            Assert.That(person.QualityCode, Is.EqualTo(FullNameQuality.NotSure));
            Assert.That(person.OriginalFullName, Is.EqualTo("Христофор Бонифатьевич Врунгель"));
            Assert.That(person.Name, Is.EqualTo("Христофор"));
            Assert.That(person.MiddleName, Is.EqualTo("Бонифатьевич"));
            Assert.That(person.Surname, Is.EqualTo("Врунгель"));

            person = people[1];
            Assert.That(person, Is.Not.Null);
            Assert.That(person.QualityCode, Is.EqualTo(FullNameQuality.NotSure));
            Assert.That(person.OriginalFullName, Is.EqualTo("Иван Рылов"));
            Assert.That(person.Name, Is.EqualTo("Иван"));
            Assert.That(person.MiddleName, Is.Null);
            Assert.That(person.Surname, Is.EqualTo("Рылов"));

            person = people[2];
            Assert.That(person, Is.Not.Null);
            Assert.That(person.QualityCode, Is.EqualTo(FullNameQuality.NotSure));
            Assert.That(person.OriginalFullName, Is.EqualTo("Иванка Петкова"));
            Assert.That(person.Name, Is.EqualTo("Иванка"));
            Assert.That(person.MiddleName, Is.Null);
            Assert.That(person.Surname, Is.EqualTo("Петкова"));

            person = people[3];
            Assert.That(person, Is.Not.Null);
            Assert.That(person.QualityCode, Is.EqualTo(FullNameQuality.NotSure));
            Assert.That(person.OriginalFullName, Is.EqualTo("Марфа Васильевна"));
            Assert.That(person.Name, Is.EqualTo("Марфа"));
            Assert.That(person.MiddleName, Is.EqualTo("Васильевна"));
            Assert.That(person.Surname, Is.Null);

            person = people[4];
            Assert.That(person, Is.Not.Null);
            Assert.That(person.QualityCode, Is.EqualTo(FullNameQuality.Edited));
            Assert.That(person.OriginalFullName, Is.EqualTo("Достоевский Константин Константинович"));
            Assert.That(person.Name, Is.EqualTo("Константин"));
            Assert.That(person.MiddleName, Is.EqualTo("Константинович"));
            Assert.That(person.Surname, Is.EqualTo("Достоевский"));
        }

        [Test]
        public void OtpravkaStringPhoneCleanup()
        { 
            var phone = Client.CleanPhone("499 12345-67");
            Assert.That(phone, Is.Not.Null);
            Assert.That(phone.QualityCode, Is.EqualTo(PhoneQuality.Good));
            Assert.That(phone.OriginalPhone, Is.EqualTo("499 12345-67"));
            Assert.That(phone.PhoneCountryCode, Is.EqualTo("7"));
            Assert.That(phone.PhoneCityCode, Is.EqualTo("499"));
            Assert.That(phone.PhoneNumber, Is.EqualTo("1234567"));
            Assert.That(phone.PhoneExtension, Is.EqualTo(string.Empty));

            phone = Client.CleanPhone("+78632 21-54-55");
            Assert.That(phone, Is.Not.Null);
            Assert.That(phone.QualityCode, Is.EqualTo(PhoneQuality.Good));
            Assert.That(phone.OriginalPhone, Is.EqualTo("+78632 21-54-55"));
            Assert.That(phone.PhoneCountryCode, Is.EqualTo("7"));
            Assert.That(phone.PhoneCityCode, Is.EqualTo("863"));
            Assert.That(phone.PhoneNumber, Is.EqualTo("2215455"));
            Assert.That(phone.PhoneExtension, Is.EqualTo(string.Empty));

            phone = Client.CleanPhone("+78632 21-54-5");
            Assert.That(phone, Is.Not.Null);
            Assert.That(phone.QualityCode, Is.EqualTo(PhoneQuality.IncorrectData));
            Assert.That(phone.OriginalPhone, Is.EqualTo("+78632 21-54-5"));
            Assert.That(phone.PhoneCountryCode, Is.EqualTo(string.Empty));
            Assert.That(phone.PhoneCityCode, Is.EqualTo(string.Empty));
            Assert.That(phone.PhoneNumber, Is.EqualTo(string.Empty));
            Assert.That(phone.PhoneExtension, Is.EqualTo(string.Empty));

            phone = Client.CleanPhone("+7495 321-54-56 123");
            Assert.That(phone, Is.Not.Null);
            Assert.That(phone.QualityCode, Is.EqualTo(PhoneQuality.IncorrectData));
            Assert.That(phone.OriginalPhone, Is.EqualTo("+7495 321-54-56 123"));
            Assert.That(phone.PhoneCountryCode, Is.EqualTo(string.Empty));
            Assert.That(phone.PhoneCityCode, Is.EqualTo(string.Empty));
            Assert.That(phone.PhoneNumber, Is.EqualTo(string.Empty));
            Assert.That(phone.PhoneExtension, Is.EqualTo(string.Empty));
        }

        [Test]
        public void OtpravkaStringPhoneBatchCleanup()
        {
            var phones = Client.CleanPhone("499 12345-67", "+78632 21-54-55",
                "+78632 21-54-5", "+7495 321-54-56 123");
            Assert.That(phones, Is.Not.Null.Or.Empty);
            Assert.That(phones.Length, Is.EqualTo(4));

            var phone = phones[0];
            Assert.That(phone, Is.Not.Null);
            Assert.That(phone.QualityCode, Is.EqualTo(PhoneQuality.Good));
            Assert.That(phone.OriginalPhone, Is.EqualTo("499 12345-67"));
            Assert.That(phone.PhoneCountryCode, Is.EqualTo("7"));
            Assert.That(phone.PhoneCityCode, Is.EqualTo("499"));
            Assert.That(phone.PhoneNumber, Is.EqualTo("1234567"));
            Assert.That(phone.PhoneExtension, Is.EqualTo(string.Empty));

            phone = phones[1];
            Assert.That(phone, Is.Not.Null);
            Assert.That(phone.QualityCode, Is.EqualTo(PhoneQuality.Good));
            Assert.That(phone.OriginalPhone, Is.EqualTo("+78632 21-54-55"));
            Assert.That(phone.PhoneCountryCode, Is.EqualTo("7"));
            Assert.That(phone.PhoneCityCode, Is.EqualTo("863"));
            Assert.That(phone.PhoneNumber, Is.EqualTo("2215455"));
            Assert.That(phone.PhoneExtension, Is.EqualTo(string.Empty));

            phone = phones[2];
            Assert.That(phone, Is.Not.Null);
            Assert.That(phone.QualityCode, Is.EqualTo(PhoneQuality.IncorrectData));
            Assert.That(phone.OriginalPhone, Is.EqualTo("+78632 21-54-5"));
            Assert.That(phone.PhoneCountryCode, Is.EqualTo(string.Empty));
            Assert.That(phone.PhoneCityCode, Is.EqualTo(string.Empty));
            Assert.That(phone.PhoneNumber, Is.EqualTo(string.Empty));
            Assert.That(phone.PhoneExtension, Is.EqualTo(string.Empty));

            phone = phones[3];
            Assert.That(phone, Is.Not.Null);
            Assert.That(phone.QualityCode, Is.EqualTo(PhoneQuality.IncorrectData));
            Assert.That(phone.OriginalPhone, Is.EqualTo("+7495 321-54-56 123"));
            Assert.That(phone.PhoneCountryCode, Is.EqualTo(string.Empty));
            Assert.That(phone.PhoneCityCode, Is.EqualTo(string.Empty));
            Assert.That(phone.PhoneNumber, Is.EqualTo(string.Empty));
            Assert.That(phone.PhoneExtension, Is.EqualTo(string.Empty));
        }

        [Test]
        public void OtpravkaPhoneBatchCleanup()
        {
            var phones = Client.CleanPhone(
                new PhoneRequest
                {
                    ID = "hoho",
                    Area = "Москва",
                    Place = "Москва",
                    Region = "Центральный",
                    OriginalPhone = "499 12345-67",
                },
                new PhoneRequest
                {
                    ID = string.Empty,
                    Area = "",
                    Place = "",
                    Region = "",
                    OriginalPhone = "+78632 21-54-55",
                },
                new PhoneRequest
                {
                    ID = "haha",
                    Area = "",
                    Place = "",
                    Region = "",
                    OriginalPhone = "+7499 1131623",
                });

            Assert.That(phones, Is.Not.Null.Or.Empty);
            Assert.That(phones.Length, Is.EqualTo(3));

            var phone = phones[0];
            Assert.That(phone, Is.Not.Null);
            Assert.That(phone.ID, Is.EqualTo("hoho"));
            Assert.That(phone.QualityCode, Is.EqualTo(PhoneQuality.Good));
            Assert.That(phone.OriginalPhone, Is.EqualTo("499 12345-67"));
            Assert.That(phone.PhoneCountryCode, Is.EqualTo("7"));
            Assert.That(phone.PhoneCityCode, Is.EqualTo("499"));
            Assert.That(phone.PhoneNumber, Is.EqualTo("1234567"));
            Assert.That(phone.PhoneExtension, Is.EqualTo(string.Empty));

            phone = phones[1];
            Assert.That(phone, Is.Not.Null);
            Assert.That(phone.ID, Is.EqualTo(string.Empty));
            Assert.That(phone.QualityCode, Is.EqualTo(PhoneQuality.Good));
            Assert.That(phone.OriginalPhone, Is.EqualTo("+78632 21-54-55"));
            Assert.That(phone.PhoneCountryCode, Is.EqualTo("7"));
            Assert.That(phone.PhoneCityCode, Is.EqualTo("863"));
            Assert.That(phone.PhoneNumber, Is.EqualTo("2215455"));
            Assert.That(phone.PhoneExtension, Is.EqualTo(string.Empty));

            phone = phones[2];
            Assert.That(phone, Is.Not.Null);
            Assert.That(phone.ID, Is.EqualTo("haha"));
            Assert.That(phone.QualityCode, Is.EqualTo(PhoneQuality.Good));
            Assert.That(phone.OriginalPhone, Is.EqualTo("+7499 1131623"));
            Assert.That(phone.PhoneCountryCode, Is.EqualTo("7"));
            Assert.That(phone.PhoneCityCode, Is.EqualTo("499"));
            Assert.That(phone.PhoneNumber, Is.EqualTo("1131623"));
            Assert.That(phone.PhoneExtension, Is.EqualTo(string.Empty));
        }

        [Test]
        public void OtpravkaClientDoesntReportErrorsWhenNoOrdersAreSpecifiedForCreation()
        {
            var result = Client.CreateOrders();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ResultIDs, Is.Not.Null);
            Assert.That(result.ResultIDs, Is.Empty);
        }

        [Test]
        public void OtpravkaClientFailsToCreateOrderWhenNoPropertiesAreSpecified()
        {
            // why the status code is 0? no idea!
            Assert.That(() => Client.CreateOrders(new Order()),
                Throws.TypeOf<RestubException>()
                    .With.Property("StatusCode").EqualTo(HttpStatusCode.OK)
                    .And.Message.Contains("некорректно")
                    .And.Message.Contains("значение")
                    .And.Message.Contains("не указан")
                    .And.Message.Contains("короткий"));
        }

        [Test]
        public void OtpravkaClientFailsToCreateOrderWhenRequiredPropertiesAreNotSpecified()
        {
            Assert.That(() => Client.CreateOrders(new Order
            {
                AddressFrom = new Address
                {
                    AddressType = AddressType.Demand,
                    PostCode = "115162",
                },
                AddressTypeTo = AddressType.Demand,
                PostCodeTo = 344038,
            }),
            Throws.TypeOf<RestubException>()
                .With.Property("StatusCode").EqualTo(HttpStatusCode.OK)
                .And.Message.Contains("некорректно")
                .And.Message.Contains("значение")
                .And.Message.Contains("не указан")
                .And.Message.Contains("короткий"));
        }

        private int CreatedOrderID { get; set; } = 894604455;

        [Test, Ordered]
        public void OtpravkaClientCreatesAnOrder()
        {
            var result = Client.CreateOrders(new Order
            {
                OrderNum = "001",
                AddressFrom = new Address
                {
                    AddressType = AddressType.Demand,
                    PostCode = "115162",
                },
                AddressTypeTo = AddressType.Default,
                GivenName = "Иван",
                MiddleName = "Иванович",
                Surname = "Иванов",
                PostOfficeCode = "142300",
                PostCodeTo = 117105,
                RegionTo = "г. Москва",
                PlaceTo = "г. Москва",
                StreetTo = "ш Варшавское",
                HouseTo = "37",
                TelAddressFrom = 79871234567,
                TelAddress = 79871234567,
                DeclaredValue = 1000,
                TransportType = Otpravka.TransportType.Surface,
                MailCategory = MailCategory.Ordinary,
                MailCountryCode = Tariff.OksmCountryCode.Russia,
                MailType = MailType.PostalParcel,
                Mass = 1000,
                Dimensions = new Dimensions
                { 
                    Height = 3,
                    Length = 9,
                    Width = 73,
                },
                Fragile = true
            });

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ResultIDs, Is.Not.Null.Or.Empty);
            CreatedOrderID = result.ResultIDs.First();
        }

        [Test]
        public void OtpravkaClientThrowsWhenOrderIsNotFound()
        {
            Assert.That(() => Client.GetOrder(123), 
                Throws.TypeOf<RestubException>()
                    .With.Message.EqualTo("Instance ComplexOrderV2 not found for params: 123"));
        }

        [Test, Ordered]
        public void OtpravkaClientReturnsAnOrderByIdentity()
        {
            Assert.That(CreatedOrderID, Is.Not.EqualTo(0));
            var result = Client.GetOrder(CreatedOrderID);
            Assert.That(result, Is.Not.Null.Or.Empty);
            Assert.That(result.ID, Is.EqualTo(CreatedOrderID));
        }

        [Test, Ordered]
        public void OtpravkaClientDeletesAnOrder()
        {
            Assert.That(CreatedOrderID, Is.Not.EqualTo(0));
            var result = Client.DeleteOrders(CreatedOrderID);
            Assert.That(result, Is.Not.Null.Or.Empty);
            Assert.That(result.ResultIDs, Is.Not.Null.Or.Empty);
            Assert.That(result.ResultIDs.First(), Is.EqualTo(CreatedOrderID));
        }
    }
}
