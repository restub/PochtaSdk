using System;
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
            var orderJson = "{\"address-type-to\":\"DEFAULT\",\"house-to\"" +
                ":\"1\",\"index-to\":117463,\"place-to\":\"Москва\",\"regi" +
                "on-to\":\"Москва\",\"street-to\":\"Ул. Паустовского\",\"g" +
                "iven-name\":\"Иван\",\"mail-category\":\"ORDINARY\",\"mai" +
                "l-direct\":643,\"mail-type\":\"POSTAL_PARCEL\",\"mass\":1" +
                "234,\"middle-name\":\"Иванович\",\"order-num\":\"тест 111" +
                "\",\"postoffice-code\":\"109012\",\"surname\":\"Иванов\"}";

            var order = Serializer.Deserialize<Order>(orderJson);
            Assert.That(order, Is.Not.Null);
            Assert.That(order.GivenName, Is.EqualTo("Иван"));

            var json = Serializer.Serialize(order);
            Assert.That(json, Is.Not.Null.Or.Empty);
            Assert.That(json, Is.EqualTo(orderJson));
        }

        [Test]
        public void DeserializePostOfficePassportSnapshotJson()
        {
            var passport = "{\n\t\"passportElements\": [{\n\t\t\"address\": {\n\t\t\t\"addressType\": " +
                "\"DEFAULT\",\n\t\t\t\"area\": \"р-н Духовщинский\",\n\t\t\t\"house\": \"7\",\n\t\t\t\"" +
                "index\": \"216236\",\n\t\t\t\"manualInput\": false,\n\t\t\t\"place\": \"д Добрино\",\n" +
                "\t\t\t\"region\": \"обл Смоленская\",\n\t\t\t\"street\": \"ул Пляжная\"\n\t\t},\n\t\t" +
                "\"addressFias\": {\n\t\t\t\"addGarCode\": \"8ea67508-ed85-4fea-98db-94f1af8b6cf0\",\n" +
                "\t\t\t\"ads\": \"216236 обл Смоленская Добрино д Пляжная ул, д. 7\",\n\t\t\t\"location" +
                "GarCode\": \"ab05c581-db7d-4546-899f-9de485274b3f\",\n\t\t\t\"regGarId\": \"e8502180-" +
                "6d08-431b-83ea-c7038f0df905\"\n\t\t},\n\t\t\"ecom\": \"1\",\n\t\t\"ecomOptions\": {\n" +
                "\t\t\t\"cardPayment\": false,\n\t\t\t\"cashPayment\": false,\n\t\t\t\"contentsChecking" +
                "\": false,\n\t\t\t\"functionalityChecking\": false,\n\t\t\t\"partialRedemption\": false" +
                ",\n\t\t\t\"returnAvailable\": false,\n\t\t\t\"weightLimit\": 0.0,\n\t\t\t\"withFitting" +
                "\": false\n\t\t},\n\t\t\"holidays\": [{\n\t\t\t\"df\": \"2022-11-03\",\n\t\t\t\"ds\": " +
                "\"2022-11-03\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-11-03\",\n\t\t\t\t\"fn\": " +
                "\"14:30\",\n\t\t\t\t\"nm\": 4,\n\t\t\t\t\"rst\": [{\n\t\t\t\t\t\"fn\": \"13:00\",\n\t" +
                "\t\t\t\t\"st\": \"12:00\"\n\t\t\t\t}],\n\t\t\t\t\"st\": \"09:00\"\n\t\t\t}]\n\t\t}, {" +
                "\n\t\t\t\"df\": \"2022-11-04\",\n\t\t\t\"ds\": \"2022-11-04\",\n\t\t\t\"work\": [{\n" +
                "\t\t\t\t\"dt\": \"2022-11-04\",\n\t\t\t\t\"nm\": 5\n\t\t\t}]\n\t\t}, {\n\t\t\t\"df\": " +
                "\"2022-12-31\",\n\t\t\t\"ds\": \"2022-12-31\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": " +
                "\"2022-12-31\",\n\t\t\t\t\"fn\": \"14:30\",\n\t\t\t\t\"nm\": 6,\n\t\t\t\t\"rst\": [{" +
                "\n\t\t\t\t\t\"fn\": \"13:00\",\n\t\t\t\t\t\"st\": \"12:00\"\n\t\t\t\t}],\n\t\t\t\t\"st" +
                "\": \"09:00\"\n\t\t\t}]\n\t\t}],\n\t\t\"latitude\": \"55.612752\",\n\t\t\"longitude\"" +
                ": \"32.433259\",\n\t\t\"onlineParcel\": \"0\",\n\t\t\"type\": \"СОПС\",\n\t\t\"workTime" +
                "\": [\"пн, выходной\", \"вт, открыто: 09:00 - 15:30, перерыв: 12:00 - 13:00\", \"ср, " +
                "выходной\", \"чт, открыто: 09:00 - 15:30, перерыв: 12:00 - 13:00\", \"пт, выходной\"" +
                ", \"сб, открыто: 09:00 - 15:30, перерыв: 12:00 - 13:00\", \"вс, выходной\"]\n\t}, {" +
                "\n\t\t\"address\": {\n\t\t\t\"addressType\": \"DEFAULT\",\n\t\t\t\"area\": \"у Усть-" +
                "Алданский\",\n\t\t\t\"corpus\": \"1\",\n\t\t\t\"house\": \"7\",\n\t\t\t\"index\": \"" +
                "678373\",\n\t\t\t\"manualInput\": false,\n\t\t\t\"place\": \"с Бейдинга\",\n\t\t\t\"" +
                "region\": \"Респ Саха /Якутия/\",\n\t\t\t\"street\": \"ул М.Н.Пестрякова\"\n\t\t},\n" +
                "\t\t\"addressFias\": {\n\t\t\t\"addGarCode\": \"dc7fc0e6-d880-45a4-b8a7-ee5bdb6b037e" +
                "\",\n\t\t\t\"ads\": \"678373 Респ Саха /Якутия/ Бейдинга с М.Н.Пестрякова ул, д. 7, " +
                "к. 1\",\n\t\t\t\"locationGarCode\": \"c1ebc131-759c-4846-af41-afeb9a124746\",\n\t\t" +
                "\t\"regGarId\": \"c225d3db-1db6-4063-ace0-b3fe9ea3805f\"\n\t\t},\n\t\t\"ecom\": \"1" +
                "\",\n\t\t\"ecomOptions\": {\n\t\t\t\"cardPayment\": false,\n\t\t\t\"cashPayment\": " +
                "false,\n\t\t\t\"contentsChecking\": false,\n\t\t\t\"functionalityChecking\": false," +
                "\n\t\t\t\"partialRedemption\": false,\n\t\t\t\"returnAvailable\": false,\n\t\t\t\"" +
                "weightLimit\": 0.0,\n\t\t\t\"withFitting\": false\n\t\t},\n\t\t\"holidays\": [{\n\t" +
                "\t\t\"df\": \"2022-11-03\",\n\t\t\t\"ds\": \"2022-11-03\",\n\t\t\t\"work\": [{\n\t" +
                "\t\t\t\"dt\": \"2022-11-03\",\n\t\t\t\t\"fn\": \"17:00\",\n\t\t\t\t\"nm\": 4,\n\t\t" +
                "\t\t\"rst\": [{\n\t\t\t\t\t\"fn\": \"14:00\",\n\t\t\t\t\t\"st\": \"13:00\"\n\t\t\t" +
                "\t}],\n\t\t\t\t\"st\": \"10:00\"\n\t\t\t}]\n\t\t}, {\n\t\t\t\"df\": \"2022-11-04\"," +
                "\n\t\t\t\"ds\": \"2022-11-04\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-11-04\"" +
                ",\n\t\t\t\t\"nm\": 5\n\t\t\t}]\n\t\t}, {\n\t\t\t\"df\": \"2022-12-31\",\n\t\t\t\"ds" +
                "\": \"2022-12-31\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-12-31\",\n\t\t\t\t" +
                "\"fn\": \"17:00\",\n\t\t\t\t\"nm\": 6,\n\t\t\t\t\"rst\": [{\n\t\t\t\t\t\"fn\": \"14" +
                ":00\",\n\t\t\t\t\t\"st\": \"13:00\"\n\t\t\t\t}],\n\t\t\t\t\"st\": \"10:00\"\n\t\t\t" +
                "}]\n\t\t}],\n\t\t\"latitude\": \"62.391029\",\n\t\t\"longitude\": \"130.867765\",\n" +
                "\t\t\"onlineParcel\": \"0\",\n\t\t\"type\": \"СОПС\",\n\t\t\"workTime\": [\"пн, вы" +
                "ходной\", \"вт, открыто: 10:00 - 18:00, перерыв: 13:00 - 14:00\", \"ср, открыто: " +
                "10:00 - 18:00, перерыв: 13:00 - 14:00\", \"чт, открыто: 10:00 - 18:00, перерыв: 13" +
                ":00 - 14:00\", \"пт, открыто: 10:00 - 18:00, перерыв: 13:00 - 14:00\", \"сб, открыто:" +
                " 10:00 - 18:00, перерыв: 13:00 - 14:00\", \"вс, выходной\"]\n\t}, {\n\t\t\"address" +
                "\": {\n\t\t\t\"addressType\": \"DEFAULT\",\n\t\t\t\"area\": \"р-н Ершичский\",\n\t" +
                "\t\t\"house\": \"30\",\n\t\t\t\"index\": \"216592\",\n\t\t\t\"manualInput\": false," +
                "\n\t\t\t\"place\": \"д Лужная\",\n\t\t\t\"region\": \"обл Смоленская\"\n\t\t},\n\t" +
                "\t\"addressFias\": {\n\t\t\t\"addGarCode\": \"04ab06eb-4efd-4852-a0a5-ea6b7d806901" +
                "\",\n\t\t\t\"ads\": \"216592 обл Смоленская Лужная д д. 30\",\n\t\t\t\"locationGar" +
                "Code\": \"9ab44eb5-c4c2-4d3f-966d-af71f6c01f2f\",\n\t\t\t\"regGarId\": \"e8502180-" +
                "6d08-431b-83ea-c7038f0df905\"\n\t\t},\n\t\t\"ecom\": \"1\",\n\t\t\"ecomOptions\": " +
                "{\n\t\t\t\"cardPayment\": false,\n\t\t\t\"cashPayment\": false,\n\t\t\t\"contents" +
                "Checking\": false,\n\t\t\t\"functionalityChecking\": false,\n\t\t\t\"partialRedemp" +
                "tion\": false,\n\t\t\t\"returnAvailable\": false,\n\t\t\t\"weightLimit\": 0.0,\n\t" +
                "\t\t\"withFitting\": false\n\t\t},\n\t\t\"holidays\": [{\n\t\t\t\"df\": \"2022-11-" +
                "03\",\n\t\t\t\"ds\": \"2022-11-03\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-" +
                "11-03\",\n\t\t\t\t\"fn\": \"14:30\",\n\t\t\t\t\"nm\": 4,\n\t\t\t\t\"rst\": [{\n\t" +
                "\t\t\t\t\"fn\": \"13:00\",\n\t\t\t\t\t\"st\": \"12:00\"\n\t\t\t\t}],\n\t\t\t\t\"st" +
                "\": \"09:00\"\n\t\t\t}]\n\t\t}, {\n\t\t\t\"df\": \"2022-11-04\",\n\t\t\t\"ds\": " +
                "\"2022-11-04\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-11-04\",\n\t\t\t\t\"nm" +
                "\": 5\n\t\t\t}]\n\t\t}, {\n\t\t\t\"df\": \"2022-12-31\",\n\t\t\t\"ds\": \"2022-12-31" +
                "\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-12-31\",\n\t\t\t\t\"fn\": \"14:30" +
                "\",\n\t\t\t\t\"nm\": 6,\n\t\t\t\t\"rst\": [{\n\t\t\t\t\t\"fn\": \"13:00\",\n\t\t\t" +
                "\t\t\"st\": \"12:00\"\n\t\t\t\t}],\n\t\t\t\t\"st\": \"09:00\"\n\t\t\t}]\n\t\t}]," +
                "\n\t\t\"latitude\": \"53.565594\",\n\t\t\"longitude\": \"32.547247\",\n\t\t\"online" +
                "Parcel\": \"0\",\n\t\t\"type\": \"СОПС\",\n\t\t\"workTime\": [\"пн, выходной\", " +
                "\"вт, открыто: 09:00 - 15:30, перерыв: 12:00 - 13:00\", \"ср, выходной\", \"чт, " +
                "открыто: 09:00 - 15:30, перерыв: 12:00 - 13:00\", \"пт, выходной\", \"сб, открыто: " +
                "09:00 - 15:30, перерыв: 12:00 - 13:00\", \"вс, выходной\"]\n\t}, {\n\t\t\"address" +
                "\": {\n\t\t\t\"addressType\": \"DEFAULT\",\n\t\t\t\"area\": \"р-н Красноармейский" +
                "\",\n\t\t\t\"house\": \"33\",\n\t\t\t\"index\": \"412831\",\n\t\t\t\"manualInput\"" +
                ": false,\n\t\t\t\"place\": \"с Сосновка\",\n\t\t\t\"region\": \"обл Саратовская\"," +
                "\n\t\t\t\"street\": \"ул Красноармейская\"\n\t\t},\n\t\t\"addressFias\": {\n\t\t" +
                "\t\"addGarCode\": \"127b70d9-5d5b-4944-b1cd-7ffd23592f68\",\n\t\t\t\"ads\": \"4128" +
                "31 обл Саратовская Сосновка с Красноармейская ул, д. 33\",\n\t\t\t\"locationGarCode" +
                "\": \"3b8a65d4-fcf3-4081-a37f-da7b14105cad\",\n\t\t\t\"regGarId\": \"df594e0e-a935" +
                "-4664-9d26-0bae13f904fe\"\n\t\t},\n\t\t\"ecom\": \"1\",\n\t\t\"ecomOptions\": {\n" +
                "\t\t\t\"cardPayment\": false,\n\t\t\t\"cashPayment\": false,\n\t\t\t\"contentsCheck" +
                "ing\": false,\n\t\t\t\"functionalityChecking\": false,\n\t\t\t\"partialRedemption" +
                "\": false,\n\t\t\t\"returnAvailable\": false,\n\t\t\t\"weightLimit\": 0.0,\n\t\t\t" +
                "\"withFitting\": false\n\t\t},\n\t\t\"holidays\": [{\n\t\t\t\"df\": \"2022-11-03" +
                "\",\n\t\t\t\"ds\": \"2022-11-03\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-11-03" +
                "\",\n\t\t\t\t\"fn\": \"14:00\",\n\t\t\t\t\"nm\": 4,\n\t\t\t\t\"st\": \"11:00\"\n" +
                "\t\t\t}]\n\t\t}, {\n\t\t\t\"df\": \"2022-11-04\",\n\t\t\t\"ds\": \"2022-11-04\"," +
                "\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-11-04\",\n\t\t\t\t\"nm\": 5\n\t\t\t}]" +
                "\n\t\t}, {\n\t\t\t\"df\": \"2022-12-31\",\n\t\t\t\"ds\": \"2022-12-31\",\n\t\t\t" +
                "\"work\": [{\n\t\t\t\t\"dt\": \"2022-12-31\",\n\t\t\t\t\"fn\": \"14:00\",\n\t\t" +
                "\t\t\"nm\": 6,\n\t\t\t\t\"st\": \"11:00\"\n\t\t\t}]\n\t\t}],\n\t\t\"latitude\": " +
                "\"51.189051\",\n\t\t\"longitude\": \"45.786043\",\n\t\t\"onlineParcel\": \"0\",\n" +
                "\t\t\"type\": \"СОПС\",\n\t\t\"workTime\": [\"пн, выходной\", \"вт, открыто: 11:" +
                "00 - 15:00\", \"ср, выходной\", \"чт, открыто: 11:00 - 15:00\", \"пт, выходной\"" +
                ", \"сб, открыто: 11:00 - 15:00\", \"вс, выходной\"]\n\t}, {\n\t\t\"address\": {\n" +
                "\t\t\t\"addressType\": \"DEFAULT\",\n\t\t\t\"area\": \"р-н Алексеевский\",\n\t\t" +
                "\t\"house\": \"53\",\n\t\t\t\"index\": \"446642\",\n\t\t\t\"manualInput\": false," +
                "\n\t\t\t\"place\": \"с Антоновка\",\n\t\t\t\"region\": \"обл Самарская\",\n\t\t" +
                "\t\"street\": \"ул Первомайская\"\n\t\t},\n\t\t\"addressFias\": {\n\t\t\t\"addGar" +
                "Code\": \"158c0209-4828-4bde-b0cd-87553687cff0\",\n\t\t\t\"ads\": \"446642 обл " +
                "Самарская Антоновка с Первомайская ул, д. 53\",\n\t\t\t\"locationGarCode\": \"bc" +
                "6ec5b8-1a49-4c78-bac5-ea4f094f2f3f\",\n\t\t\t\"regGarId\": \"df3d7359-afa9-4aaa-" +
                "8ff9-197e73906b1c\"\n\t\t},\n\t\t\"ecom\": \"1\",\n\t\t\"ecomOptions\": {\n\t\t" +
                "\t\"cardPayment\": false,\n\t\t\t\"cashPayment\": false,\n\t\t\t\"contentsCheck" +
                "ing\": false,\n\t\t\t\"functionalityChecking\": false,\n\t\t\t\"partialRedemption" +
                "\": false,\n\t\t\t\"returnAvailable\": false,\n\t\t\t\"weightLimit\": 0.0,\n\t\t" +
                "\t\"withFitting\": false\n\t\t},\n\t\t\"holidays\": [{\n\t\t\t\"df\": \"2022-11-03" +
                "\",\n\t\t\t\"ds\": \"2022-11-03\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-11-03" +
                "\",\n\t\t\t\t\"fn\": \"14:00\",\n\t\t\t\t\"nm\": 4,\n\t\t\t\t\"st\": \"10:00\"\n" +
                "\t\t\t}]\n\t\t}, {\n\t\t\t\"df\": \"2022-11-04\",\n\t\t\t\"ds\": \"2022-11-04\"," +
                "\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-11-04\",\n\t\t\t\t\"nm\": 5\n\t\t\t" +
                "}]\n\t\t}, {\n\t\t\t\"df\": \"2022-12-31\",\n\t\t\t\"ds\": \"2022-12-31\",\n\t\t" +
                "\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-12-31\",\n\t\t\t\t\"nm\": 6\n\t\t\t}]\n\t" +
                "\t}],\n\t\t\"latitude\": \"52.667568\",\n\t\t\"longitude\": \"51.23985\",\n\t\t\"" +
                "onlineParcel\": \"0\",\n\t\t\"type\": \"СОПС\",\n\t\t\"workTime\": [\"пн, выходной" +
                "\", \"вт, открыто: 10:00 - 15:00\", \"ср, выходной\", \"чт, открыто: 10:00 - 15:" +
                "00\", \"пт, выходной\", \"сб, выходной\", \"вс, выходной\"]\n\t}, {\n\t\t\"address" +
                "\": {\n\t\t\t\"addressType\": \"DEFAULT\",\n\t\t\t\"area\": \"р-н Александровск-" +
                "Сахалинский\",\n\t\t\t\"house\": \"5\",\n\t\t\t\"index\": \"694434\",\n\t\t\t\"" +
                "manualInput\": false,\n\t\t\t\"place\": \"с Хоэ\",\n\t\t\t\"region\": \"обл Саха" +
                "линская\",\n\t\t\t\"street\": \"пер Комсомольский\"\n\t\t},\n\t\t\"addressFias\"" +
                ": {\n\t\t\t\"addGarCode\": \"bc610670-3871-47e3-b434-44403228692c\",\n\t\t\t\"ads" +
                "\": \"694434 обл Сахалинская Хоэ с Комсомольский пер, д. 5\",\n\t\t\t\"locationGar" +
                "Code\": \"5fd9e57f-28db-4f0d-9804-57f2d9e4e3c3\",\n\t\t\t\"regGarId\": \"aea6280f-" +
                "4648-460f-b8be-c2bc18923191\"\n\t\t},\n\t\t\"ecom\": \"1\",\n\t\t\"ecomOptions\": " +
                "{\n\t\t\t\"cardPayment\": false,\n\t\t\t\"cashPayment\": false,\n\t\t\t\"contents" +
                "Checking\": false,\n\t\t\t\"functionalityChecking\": false,\n\t\t\t\"partialRed" +
                "emption\": false,\n\t\t\t\"returnAvailable\": false,\n\t\t\t\"weightLimit\": 0.0," +
                "\n\t\t\t\"withFitting\": false\n\t\t},\n\t\t\"holidays\": [{\n\t\t\t\"df\": \"" +
                "2022-11-03\",\n\t\t\t\"ds\": \"2022-11-03\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\":" +
                " \"2022-11-03\",\n\t\t\t\t\"fn\": \"16:00\",\n\t\t\t\t\"nm\": 4,\n\t\t\t\t\"st\":" +
                " \"10:00\"\n\t\t\t}]\n\t\t}, {\n\t\t\t\"df\": \"2022-11-04\",\n\t\t\t\"ds\": \"" +
                "2022-11-04\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-11-04\",\n\t\t\t\t\"nm" +
                "\": 5\n\t\t\t}]\n\t\t}, {\n\t\t\t\"df\": \"2022-12-31\",\n\t\t\t\"ds\": \"2022-12" +
                "-31\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-12-31\",\n\t\t\t\t\"nm\": 6\n" +
                "\t\t\t}]\n\t\t}],\n\t\t\"latitude\": \"51.320557\",\n\t\t\"longitude\": \"142.182487" +
                "\",\n\t\t\"onlineParcel\": \"0\",\n\t\t\"type\": \"СОПС\",\n\t\t\"workTime\": [" +
                "\"пн, открыто: 10:00 - 17:00, перерыв: 13:00 - 14:00\", \"вт, открыто: 10:00 - " +
                "17:00, перерыв: 13:00 - 14:00\", \"ср, открыто: 10:00 - 17:00, перерыв: 13:00 - " +
                "14:00\", \"чт, открыто: 10:00 - 17:00, перерыв: 13:00 - 14:00\", \"пт, открыто: " +
                "10:00 - 16:00, перерыв: 13:00 - 14:00\", \"сб, выходной\", \"вс, выходной\"]\n\t" +
                "}, {\n\t\t\"address\": {\n\t\t\t\"addressType\": \"DEFAULT\",\n\t\t\t\"house\": " +
                "\"23\",\n\t\t\t\"index\": \"693903\",\n\t\t\t\"location\": \"с Санаторное\",\n\t" +
                "\t\t\"manualInput\": false,\n\t\t\t\"place\": \"г Южно-Сахалинск\",\n\t\t\t\"region" +
                "\": \"обл Сахалинская\"\n\t\t},\n\t\t\"addressFias\": {\n\t\t\t\"addGarCode\": " +
                "\"a8f65eb5-464e-462e-bc67-7e4624be9d65\",\n\t\t\t\"ads\": \"693903 обл Сахалинск" +
                "ая Южно-Сахалинск г Санаторное с, д. 23\",\n\t\t\t\"locationGarCode\": \"44388ad0" +
                "-06aa-49b0-bbf9-1704629d1d68\",\n\t\t\t\"regGarId\": \"aea6280f-4648-460f-b8be-" +
                "c2bc18923191\"\n\t\t},\n\t\t\"ecom\": \"1\",\n\t\t\"ecomOptions\": {\n\t\t\t\"card" +
                "Payment\": false,\n\t\t\t\"cashPayment\": false,\n\t\t\t\"contentsChecking\": false" +
                ",\n\t\t\t\"functionalityChecking\": false,\n\t\t\t\"partialRedemption\": false," +
                "\n\t\t\t\"returnAvailable\": false,\n\t\t\t\"weightLimit\": 0.0,\n\t\t\t\"with" +
                "Fitting\": false\n\t\t},\n\t\t\"holidays\": [{\n\t\t\t\"df\": \"2022-11-03\",\n\t" +
                "\t\t\"ds\": \"2022-11-03\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-11-03\"," +
                "\n\t\t\t\t\"fn\": \"16:30\",\n\t\t\t\t\"nm\": 4,\n\t\t\t\t\"rst\": [{\n\t\t\t\t" +
                "\t\"fn\": \"15:00\",\n\t\t\t\t\t\"st\": \"13:00\"\n\t\t\t\t}],\n\t\t\t\t\"st\": " +
                "\"10:00\"\n\t\t\t}]\n\t\t}, {\n\t\t\t\"df\": \"2022-11-04\",\n\t\t\t\"ds\": \"" +
                "2022-11-04\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-11-04\",\n\t\t\t\t\"" +
                "nm\": 5\n\t\t\t}]\n\t\t}, {\n\t\t\t\"df\": \"2022-12-31\",\n\t\t\t\"ds\": \"2022" +
                "-12-31\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-12-31\",\n\t\t\t\t\"fn\": " +
                "\"16:00\",\n\t\t\t\t\"nm\": 6,\n\t\t\t\t\"rst\": [{\n\t\t\t\t\t\"fn\": \"15:00" +
                "\",\n\t\t\t\t\t\"st\": \"13:00\"\n\t\t\t\t}],\n\t\t\t\t\"st\": \"10:00\"\n\t\t" +
                "\t}]\n\t\t}],\n\t\t\"latitude\": \"47.105419\",\n\t\t\"longitude\": \"142.627018" +
                "\",\n\t\t\"onlineParcel\": \"0\",\n\t\t\"type\": \"СОПС\",\n\t\t\"workTime\": " +
                "[\"пн, выходной\", \"вт, открыто: 10:00 - 17:30, перерыв: 13:00 - 15:00\", \"" +
                "ср, выходной\", \"чт, открыто: 10:00 - 17:30, перерыв: 13:00 - 15:00\", \"пт, " +
                "выходной\", \"сб, открыто: 10:00 - 17:00, перерыв: 13:00 - 15:00\", \"вс, выходной" +
                "\"]\n\t}, {\n\t\t\"address\": {\n\t\t\t\"addressType\": \"DEFAULT\",\n\t\t\t\"" +
                "area\": \"р-н Ртищевский\",\n\t\t\t\"house\": \"17А\",\n\t\t\t\"index\": \"412045" +
                "\",\n\t\t\t\"manualInput\": false,\n\t\t\t\"place\": \"с Каменка\",\n\t\t\t\"" +
                "region\": \"обл Саратовская\",\n\t\t\t\"street\": \"ул Центральная\"\n\t\t}," +
                "\n\t\t\"addressFias\": {\n\t\t\t\"addGarCode\": \"68113d66-830b-4b5e-b320-cb470" +
                "a08513e\",\n\t\t\t\"ads\": \"412045 обл Саратовская Каменка с Центральная ул, " +
                "д. 17А\",\n\t\t\t\"locationGarCode\": \"e612f5ca-502b-4222-bc09-582e2a0718bd\"," +
                "\n\t\t\t\"regGarId\": \"df594e0e-a935-4664-9d26-0bae13f904fe\"\n\t\t},\n\t\t\"" +
                "ecom\": \"1\",\n\t\t\"ecomOptions\": {\n\t\t\t\"cardPayment\": false,\n\t\t\t\"" +
                "cashPayment\": false,\n\t\t\t\"contentsChecking\": false,\n\t\t\t\"functionality" +
                "Checking\": false,\n\t\t\t\"partialRedemption\": false,\n\t\t\t\"returnAvailable" +
                "\": false,\n\t\t\t\"weightLimit\": 0.0,\n\t\t\t\"withFitting\": false\n\t\t},\n" +
                "\t\t\"holidays\": [{\n\t\t\t\"df\": \"2022-11-03\",\n\t\t\t\"ds\": \"2022-11-03" +
                "\",\n\t\t\t\"work\": [{\n\t\t\t\t\"dt\": \"2022-11-03\",\n\t\t\t\t\"fn\": \"15:" +
                "00\",\n\t\t\t\t\"nm\": 4,\n\t\t\t\t\"rst\": [{\n\t\t\t\t\t\"fn\": \"14:00\",\n" +
                "\t\t\t\t\t\"st\": \"13:00\"\n\t\t\t\t}],\n\t\t\t\t\"st\": \"09:00\"\n\t\t\t}]\n" +
                "\t\t}, {\n\t\t\t\"df\": \"2022-11-04\",\n\t\t\t\"ds\": \"2022-11-04\",\n\t\t\t" +
                "\"work\": [{\n\t\t\t\t\"dt\": \"2022-11-04\",\n\t\t\t\t\"nm\": 5\n\t\t\t}]\n\t" +
                "\t}, {\n\t\t\t\"df\": \"2022-12-31\",\n\t\t\t\"ds\": \"2022-12-31\",\n\t\t\t\"" +
                "work\": [{\n\t\t\t\t\"dt\": \"2022-12-31\",\n\t\t\t\t\"fn\": \"15:00\",\n\t\t" +
                "\t\t\"nm\": 6,\n\t\t\t\t\"rst\": [{\n\t\t\t\t\t\"fn\": \"14:00\",\n\t\t\t\t\t" +
                "\"st\": \"13:00\"\n\t\t\t\t}],\n\t\t\t\t\"st\": \"09:00\"\n\t\t\t}]\n\t\t}],\n" +
                "\t\t\"latitude\": \"52.043973\",\n\t\t\"longitude\": \"43.95048\",\n\t\t\"online" +
                "Parcel\": \"0\",\n\t\t\"type\": \"СОПС\",\n\t\t\"workTime\": [\"пн, выходной" +
                "\", \"вт, открыто:\"]\n\t}],\n\t\"unloadingDate\": \"2022-10-25T10:21:33.000Z" +
                "\",\n\t\"vsnapshot\": \"26_October_2022\"\n}";

            var deserialized = Serializer.Deserialize<PassportSnapshot>(passport);
            Assert.That(deserialized, Is.Not.Null);
            Assert.That(deserialized.PostOffices, Is.Not.Null.And.Not.Empty);
            Assert.That(deserialized.PostOffices, Has.Length.EqualTo(8));
            Assert.That(deserialized.Vsnapshot, Is.EqualTo("26_October_2022"));

            var office = deserialized.PostOffices[0];
            Assert.That(office, Is.Not.Null);
            Assert.That(office.Address, Is.Not.Null);
            Assert.That(office.Address.ManualInput, Is.False);
            Assert.That(office.Address.AddressType, Is.EqualTo(AddressType.Default));
            Assert.That(office.Address.PostCode, Is.EqualTo("216236"));
            Assert.That(office.Address.Region, Is.EqualTo("обл Смоленская"));
            Assert.That(office.Address.Place, Is.EqualTo("д Добрино"));
            Assert.That(office.Address.Street, Is.EqualTo("ул Пляжная"));
            Assert.That(office.Address.House, Is.EqualTo("7"));
            Assert.That(office.AddressFias, Is.Not.Null);
            Assert.That(office.AddressFias.Address, Is.EqualTo("216236 обл Смоленская Добрино д Пляжная ул, д. 7"));
            Assert.That(office.Latitude, Is.EqualTo(55.612752m));
            Assert.That(office.Longitude, Is.EqualTo(32.433259m));
            Assert.That(office.Type, Is.EqualTo("СОПС"));
        }
    }
}
