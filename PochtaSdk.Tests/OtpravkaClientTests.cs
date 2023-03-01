using System;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using PochtaSdk.Otpravka;
using HttpStatusCode = System.Net.HttpStatusCode;
using OksmCountryCode = PochtaSdk.Tariff.OksmCountryCode;

namespace PochtaSdk.Tests
{
    [TestFixture]
    public class OtpravkaClientTests : TestBase, IDisposable
    {
        private OtpravkaClient Client { get; } = new OtpravkaClient(
            accessToken: Env("OTPRAVKA_ACCESS_TOKEN"),
            userName: Env("OTPRAVKA_USER_EMAIL"),
            password: Env("OTPRAVKA_USER_PASSWORD"))
        {
            Tracer = TestContext.Progress.WriteLine
        };

        private ApiLimit ApiLimit { get; set; }

        public void Dispose() => DisplayApiLimit();

        private void DisplayApiLimit()
        {
            Client.Tracer = null;
            ApiLimit = ApiLimit ?? Client.GetApiLimit();
            TestContext.Progress.WriteLine("========================================");
            TestContext.Progress.WriteLine("Current API counter: {0} out of {1}", ApiLimit.CurrentCount, ApiLimit.AllowedCount);
            TestContext.Progress.WriteLine("========================================");
        }

        [Test]
        public void AuthorizeUsingUserEmail()
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

            ApiLimit = client.GetApiLimit();
            Assert.That(ApiLimit, Is.Not.Null);

            var log = sb.ToString();
            Assert.That(log, Is.Not.Null.And.Not.Empty);
            Assert.That(log, Does.Contain("Authorization = AccessToken"));
            Assert.That(log, Does.Contain("X-User-Authorization"));
            Assert.That(log, Does.Contain("<- OK 200 (OK) https://otpravka-api.pochta.ru/1.0/settings/limit"));
        }

        [Test]
        public void AuthorizeUsingUserPhone()
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

            ApiLimit = client.GetApiLimit();
            Assert.That(ApiLimit, Is.Not.Null);

            var log = sb.ToString();
            Assert.That(log, Is.Not.Null.And.Not.Empty);
            Assert.That(log, Does.Contain("Authorization = AccessToken"));
            Assert.That(log, Does.Contain("X-User-Authorization"));
            Assert.That(log, Does.Contain("<- OK 200 (OK) https://otpravka-api.pochta.ru/1.0/settings/limit"));
        }

        [Test]
        public void GetApiLimits()
        {
            ApiLimit = Client.GetApiLimit();
            Assert.That(ApiLimit, Is.Not.Null);
            Assert.That(ApiLimit.AllowedCount, Is.GreaterThan(0));
            Assert.That(ApiLimit.CurrentCount, Is.GreaterThan(0));
            Assert.That(ApiLimit.AllowedCount, Is.GreaterThan(ApiLimit.CurrentCount));
            DisplayApiLimit();
        }

        [Test]
        public void AddressCleanup()
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

            address = Client.CleanAddress("набережная реки Пряжки, 46, 1, Санкт-Петербург, 190121");
            Assert.That(address, Is.Not.Null);
            Assert.That(address.AddressType, Is.EqualTo(AddressType.Default));
            Assert.That(address.QualityCode, Is.EqualTo(AddressQuality.Good));
            Assert.That(address.ValidationCode, Is.EqualTo(AddressValidation.Validated));
            Assert.That(address.PostCode, Is.EqualTo("190121"));
            Assert.That(address.Region, Is.EqualTo("г Санкт-Петербург"));
            Assert.That(address.Place, Is.EqualTo("г Санкт-Петербург"));
            Assert.That(address.Street, Is.EqualTo("наб Реки Пряжки"));
            Assert.That(address.House, Is.EqualTo("46"));
            Assert.That(address.Room, Is.EqualTo("1"));
            Assert.That(address.RegionGuid, Is.EqualTo("c2deb16a-0330-4f05-821f-1d09c93331e6"));
            Assert.That(address.PlaceGuid, Is.EqualTo("c2deb16a-0330-4f05-821f-1d09c93331e6"));
            Assert.That(address.StreetGuid, Is.EqualTo("ca64ff57-2d6f-40ed-81d2-66cd94c6d630"));
        }

        [Test]
        public void AddressBatchCleanup()
        {
            var addresses = Client.CleanAddress("Москва, Варшавское шоссе, 37", "ул. Мясницкая, д. 26, г. Москва");
            Assert.That(addresses, Is.Not.Null);
            Assert.That(addresses, Has.Length.EqualTo(2));

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
        public void FullNameCleanup()
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
        public void FullNameBatchCleanup()
        {
            var people = Client.CleanFullName("Христофор Бонифатьевич Врунгель", "Иван Рылов",
                "Иванка Петкова", "Марфа Васильевна", "Достоевский Константин Константинович");

            Assert.That(people, Is.Not.Null.And.Not.Empty);
            Assert.That(people, Has.Length.EqualTo(5));

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
        public void StringPhoneCleanup()
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
        public void StringPhoneBatchCleanup()
        {
            var phones = Client.CleanPhone("499 12345-67", "+78632 21-54-55",
                "+78632 21-54-5", "+7495 321-54-56 123");
            Assert.That(phones, Is.Not.Null.And.Not.Empty);
            Assert.That(phones, Has.Length.EqualTo(4));

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
        public void PhoneBatchCleanup()
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

            Assert.That(phones, Is.Not.Null.And.Not.Empty);
            Assert.That(phones, Has.Length.EqualTo(3));

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
        public void NoErrorsReportedWhenNoOrdersAreSpecifiedForCreation()
        {
            var result = Client.CreateOrders();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ResultIDs, Is.Not.Null);
            Assert.That(result.ResultIDs, Is.Empty);
        }

        [Test]
        public void CantCreateOrderWhenNoPropertiesAreSpecified()
        {
            Assert.That(() => Client.CreateOrders(new Order()),
                Throws.TypeOf<OtpravkaException>()
                    .With.Property(nameof(OtpravkaException.StatusCode)).EqualTo(HttpStatusCode.OK)
                    //.And.Message.Contains("значение")
                    //.And.Message.Contains("не заполнен")
                    .And.Message.Contains("не задан")
                    .And.Message.Contains("не указан"));
        }

        [Test]
        public void CantCreateOrderWhenRequiredPropertiesAreNotSpecified()
        {
            // this test ensures proper error handling for error reports like this:
            // body: {
            //   "errors": [
            //     {
            //       "error-codes": [
            //         {
            //           "code": "ILLEGAL_MAIL_CATEGORY",
            //           "description": "Категория 'ORDINARY' не поддерживается для данного вида отправления на данном направлении",
            //           "details": "ORDINARY"
            //         },
            //         {
            //           "code": "EMPTY_POSTOFFICE_CODE",
            //           "description": "Индекс приемного почтового отделения не задан",
            //           "details": "102961 117042 142300"
            //         },
            //         {
            //           "code": "ILLEGAL_RECIPIENT_NAME",
            //           "description": "Недопустимое значение поля \"Имя получателя\"."
            //         },
            //         {
            //           "code": "EMPTY_REGION_TO",
            //           "description": "Регион не заполнен"
            //         },
            //         {
            //           "code": "EMPTY_PLACE_TO",
            //           "description": "Населенный пункт не указан"
            //         },
            //         {
            //           "code": "EMPTY_MASS",
            //           "description": "Масса не указана"
            //         }
            //       ],
            //       "position": 0
            //     }
            //   ]
            // }
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
            Throws.TypeOf<OtpravkaException>()
                .With.Property(nameof(OtpravkaException.StatusCode)).EqualTo(HttpStatusCode.OK)
                //.And.Message.Contains("не заполнен")
                //.And.Message.Contains("значение")
                .And.Message.Contains("приемного")
                .And.Message.Contains("не задан")
                .And.Message.Contains("не указан"));
        }

        private Order CreateTestOrder(string num = "002", string groupName = null) => new Order
        {
            OrderNum = num,
            GroupName = groupName,
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
            TransportType = TransportType.Surface,
            MailCategory = MailCategory.WithDeclaredValue,
            MailCountryCode = OksmCountryCode.Russia,
            MailType = MailType.PostalParcel,
            Mass = 1000,
            Dimensions = new Dimensions
            {
                Height = 3,
                Length = 9,
                Width = 73,
            },
            Fragile = true,
            SmsNoticeRecipient = true,
            //Inventory = true,
            //Goods = new OrderGoods
            //{
            //    Items = new List<OrderGoodsItem>
            //    {
            //        new OrderGoodsItem
            //        {
            //            Code = "123",
            //            CountryCode = OksmCountryCode.Russia,
            //            Description = "Пылесос карманный",
            //            GoodsType = OrderGoodsItemType.Goods,
            //            LineAttr = OrderGoodsLineAttr.GoodsWithoutExcise,
            //            ItemNumber = "123",
            //            DeclaredValue = 3000,
            //            Quantity = 3,
            //            Value = 1000,
            //            Weight = 500,
            //        },
            //    },
            //},
        };

        [Test, Ordered]
        public void CreateOrder()
        {
            var order = CreateTestOrder("001");
            var result = Client.CreateOrders(order);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ResultIDs, Is.Not.Null.And.Not.Empty);

            CreatedOrderID = result.ResultIDs.First();
            TestContext.Progress.WriteLine("Created an order: {0}", CreatedOrderID);
        }

        private long CreatedOrderID { get; set; } = 920755995;

        [Test, Ordered]
        public void GetOrderByIdentity()
        {
            Assert.That(CreatedOrderID, Is.Not.EqualTo(0));
            var result = Client.GetOrder(CreatedOrderID);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ID, Is.EqualTo(CreatedOrderID));
        }

        [Test]
        public void ThrowWhenOrderIsNotFound()
        {
            // this test ensures proper error handling for error reports like this:
            // body: {
            //   "code": "1001",
            //   "desc": "Instance ComplexOrderV2 not found for params: 123",
            //   "sub-code": "RESOURCE_NOT_FOUND"
            // }
            Assert.That(() => Client.GetOrder(123),
                Throws.TypeOf<OtpravkaException>()
                    .With.Message.EqualTo("Instance ComplexOrderV2 not found for params: 123"));
        }

        [Test, Ordered]
        public void UpdateAnOrderReturnedByGetOrder()
        {
            Assert.That(CreatedOrderID, Is.Not.EqualTo(0));
            var result = Client.GetOrder(CreatedOrderID);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ID, Is.EqualTo(CreatedOrderID));

            // update the created order
            var name = Tuple.Create("Василий", "Васильевич", "Подгорный");
            result.GivenName = name.Item1;
            result.MiddleName = name.Item2;
            result.Surname = name.Item3;
            Client.UpdateOrder(CreatedOrderID, result);

            result = Client.GetOrder(CreatedOrderID);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ID, Is.EqualTo(CreatedOrderID));
            Assert.That(result.GivenName, Is.EqualTo(name.Item1));
            Assert.That(result.MiddleName, Is.EqualTo(name.Item2));
            Assert.That(result.Surname, Is.EqualTo(name.Item3));
        }

        [Test, Ordered]
        public void UpdateOrderThrowsErrorOnInvalidParameters()
        {
            Assert.That(CreatedOrderID, Is.Not.EqualTo(0));

            var order = CreateTestOrder();
            order.MailType = MailType.OnlineParcel;
            order.MailCategory = MailCategory.Ordered;
            order.SmsNoticeRecipient = true;

            Assert.That(() => Client.UpdateOrder(CreatedOrderID, order),
                Throws.TypeOf<OtpravkaException>().With
                    .Message.Contains("не поддерживается"));
        }

        [Test]
        public void ReturnOrderToBacklogThrowsANotFoundError()
        {
            // this test ensures proper error handling for error reports like this:
            // body: {
            //   "errors": [
            //   {
            //      "error-code": "NOT_FOUND",
            //      "position": 0
            //   }
            // ]
            Assert.That(() => Client.RemoveFromBatch(123),
                Throws.TypeOf<OtpravkaException>()
                    .With.Message.Contains("Не найден")); // error object doesn't have a readable message and falls back to DisplayName
        }

        [Test, Ordered]
        public void DeleteOrder()
        {
            Assert.That(CreatedOrderID, Is.Not.EqualTo(0));
            var result = Client.DeleteOrders(CreatedOrderID);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ResultIDs, Is.Not.Null.And.Not.Empty);
            Assert.That(result.ResultIDs.First(), Is.EqualTo(CreatedOrderID));
        }

        [Test, Ordered]
        public void CreateMultipleOrdersAsMmo()
        {
            var mailType = MailType.OnlineCourier;
            var order = new Order
            {
                AddToMmo = true,
                OrderNum = "002",
                GroupName = "002",
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
                RawAddress = "117105, Москва, Варшавское шоссе, 37",
                TelAddressFrom = 79871234567,
                TelAddress = 79871234567,
                DeclaredValue = 1000,
                TransportType = Otpravka.TransportType.Surface,
                MailCategory = MailCategory.WithDeclaredValue,
                MailCountryCode = OksmCountryCode.Russia,
                MailType = mailType,
                Mass = 500,
                //Dimensions = new Dimensions
                //{
                //    Height = 10,
                //    Length = 10,
                //    Width = 10,
                //},
            };

            var orders = Enumerable.Repeat(order, 3).ToArray();
            var result = Client.CreateOrders(orders);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ResultIDs, Is.Not.Null.And.Not.Empty);

            CreatedOrders = result.ResultIDs;
            CreatedOrderBarcodes = result.Orders.Select(o => o.Barcode).ToArray();

            TestContext.Progress.WriteLine($"Created orders: {string.Join(", ", CreatedOrders)}");
            TestContext.Progress.WriteLine($"Order barcodes: {string.Join(", ", CreatedOrderBarcodes)}");
        }

        private long[] CreatedOrders { get; set; } = new long[] { 920047016, 920047017, 920047018, };

        private string[] CreatedOrderBarcodes { get; set; } = new[] { "80092578900475", "80092578900482", "80092578900499", };

        [Test, Ordered]
        public void SearchOrders()
        {
            var orders = Client.SearchOrders("002");
            Assert.That(orders, Is.Not.Null.And.Not.Empty);

            var order = orders.First();
            Assert.That(order, Is.Not.Null);
            Assert.That(order.OrderNum, Is.EqualTo("002"));
        }

        [Test, Ordered]
        public void SearchForOrdersByGroupName()
        {
            var orders = Client.SearchOrdersByGroupName("002");
            Assert.That(orders, Is.Not.Null.And.Not.Empty);

            var order = orders.First();
            Assert.That(order, Is.Not.Null);
            Assert.That(order.GroupName, Is.EqualTo("002"));
        }

        [Test, Ordered]
        public void CreateBatch()
        {
            Assert.That(CreatedOrders, Is.Not.Null.And.Not.Empty);

            var response = Client.CreateBatch(CreatedOrders);
            Assert.That(response, Is.Not.Null);
            Assert.That(response.Batches, Is.Not.Null.And.Not.Empty);
            Assert.That(response.ResultIDs, Is.Not.Null.And.Not.Empty);
            Assert.That(response.ResultIDs.Sum(), Is.EqualTo(CreatedOrders.Sum()));

            var batch = response.Batches.Single();
            Assert.That(batch.BatchName, Is.Not.Null.And.Not.Empty);
            Assert.That(batch.BatchStatus, Is.EqualTo(BatchStatus.Created));
            Assert.That(batch.MailCategory, Is.EqualTo(MailCategory.Combined));
            Assert.That(batch.MailType, Is.EqualTo(MailType.Combined));

            CreatedBatchName = batch.BatchName;
            TestContext.Progress.WriteLine($"Created a batch: {CreatedBatchName}");
        }

        private string CreatedBatchName { get; set; } = "134";

        [Test, Ordered]
        public void GetBatchByName()
        {
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);

            var response = Client.GetBatch(CreatedBatchName);
            Assert.That(response, Is.Not.Null);
            Assert.That(response.BatchName, Is.EqualTo(CreatedBatchName));
        }

        [Test, Ordered]
        public void GetBatchOrder()
        {
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);
            Assert.That(CreatedOrders, Is.Not.Null.And.Not.Empty);

            var order = Client.GetBatchOrder(CreatedOrders.First());
            Assert.That(order, Is.Not.Null);
            Assert.That(order.ID, Is.EqualTo(CreatedOrders.First()));
        }

        [Test, Ordered]
        public void SearchBatchOrders()
        {
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);
            Assert.That(CreatedOrderBarcodes, Is.Not.Null.And.Not.Empty);

            var orders = Client.SearchBatchOrders(CreatedOrderBarcodes.First());
            Assert.That(orders, Is.Not.Null.And.Not.Empty);

            var order = orders.First();
            Assert.That(order.Barcode, Is.EqualTo(CreatedOrderBarcodes.First()));
        }

        [Test, Ordered]
        public void SearchBatchOrdersByGroupName()
        {
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);
            Assert.That(CreatedOrderBarcodes, Is.Not.Null.And.Not.Empty);

            var orders = Client.SearchBatchOrdersByGroupName("002");
            Assert.That(orders, Is.Not.Null.And.Not.Empty);

            var firstOrderId = CreatedOrders.First();
            var order = orders.First(o => o.ID == firstOrderId);
            Assert.That(order.GroupName, Is.EqualTo("002"));
        }

        [Test, Ordered]
        public void FindAllBatches()
        {
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);

            var batches = Client.SearchBatches();
            Assert.That(batches, Is.Not.Null.And.Not.Empty);

            var batch = batches.FirstOrDefault(b => b.BatchName == CreatedBatchName);
            Assert.That(batch, Is.Not.Null);
            Assert.That(batch.BatchName, Is.EqualTo(CreatedBatchName));

            batches = Client.SearchBatches(MailType.Ems, MailCategory.Ordinary);
            Assert.That(batches, Is.Not.Null.And.Empty);
        }

        [Test, Ordered]
        public void ChangeBatchDate()
        {
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);

            var response = Client.ChangeBatchDate(CreatedBatchName, DateTime.Today.AddDays(3));
            Assert.That(response, Is.Not.Null);
            Assert.That(response.ErrorCode, Is.Null);
            Assert.That(response.F103Sent, Is.False);
        }

        [Test]
        public void CheckinBatchFails()
        {
            // this batch doesn't exist
            Assert.That(() => Client.CheckinBatch("000", true),
                Throws.TypeOf<OtpravkaException>().With.Message.EqualTo("Instance ShipmentBatchTuple not found for params: 000"));
        }

        [Test, Ordered]
        public void AddExistingOrdersToTheBatch()
        {
            // make sure that batch exists
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);

            // create a new order to add to the batch
            var order = Client.CreateOrders(CreateTestOrder("002", "0032"));

            // add it to existing batch
            var result = Client.AddToBatch(CreatedBatchName, order.ResultIDs);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ResultIDs, Is.Not.Null.And.Not.Empty);

            // create a new order to add to the batch
            order = Client.CreateOrders(CreateTestOrder("003", "0033"));

            // add it to existing batch with group-name "0032" — throws GROUP_NOT_FOUND for some reason
            result = Client.AddToBatch(CreatedBatchName, order.ResultIDs);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ResultIDs, Is.Not.Null.And.Not.Empty);

            // adding the same order again throws an exception with no readable description
            Assert.That(() => Client.AddToBatch(CreatedBatchName, "0032", order.ResultIDs),
                Throws.TypeOf<OtpravkaException>().With.Message.EqualTo("null"));
        }

        [Test, Ordered]
        public void AddNewOrdersToTheBatch()
        {
            // make sure that batch exists
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);

            // create a few orders to add to the batch
            var orders = new[] { CreateTestOrder("003"), CreateTestOrder("004") };

            // add it to existing batch
            var result = Client.AddToBatch(CreatedBatchName, orders);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ResultIDs, Is.Not.Null.And.Not.Empty);
        }

        [Test, Ordered]
        public void GetBatchOrders()
        {
            // make sure that batch exists
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);

            // get the current orders from the batch
            var orders = Client.GetBatchOrders(CreatedBatchName);
            Assert.That(orders, Is.Not.Null.And.Not.Empty);

            // paged request
            orders = Client.GetBatchOrders(new BatchOrdersRequest(CreatedBatchName)
            {
                Size = 3,
                Page = 1,
            });

            // invalid batch name/number throws an exception
            Assert.That(() => Client.GetBatchOrders(new BatchOrdersRequest("bad")),
                Throws.TypeOf<OtpravkaException>()
                    .With.Message.Contains("Instance ShipmentBatchTuple not found for params: bad"));
        }

        [Test, Ordered, Explicit("Don't bother pochta.ru employees with fake F103 registration forms")]
        public void CheckinBatchSucceeds()
        {
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);

            // Got this error when useOnlineBalance=true:
            // body: {
            //   "code": "1024",
            //   "desc": "Ошибка в сервисе. Код ошибки: EXTERNAL_SYSTEMS, вспомогательный код: UNDEFINED, описание: 'UNDEFINED->UNDEFINED. Requested 82674 but available 0'"
            // }
            // It means that the delivery costs 826.74 rub, but the current balance is 0.
            // Go this error when useOnlineBalance=false:
            // body: {
            //   "error-code": "OFFLINE_BALANCE_FORBIDDEN",
            //   "f103-sent": false
            // }
            var response = Client.CheckinBatch(CreatedBatchName, true);
            Assert.That(response, Is.Not.Null);
            Assert.That(response.ErrorCode, Is.Null);
            Assert.That(response.F103Sent, Is.True);
        }

        [Test, Ordered, Explicit("This method works for checked-in batches")]
        public void DownloadBatchDocuments()
        {
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);

            var zipFile = Client.DownloadBatchDocuments(CreatedBatchName, false, false);
            Assert.That(zipFile, Is.Not.Null.And.Not.Empty);
        }

        [Test, Ordered]
        public void ArchiveBatches()
        {
            // make sure that batch exists
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);

            // archive created batch
            var result = Client.ArchiveBatches(CreatedBatchName);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
            Assert.That(result, Has.Length.EqualTo(1));

            // make sure it's archived
            var batch = result.First();
            Assert.That(batch, Is.Not.Null);
            Assert.That(batch.BatchName, Is.EqualTo(CreatedBatchName));
        }

        [Test, Ordered]
        public void GetArchivedBatches()
        {
            // make sure that batch exists
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);

            // get the current archived batches
            var result = Client.GetArchivedBatches();
            Assert.That(result, Is.Not.Null.And.Not.Empty);
            Assert.That(result, Has.Length.GreaterThanOrEqualTo(1));

            // verify that our last batch is there
            var batch = result.FirstOrDefault(b => b.BatchName == CreatedBatchName);
            Assert.That(batch, Is.Not.Null);
            Assert.That(batch.BatchName, Is.EqualTo(CreatedBatchName));
        }

        [Test, Ordered]
        public void UnarchiveBatches()
        {
            // make sure that batch exists
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);

            // remove the last created batch from archive
            var result = Client.UnarchiveBatches(CreatedBatchName);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
            Assert.That(result, Has.Length.EqualTo(1));

            // verify that the batch is returned
            var batch = result.First();
            Assert.That(batch, Is.Not.Null);
            Assert.That(batch.BatchName, Is.EqualTo(CreatedBatchName));
        }

        [Test]
        public void CreateOrderAndBatchWithShippingDateThenDeleteOrderAndBatch()
        {
            var orders = Client.CreateOrders(CreateTestOrder());
            Assert.That(orders.ResultIDs, Is.Not.Null.And.Not.Empty);

            // проверяем создание партии заказов с указанной датой передачи в отделение
            var batch = Client.CreateBatch(new BatchRequest
            {
                OrderIDs = orders.ResultIDs,
                SendingDate = DateTime.Today.AddDays(1),
            });

            Assert.That(batch.Batches, Is.Not.Null.And.Not.Empty);
            Client.DeleteFromBatch(orders.ResultIDs);
        }

        [Test]
        public void HandleErrorProperlyWhenUrlIsMalformed()
        {
            void error(string query) =>
                Client.Get<OrderInfo[]>("1.0/long-term-archive/shipment", r => r
                    .AddQueryParameter("query", query));

            Assert.That(() => error("123"),
                Throws.TypeOf<OtpravkaException>()
                    .With.Message.EqualTo("Error namespace or mask or method not found").And
                        .With.Property(nameof(OtpravkaException.StatusCode))
                            .EqualTo((HttpStatusCode)407));
        }

        [Test]
        public void SearchArchivedOrders()
        {
            Assert.That(Client.SearchArchivedOrders("856055"), Is.Not.Null);
        }

        [Test, Ordered]
        public void GetPrintFormF7P()
        {
            // make sure that created orders list is not empty
            Assert.That(CreatedOrders, Is.Not.Null.And.Not.Empty);

            // заказ должен быть внутри партии
            var result = Client.GetPrintFormF7P(CreatedOrders.First());
            Assert.That(result, Is.Not.Null.And.Not.Empty);
            ValidatePdfSignature(result);
        }

        [Test, Ordered, Ignore("Работает только для заказов с наложенным платежом")]
        public void GetPrintFormF112EK()
        {
            // make sure that created orders list is not empty
            Assert.That(CreatedOrders, Is.Not.Null.And.Not.Empty);

            // заказ должен быть внутри партии
            var result = Client.GetPrintFormF112EK(CreatedOrders.First());
            Assert.That(result, Is.Not.Null.And.Not.Empty);
            ValidatePdfSignature(result);
        }

        [Test, Ordered, Ignore(@"Returns internal error 1002: Forbidden mail type")]
        public void GetPrintForms()
        {
            // make sure that created orders list is not empty
            Assert.That(CreatedOrderID, Is.Not.EqualTo(0));

            // заказ не должен быть внутри партии
            var result = Client.GetPrintForms(CreatedOrderID); // .First());
            Assert.That(result, Is.Not.Null.And.Not.Empty);
            ValidatePdfSignature(result);
        }

        private void ValidatePdfSignature(byte[] pdf)
        {
            // убедимся, что это PDF-файл
            var signature = Encoding.UTF8.GetString(pdf.Take(8).ToArray());
            Assert.That(signature, Does.StartWith("%PDF-"));
        }

        [Test, Ordered]
        public void RemoveOrdersFromBatch()
        {
            // make sure that created orders list is not empty
            Assert.That(CreatedOrders, Is.Not.Null.And.Not.Empty);

            // return orders from shipping to backlog
            var result = Client.RemoveFromBatch(CreatedOrders);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ResultIDs, Is.Not.Null.And.Not.Empty);
            Assert.That(result.ResultIDs.Sum(), Is.EqualTo(CreatedOrders.Sum()));
        }

        [Test, Ordered]
        public void DeleteOrdersFromBatch()
        {
            // make sure that created batch exists
            Assert.That(CreatedBatchName, Is.Not.Null.And.Not.Empty);
            var orders = Client.GetBatchOrders(CreatedBatchName);
            Assert.That(orders, Is.Not.Null.And.Not.Empty);

            // delete remaining orders from the batch
            var orderIds = orders.Select(o => o.ID).ToArray();
            var result = Client.DeleteFromBatch(orderIds);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ResultIDs, Is.Not.Null.And.Not.Empty);
            Assert.That(result.ResultIDs.Sum(), Is.EqualTo(orderIds.Sum()));
        }

        [Test, Ordered]
        public void DeleteCreatedOrders()
        {
            Assert.That(CreatedOrders, Is.Not.Null.And.Not.Empty);
            var result = Client.DeleteOrders(CreatedOrders);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.ResultIDs, Is.Not.Null.And.Not.Empty);
            Assert.That(result.ResultIDs.Sum(), Is.EqualTo(CreatedOrders.Sum()));
        }

        [Test]
        public void GetPostOfficeByPostCode()
        {
            var result = Client.GetPostOffice("125047");
            Assert.That(result, Is.Not.Null);
            Assert.That(result.PostalCode, Is.EqualTo("125047"));
            Assert.That(result.AddressSource, Is.Not.Null.And.Not.Empty);
            Assert.That(result.ServiceGroups, Is.Not.Null.And.Not.Empty);
            Assert.That(result.WorkingHours, Is.Not.Null.And.Not.Empty);
            Assert.That(result.WorksOnSaturdays, Is.True);
            Assert.That(result.WorksOnSundays, Is.False);
            Assert.That(result.TypeCode, Is.EqualTo("ГОПС"));
            Assert.That(result.TypeID, Is.EqualTo(8));

            result = Client.GetPostOffice(new PostOfficeByCode { PostalCode = "196070" });
            Assert.That(result, Is.Not.Null);
            Assert.That(result.PostalCode, Is.EqualTo("196070"));
            Assert.That(result.AddressSource, Is.Not.Null.And.Not.Empty);
            Assert.That(result.ServiceGroups, Is.Not.Null.And.Not.Empty);
            Assert.That(result.WorkingHours, Is.Not.Null.And.Not.Empty);
            Assert.That(result.WorksOnSaturdays, Is.True.Or.False);
            Assert.That(result.WorksOnSundays, Is.True.Or.False);
            Assert.That(result.TypeCode, Is.EqualTo("ГОПС"));
            Assert.That(result.TypeID, Is.EqualTo(8));

            // это почтомат, по его индексу можно получить детальную информацию
            result = Client.GetPostOffice("912471");
            Assert.That(result, Is.Not.Null);
            Assert.That(result.PostalCode, Is.EqualTo("912471"));
            Assert.That(result.AddressSource, Is.Not.Null.And.Not.Empty);
            Assert.That(result.ServiceGroups, Is.Not.Null.And.Not.Empty);
            Assert.That(result.WorkingHours, Is.Not.Null.And.Not.Empty);
            Assert.That(result.WorksOnSaturdays, Is.True);
            Assert.That(result.WorksOnSundays, Is.True);
            Assert.That(result.TypeCode, Is.EqualTo("ПОЧТОМАТ"));
            Assert.That(result.TypeID, Is.EqualTo(33));
        }

        [Test]
        public void GetPostOfficeServiceGroupsByPostCode()
        {
            // в отделениях предоставляется целая куча услуг
            var result = Client.GetPostOfficeServices("125047");
            Assert.That(result, Is.Not.Null.And.Not.Empty);
            var service = result.FirstOrDefault(s => s.Code == "1010700");
            Assert.That(service, Is.Not.Null);
            Assert.That(service.Name, Is.Not.Null.And.Not.Empty);

            result = Client.GetPostOfficeServices("196070");
            Assert.That(result, Is.Not.Null.And.Not.Empty);
            service = result.FirstOrDefault(s => s.Code == "3060100");
            Assert.That(service, Is.Not.Null);
            Assert.That(service.Name, Is.Not.Null.And.Not.Empty);

            // почтомат никаких услуг не предоставляет
            result = Client.GetPostOfficeServices("912471");
            Assert.That(result, Is.Not.Null.And.Empty);
        }

        [Test]
        public void GetPostOfficeServiceGroupsByPostCodeAndGroupCode()
        {
            // в отделениях предоставляется целая куча услуг
            var result = Client.GetPostOfficeServices("125047", 2259);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
            var service = result.FirstOrDefault(s => s.Code == "2010400");
            Assert.That(service, Is.Not.Null);
            Assert.That(service.Name, Is.Not.Null.And.Not.Empty);

            result = Client.GetPostOfficeServices("196070", 2315);
            Assert.That(result, Is.Not.Null.And.Not.Empty);
            service = result.FirstOrDefault(s => s.Code == "3060400");
            Assert.That(service, Is.Not.Null);
            Assert.That(service.Name, Is.Not.Null.And.Not.Empty);

            // почтомат никаких услуг не предоставляет
            result = Client.GetPostOfficeServices("912471", 2101);
            Assert.That(result, Is.Not.Null.And.Empty);
        }

        [Test]
        public void SearchPostOfficesByAddress()
        {
            var result = Client.SearchPostOffices("Москва, Тверская-Ямская, 1");
            Assert.That(result, Is.Not.Null);
            Assert.That(result.IsMatched, Is.False);
            Assert.That(result.PostOffices, Is.Not.Null.And.Not.Empty);

            result = Client.SearchPostOffices("г Москва, ш Волоколамское, дом 92 к. 2");
            Assert.That(result, Is.Not.Null);
            Assert.That(result.IsMatched, Is.False);
            Assert.That(result.PostOffices, Is.Not.Null.And.Not.Empty);

            result = Client.SearchPostOffices("Санкт-Петербург, улица Победы, 15к1");
            Assert.That(result, Is.Not.Null);
            Assert.That(result.IsMatched, Is.False);
            Assert.That(result.PostOffices, Is.Not.Null.And.Not.Empty);

            // по этому адресу расположен почтомат, но он не находится,
            // а находится ближайшее почтовое отделение
            result = Client.SearchPostOffices("Москва, Волоколамский пр-д, 4, к.3", top: 10);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.IsMatched, Is.False);
            Assert.That(result.PostOffices, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void SearchPostOfficesByLocation()
        {
            // по этим координатам расположен почтомат, он находится в первую очередь
            // кроме того, находятся ближайшие почтовые отделения и пункты выдачи заказов
            var result = Client.SearchPostOffices(55.825927m, 37.434163m, radius: 0.5m);
            Assert.That(result, Is.Not.Null.And.Not.Empty);

            // эти данные часто обновляются, нельзя на них полагаться
            // оставляю здесь для примера, как они выглядят
            //var office = result.FirstOrDefault(po => po.PostalCode == "912471");
            //Assert.That(office, Is.Not.Null);
            //Assert.That(office.AddressSource, Is.EqualTo("Волоколамский пр-д, 4, к.3"));
            //Assert.That(office.TypeCode, Is.EqualTo("ПОЧТОМАТ"));
            //Assert.That(office.TypeID, Is.EqualTo(33));

            //office = result.FirstOrDefault(po => po.PostalCode == "125424");
            //Assert.That(office, Is.Not.Null);
            //Assert.That(office.AddressSource, Is.EqualTo("Волоколамское ш, 92, к.2"));
            //Assert.That(office.TypeCode, Is.EqualTo("ГОПС"));
            //Assert.That(office.TypeID, Is.EqualTo(8));

            //office = result.FirstOrDefault(po => po.PostalCode == "966446");
            //Assert.That(office, Is.Not.Null);
            //Assert.That(office.AddressSource, Is.EqualTo("Волоколамское ш, 94"));
            //Assert.That(office.TypeCode, Is.EqualTo("ПВЗ"));
            //Assert.That(office.TypeID, Is.EqualTo(37));
        }

        [Test]
        public void SearchPostOfficesByLocationRequest()
        {
            // по этим координатам расположен пвз, он находится в первую очередь
            // кроме того, находятся ближайшие почтовые отделения и пункты выдачи заказов
            var result = Client.SearchPostOffices(new PostOfficeByLocation
            {
                Latitude = 55.827398m,
                Longitude = 37.435053m,
                SearchRadius = 0.5m,
                Top = 10,
            });

            Assert.That(result, Is.Not.Null.And.Not.Empty);

            // эти данные часто обновляются, нельзя на них полагаться
            // оставляю здесь для примера, как они выглядят
            //var office = result.FirstOrDefault(po => po.PostalCode == "911713");
            //Assert.That(office, Is.Not.Null);
            //Assert.That(office.AddressSource, Is.EqualTo("Стратонавтов пр-д, 11, стр.1"));
            //Assert.That(office.TypeCode, Is.EqualTo("ПВЗ"));
            //Assert.That(office.TypeID, Is.EqualTo(37));

            //office = result.FirstOrDefault(po => po.PostalCode == "125424");
            //Assert.That(office, Is.Not.Null);
            //Assert.That(office.AddressSource, Is.EqualTo("Волоколамское ш, 92, к.2"));
            //Assert.That(office.TypeCode, Is.EqualTo("ГОПС"));
            //Assert.That(office.TypeID, Is.EqualTo(8));

            //office = result.FirstOrDefault(po => po.PostalCode == "966446");
            //Assert.That(office, Is.Not.Null);
            //Assert.That(office.AddressSource, Is.EqualTo("Волоколамское ш, 94"));
            //Assert.That(office.TypeCode, Is.EqualTo("ПВЗ"));
            //Assert.That(office.TypeID, Is.EqualTo(37));
        }

        [Test]
        public void SearchPostOfficeByPostCodeThenByLocation()
        {
            var postOffice = Client.GetPostOffice("125424");
            var nearestOffices = Client.SearchPostOffices(new PostOfficeByLocation
            {
                Latitude = postOffice.Latitude,
                Longitude = postOffice.Longitude,
                FilterByOfficeType = true,
                Top = 20,
            });

            Assert.That(nearestOffices, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void SearchPostOfficesByRegion()
        {
            var result = Client.SearchPostOffices(new PostOfficeByRegion
            {
                Settlement = "Краснодар",
            });

            Assert.That(result, Is.Not.Null.And.Not.Empty);
            Assert.That(result, Does.Contain("350000"));
            Assert.That(result, Does.Contain("350053"));

            result = Client.SearchPostOffices(new PostOfficeByRegion
            {
                Settlement = "Пластуновская",
            });

            Assert.That(result, Is.Not.Null.And.Not.Empty);
            Assert.That(result, Does.Contain("353206"));

            result = Client.SearchPostOffices(new PostOfficeByRegion
            {
                District = "Тверская область",
                Settlement = "Москва",
            });

            Assert.That(result, Is.Not.Null.And.Not.Empty);
            Assert.That(result, Does.Contain("125009"));
            Assert.That(result, Does.Contain("125047"));
        }

        [Test, Explicit("No need to download a few megabytes of data on every test run")]
        [TestCase(PostOfficeType.Postamat)]
        [TestCase(PostOfficeType.PickupPoint)]
        [TestCase(PostOfficeType.PostOffice)]
        [TestCase(PostOfficeType.All)]
        public void DownloadPostOfficesArchive(PostOfficeType type)
        {
            using (var fileStream = File.Create($"PochtaSdk-temp-PostOffices-{type}.zip"))
            using (var writer = new BinaryWriter(fileStream))
            {
                var bytes = Client.DownloadPostOffices(type);
                writer.Write(bytes);
                writer.Flush();
                Assert.That(bytes, Has.Length.GreaterThan(0));

                TestContext.Progress.WriteLine("Wrote file: {0}", fileStream.Name);
                TestContext.Progress.WriteLine("Size: {0} bytes", fileStream.Length);
            }
        }

        [Test]
        [TestCase(MailType.OnlineParcel, MailCategory.WithDeclaredValue, true, null)] // до двери
        [TestCase(MailType.ParcelClass1, MailCategory.WithDeclaredValue, true, null)] // до двери
        [TestCase(MailType.Ems, MailCategory.WithDeclaredValue, true, null)] // до двери
        [TestCase(MailType.OnlineParcel, MailCategory.CombinedWithDeclaredValue, false, "915698")] // до местного почтомата
        [TestCase(MailType.OnlineParcel, MailCategory.CombinedWithDeclaredValue, false, "914289")] // до Московского почтомата
        [TestCase(MailType.OnlineParcel, MailCategory.CombinedWithDeclaredValue, false, "920178")] // до Московского почтомата
        public void CalculateShipping(MailType mt, MailCategory mc, bool courier, string dpc)
        {
            var result = Client.CalculateShipping(new ShippingRateRequest
            {
                MailCategory = mc,
                MailType = mt,
                Courier = courier,
                PostCodeFrom = "117042", // "115407" — не работает, тк не указан в профиле
                PostCodeTo = "301264", // "117545", // "301264",
                DeliveryPointPostCode = dpc,
                DimensionType = DimensionType.Small,
                DeclaredValue = 10000,
                Mass = 1000,
                TransportType = TransportType.Standard,
                PaymentMethod = PaymentMethod.Cashless,
                NoticePaymentMethod = PaymentMethod.Cashless,
            });

            Assert.That(result, Is.Not.Null);
            Assert.That(result.TotalRate, Is.GreaterThan(100));
        }

        [Test]
        public void CalculateShippingToPostamat()
        {
            /*
            body: {
              "completeness-checking": false,
              "contents-checking": false,
              "courier": false,
              "declared-value": 10000,
              "delivery-point-index": "301264",
              "dimension": null,
              "dimension-type": "S",
              "entries-type": "GIFT",
              "fragile": false,
              "index-from": "117042",
              "index-to": "301264",
              "inventory": false,
              "mail-category": "COMBINED_WITH_DECLARED_VALUE",
              "mail-direct": 643,
              "mail-type": "ONLINE_PARCEL",
              "mass": 12050,
              "notice-payment-method": "CASHLESS",
              "payment-method": "CASHLESS",
              "sms-notice-recipient": 0,
              "transport-type": "STANDARD",
              "vsd": false,
              "with-electronic-notice": false,
              "with-order-of-notice": false,
              "with-simple-notice": false
            }

            body: {
              "completeness-checking": false,
              "contents-checking": false,
              "courier": false,
              "declared-value": 10000,
              "delivery-point-index": "912521",
              "dimension": null,
              "dimension-type": "S",
              "entries-type": "GIFT",
              "fragile": false,
              "index-from": "117042",
              "index-to": "115551",
              "inventory": false,
              "mail-category": "COMBINED_WITH_DECLARED_VALUE",
              "mail-direct": 643,
              "mail-type": "ONLINE_PARCEL",
              "mass": 12050,
              "notice-payment-method": "CASHLESS",
              "payment-method": "CASHLESS",
              "sms-notice-recipient": 0,
              "transport-type": "STANDARD",
              "vsd": false,
              "with-electronic-notice": false,
              "with-order-of-notice": false,
              "with-simple-notice": false
            }
             */

            var result = Client.CalculateShipping(new ShippingRateRequest
            {
                MailCategory = MailCategory.CombinedWithDeclaredValue,
                MailType = MailType.OnlineParcel,
                Courier = false,
                PostCodeFrom = "117042",
                PostCodeTo = "912521", // null, // "301264", // "301264, Тульская область, Липки, ул. Мира"
                DeliveryPointPostCode = "920178", // "912521" — не работает, // "920178" - работает, // "976367" и "301264" — не работает, пишет: почтовый индекс не указан
                DimensionType = DimensionType.Small,
                DeclaredValue = 10000,
                Mass = 5000,
                TransportType = TransportType.Standard,
                PaymentMethod = PaymentMethod.Cashless,
                NoticePaymentMethod = PaymentMethod.Cashless,
            });

            Assert.That(result, Is.Not.Null);
            Assert.That(result.TotalRate, Is.GreaterThan(100));
        }

        [Test]
        public void CalculateShippingReturnsTheSameAmountAsTariffClient()
        {
            var result = Client.CalculateShipping(new ShippingRateRequest
            {
                MailCategory = MailCategory.Simple,
                MailType = MailType.Letter,
                Courier = false,
                PostCodeFrom = "353206",
                PostCodeTo = "344038",
                DeclaredValue = 10000,
                Mass = 100,
                PaymentMethod = PaymentMethod.Stamp,
                TransportType = TransportType.Standard,
            });

            Assert.That(result, Is.Not.Null);
            Assert.That(result.TotalRate, Is.GreaterThan(0));

            // verify the results using alternative API
            var tariffClient = new TariffClient
            {
                Tracer = TestContext.Progress.WriteLine
            };

            var altResult = tariffClient.Calculate(new Tariff.TariffRequest
            {
                ObjectType = Tariff.ObjectType.LetterRegular,
                FromPostCode = 353206,
                ToPostCode = 344038,
                SumOc = 10000,
                Weight = 100,
            });

            Assert.That(altResult, Is.Not.Null);
            Assert.That(altResult.GroundAmount.Value, Is.EqualTo(result.GroundRate.Rate));
        }

        [Test]
        public void CalculateShippingTariffSucceeds()
        {
            var result = Client.CalculateShippingTariff(new ShippingRateRequest
            {
                MailCategory = MailCategory.CombinedWithDeclaredValue,
                MailType = MailType.OnlineParcel,
                Courier = false,
                PostCodeFrom = "117042",
                PostCodeTo = "912521",
                DeliveryPointPostCode = "920178",
                DimensionType = DimensionType.Small,
                DeclaredValue = 10000,
                Mass = 5000,
                TransportType = TransportType.Standard,
                PaymentMethod = PaymentMethod.Cashless,
                NoticePaymentMethod = PaymentMethod.Cashless,
            });

            Assert.That(result, Is.Not.Null);
            Assert.That(result.TotalRate, Is.GreaterThan(100));

            // обычный CalculateShipping сроки доставки не вернет
            Assert.That(result.DeliveryTime, Is.Not.Null);
            Assert.That(result.DeliveryTime.MinDays, Is.GreaterThan(0));
            Assert.That(result.DeliveryTime.MaxDays, Is.GreaterThan(0));
        }

        [Test]
        public void CalculateShippingTariffFails()
        {
            var req = new ShippingRateRequest
            {
                MailCategory = MailCategory.WithDeclaredValue,
                MailType = MailType.ParcelClass1,
                Courier = false,
                PostCodeFrom = "117042",
                PostCodeTo = "912521",
                DeliveryPointPostCode = "920178",
                DimensionType = DimensionType.Small,
                DeclaredValue = 10000,
                Mass = 5000,
                TransportType = TransportType.Standard,
                PaymentMethod = PaymentMethod.Cashless,
                NoticePaymentMethod = PaymentMethod.Cashless,
            };

            // обычный расчет тарифа сообщает просто: ошибка
            Assert.That(() => Client.CalculateShipping(req),
                Throws.TypeOf<OtpravkaException>().With
                    .Message.EqualTo("Ошибка при расчете тарифа"));

            // расчет через тарификатор сообщает, в чем конкретно ошибка
            Assert.That(() => Client.CalculateShippingTariff(req),
                Throws.TypeOf<OtpravkaException>().With
                    .Message.Contains("нельзя доставить в почтомат"));
        }

        [Test]
        public void GetUserShippingPoints()
        {
            var points = Client.GetShippingPoints();
            Assert.That(points, Is.Not.Null.And.Not.Empty);
            Assert.That(points.All(p => !string.IsNullOrWhiteSpace(p.OperatorPostCode)), Is.True);
            Assert.That(points.Any(p => p.Enabled), Is.True);
        }
    }
}
