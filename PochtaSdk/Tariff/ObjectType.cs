#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Tariffication object types.
    /// Values are serialized as numbers, so enum shouldn't be marked as DataContract.
    /// Типы объектов тарификации.
    /// Сериализуются в виде чисел, поэтому атрибут DataContract не применяется.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Appendix 1)
    /// </summary>
    /// <remarks>
    /// The contents of this enum is generated, see PochtaSdk.Playground/ObjectTypeGenerator.cs.
    /// Содержимое этого перечисления сгенерировано, см. PochtaSdk.Playground/ObjectTypeGenerator.cs.
    /// </remarks>
    public enum ObjectType
    {
        /// <summary>
        /// Intra-Russian money transfer.
        /// Внутрироссийский перевод.
        /// </summary>
        IntraRussianMoneyTransfer = 1000,
        ВнутрироссийскийПеревод = 1000,

        /// <summary>
        /// Money transfer Forcage address.
        /// Денежный перевод Форсаж адресный.
        /// </summary>
        MoneyTransferForcageAddress = 1010,
        ДенежныйПереводФорсажАдресный = 1010,

        /// <summary>
        /// Money transfer Forcage unaddressed.
        /// Денежный перевод Форсаж безадресный.
        /// </summary>
        MoneyTransferForcageUnaddressed = 1020,
        ДенежныйПереводФорсажБезадресный = 1020,

        /// <summary>
        /// Money transfer Forcage international.
        /// Денежный перевод Форсаж международный.
        /// </summary>
        MoneyTransferForcageInternational = 1021,
        ДенежныйПереводФорсажМеждународный = 1021,

        /// <summary>
        /// Cash transfer cash on delivery.
        /// Перевод наложенного платежа.
        /// </summary>
        CashTransferCashOnDelivery = 1040,
        ПереводНаложенногоПлатежа = 1040,

        /// <summary>
        /// Money transfer Unistream.
        /// Денежный перевод Unistream.
        /// </summary>
        MoneyTransferUnistream = 1051,
        ДенежныйПереводUnistream = 1051,

        /// <summary>
        /// Delivery of postal money transfer to the recipient at home.
        /// Доставка почтового перевода получателю на дом.
        /// </summary>
        DeliveryOfPostalMoneyTransferToTheRecipientAtHome = 1290,
        ДоставкаПочтовогоПереводаПолучателюНаДом = 1290,

        /// <summary>
        /// Money transfer Forcage home delivery.
        /// Доставка перевода Форсаж на дом.
        /// </summary>
        MoneyTransferForcageHomeDelivery = 1300,
        ДоставкаПереводаФорсажНаДом = 1300,

        /// <summary>
        /// Letter regular.
        /// Письмо простое.
        /// </summary>
        LetterRegular = 2000,
        ПисьмоПростое = 2000,

        /// <summary>
        /// Letter regular international outgoing.
        /// Письмо простое международное исходящее.
        /// </summary>
        LetterRegularInternationalOutgoing = 2001,
        ПисьмоПростоеМеждународноеИсходящее = 2001,

        /// <summary>
        /// Letter regular international transit.
        /// Письмо простое международное транзитное.
        /// </summary>
        LetterRegularInternationalTransit = 2003,
        ПисьмоПростоеМеждународноеТранзитное = 2003,

        /// <summary>
        /// Letter registered.
        /// Письмо заказное.
        /// </summary>
        LetterRegistered = 2010,
        ПисьмоЗаказное = 2010,

        /// <summary>
        /// Letter registered international outgoing.
        /// Письмо заказное международное исходящее.
        /// </summary>
        LetterRegisteredInternationalOutgoing = 2011,
        ПисьмоЗаказноеМеждународноеИсходящее = 2011,

        /// <summary>
        /// Letter registered international transit.
        /// Письмо заказное международное транзитное.
        /// </summary>
        LetterRegisteredInternationalTransit = 2013,
        ПисьмоЗаказноеМеждународноеТранзитное = 2013,

        /// <summary>
        /// Letter with declared value.
        /// Письмо с объявленной ценностью.
        /// </summary>
        LetterWithDeclaredValue = 2020,
        ПисьмоСОбъявленнойЦенностью = 2020,

        /// <summary>
        /// Letter with declared value international outgoing.
        /// Письмо с объявленной ценностью международное исходящее.
        /// </summary>
        LetterWithDeclaredValueInternationalOutgoing = 2021,
        ПисьмоСОбъявленнойЦенностьюМеждународноеИсходящее = 2021,

        /// <summary>
        /// Letter with declared value international transit.
        /// Письмо с объявленной ценностью международное транзитное.
        /// </summary>
        LetterWithDeclaredValueInternationalTransit = 2023,
        ПисьмоСОбъявленнойЦенностьюМеждународноеТранзитное = 2023,

        /// <summary>
        /// Letter with declared value and cash on delivery.
        /// Письмо с объявленной ценностью и наложенным платежом.
        /// </summary>
        LetterWithDeclaredValueAndCashOnDelivery = 2040,
        ПисьмоСОбъявленнойЦенностьюИНаложеннымПлатежом = 2040,

        /// <summary>
        /// Wrapper regular.
        /// Бандероль простая.
        /// </summary>
        WrapperRegular = 3000,
        БандерольПростая = 3000,

        /// <summary>
        /// Wrapper regular international outgoing.
        /// Бандероль простая международная исходящая.
        /// </summary>
        WrapperRegularInternationalOutgoing = 3001,
        БандерольПростаяМеждународнаяИсходящая = 3001,

        /// <summary>
        /// Wrapper regular international incoming.
        /// Бандероль простая международная входящая.
        /// </summary>
        WrapperRegularInternationalIncoming = 3002,
        БандерольПростаяМеждународнаяВходящая = 3002,

        /// <summary>
        /// Wrapper regular international transit.
        /// Бандероль простая международная транзитная.
        /// </summary>
        WrapperRegularInternationalTransit = 3003,
        БандерольПростаяМеждународнаяТранзитная = 3003,

        /// <summary>
        /// Wrapper registered.
        /// Бандероль заказная.
        /// </summary>
        WrapperRegistered = 3010,
        БандерольЗаказная = 3010,

        /// <summary>
        /// Wrapper registered international outgoing.
        /// Бандероль заказная международная исходящая.
        /// </summary>
        WrapperRegisteredInternationalOutgoing = 3011,
        БандерольЗаказнаяМеждународнаяИсходящая = 3011,

        /// <summary>
        /// Wrapper registered international transit.
        /// Бандероль заказная международная транзитная.
        /// </summary>
        WrapperRegisteredInternationalTransit = 3013,
        БандерольЗаказнаяМеждународнаяТранзитная = 3013,

        /// <summary>
        /// Wrapper with declared value.
        /// Бандероль с объявленной ценностью.
        /// </summary>
        WrapperWithDeclaredValue = 3020,
        БандерольСОбъявленнойЦенностью = 3020,

        /// <summary>
        /// Wrapper with declared value and cash on delivery.
        /// Бандероль с объявленной ценностью и наложенным платежом.
        /// </summary>
        WrapperWithDeclaredValueAndCashOnDelivery = 3040,
        БандерольСОбъявленнойЦенностьюИНаложеннымПлатежом = 3040,

        /// <summary>
        /// Parcel with declared value.
        /// Посылка с объявленной ценностью.
        /// </summary>
        ParcelWithDeclaredValue = 4020,
        ПосылкаСОбъявленнойЦенностью = 4020,

        /// <summary>
        /// Parcel with declared value international outgoing.
        /// Посылка с объявленной ценностью международная исходящая.
        /// </summary>
        ParcelWithDeclaredValueInternationalOutgoing = 4021,
        ПосылкаСОбъявленнойЦенностьюМеждународнаяИсходящая = 4021,

        /// <summary>
        /// Parcel with declared value International incoming.
        /// Посылка с объявленной ценностью международная входящая.
        /// </summary>
        ParcelWithDeclaredValueInternationalIncoming = 4022,
        ПосылкаСОбъявленнойЦенностьюМеждународнаяВходящая = 4022,

        /// <summary>
        /// Parcel.
        /// Посылка.
        /// </summary>
        Parcel = 4030,
        Посылка = 4030,

        /// <summary>
        /// Parcel regular international outgoing.
        /// Посылка обыкновенная международная исходящая.
        /// </summary>
        ParcelRegularInternationalOutgoing = 4031,
        ПосылкаОбыкновеннаяМеждународнаяИсходящая = 4031,

        /// <summary>
        /// Parcel regular international incoming.
        /// Посылка обыкновенная международная входящая.
        /// </summary>
        ParcelRegularInternationalIncoming = 4032,
        ПосылкаОбыкновеннаяМеждународнаяВходящая = 4032,

        /// <summary>
        /// Parcel with declared value and cash on delivery.
        /// Посылка с объявленной ценностью и наложенным платежом.
        /// </summary>
        ParcelWithDeclaredValueAndCashOnDelivery = 4040,
        ПосылкаСОбъявленнойЦенностьюИНаложеннымПлатежом = 4040,

        /// <summary>
        /// Parcel with declared value and cash on delivery international outgoing.
        /// Посылка с объявленной ценностью и наложенным платежом международная исходящая.
        /// </summary>
        ParcelWithDeclaredValueAndCashOnDeliveryInternationalOutgoing = 4041,
        ПосылкаСОбъявленнойЦенностьюИНаложеннымПлатежомМеждународнаяИсходящая = 4041,

        /// <summary>
        /// Parcel with declared value and cash on delivery international incoming.
        /// Посылка с объявленной ценностью и наложенным платежом международная входящая.
        /// </summary>
        ParcelWithDeclaredValueAndCashOnDeliveryInternationalIncoming = 4042,
        ПосылкаСОбъявленнойЦенностьюИНаложеннымПлатежомМеждународнаяВходящая = 4042,

        /// <summary>
        /// Parcel with declared value and mandatory payment.
        /// Посылка с объявленной ценностью и обязательным платежом.
        /// </summary>
        ParcelWithDeclaredValueAndMandatoryPayment = 4060,
        ПосылкаСОбъявленнойЦенностьюИОбязательнымПлатежом = 4060,

        /// <summary>
        /// Small package simple outgoing.
        /// Мелкий пакет простой исходящий.
        /// </summary>
        SmallPackageSimpleOutgoing = 5001,
        МелкийПакетПростойИсходящий = 5001,

        /// <summary>
        /// Small package simple incoming.
        /// Мелкий пакет простой входящий.
        /// </summary>
        SmallPackageSimpleIncoming = 5002,
        МелкийПакетПростойВходящий = 5002,

        /// <summary>
        /// Small package simple transit.
        /// Мелкий пакет простой транзитный.
        /// </summary>
        SmallPackageSimpleTransit = 5003,
        МелкийПакетПростойТранзитный = 5003,

        /// <summary>
        /// Small package registered outgoing.
        /// Мелкий пакет заказной исходящий.
        /// </summary>
        SmallPackageRegisteredOutgoing = 5011,
        МелкийПакетЗаказнойИсходящий = 5011,

        /// <summary>
        /// Small package registered incoming.
        /// Мелкий пакет заказной входящий.
        /// </summary>
        SmallPackageRegisteredIncoming = 5012,
        МелкийПакетЗаказнойВходящий = 5012,

        /// <summary>
        /// Small package registered transit.
        /// Мелкий пакет заказной транзитный.
        /// </summary>
        SmallPackageRegisteredTransit = 5013,
        МелкийПакетЗаказнойТранзитный = 5013,

        /// <summary>
        /// Regular postcard.
        /// Почтовая карточка простая.
        /// </summary>
        RegularPostcard = 6000,
        ПочтоваяКарточкаПростая = 6000,

        /// <summary>
        /// Regular international outgoing postcard.
        /// Почтовая карточка простая международная исходящая.
        /// </summary>
        RegularInternationalOutgoingPostcard = 6001,
        ПочтоваяКарточкаПростаяМеждународнаяИсходящая = 6001,

        /// <summary>
        /// Regular international transit postcard.
        /// Почтовая карточка простая международная транзитная.
        /// </summary>
        RegularInternationalTransitPostcard = 6003,
        ПочтоваяКарточкаПростаяМеждународнаяТранзитная = 6003,

        /// <summary>
        /// Registered postcard.
        /// Почтовая карточка заказная.
        /// </summary>
        RegisteredPostcard = 6010,
        ПочтоваяКарточкаЗаказная = 6010,

        /// <summary>
        /// Registered international outgoing postcard.
        /// Почтовая карточка заказная международная исходящая.
        /// </summary>
        RegisteredInternationalOutgoingPostcard = 6011,
        ПочтоваяКарточкаЗаказнаяМеждународнаяИсходящая = 6011,

        /// <summary>
        /// Registered international transit postcard.
        /// Почтовая карточка заказная международная транзитная.
        /// </summary>
        RegisteredInternationalTransitPostcard = 6013,
        ПочтоваяКарточкаЗаказнаяМеждународнаяТранзитная = 6013,

        /// <summary>
        /// Parcel EMS with declared value.
        /// EMS с объявленной ценностью.
        /// </summary>
        ParcelEmsWithDeclaredValue = 7020,
        EmsСОбъявленнойЦенностью = 7020,

        /// <summary>
        /// Parcel EMS with Declared value international outbound.
        /// EMS с объявленной ценностью международное исходящее.
        /// </summary>
        ParcelEmsWithDeclaredValueInternationalOutbound = 7021,
        EmsСОбъявленнойЦенностьюМеждународноеИсходящее = 7021,

        /// <summary>
        /// Parcel EMS with OC International Incoming.
        /// EMS с ОЦ международное входящее.
        /// </summary>
        ParcelEmsWithOcInternationalIncoming = 7022,
        EmsСОцМеждународноеВходящее = 7022,

        /// <summary>
        /// Parcel EMS.
        /// EMS.
        /// </summary>
        ParcelEms = 7030,
        Ems = 7030,

        /// <summary>
        /// Parcel EMS Ordinary International Outgoing.
        /// EMS обыкновенное международное исходящее.
        /// </summary>
        ParcelEmsOrdinaryInternationalOutgoing = 7031,
        EmsОбыкновенноеМеждународноеИсходящее = 7031,

        /// <summary>
        /// Parcel EMS International Incoming.
        /// EMS международное входящее.
        /// </summary>
        ParcelEmsInternationalIncoming = 7032,
        EmsМеждународноеВходящее = 7032,

        /// <summary>
        /// Parcel EMS with declared value and cash on delivery.
        /// EMS с объявленной ценностью и наложенным платежом.
        /// </summary>
        ParcelEmsWithDeclaredValueAndCashOnDelivery = 7040,
        EmsСОбъявленнойЦенностьюИНаложеннымПлатежом = 7040,

        /// <summary>
        /// Parcel EMS with Cash on Delivery international Outgoing.
        /// EMS с наложенным платежом международное исходящее.
        /// </summary>
        ParcelEmsWithCashOnDeliveryInternationalOutgoing = 7041,
        EmsСНаложеннымПлатежомМеждународноеИсходящее = 7041,

        /// <summary>
        /// Parcel EMS with OC and NP international incoming.
        /// EMS с ОЦ и НП международное входящее.
        /// </summary>
        ParcelEmsWithOcAndNpInternationalIncoming = 7042,
        EmsСОцИНпМеждународноеВходящее = 7042,

        /// <summary>
        /// Parcel EMS with declared value and mandatory payment.
        /// EMS с объявленной ценностью и обязательным платежом.
        /// </summary>
        ParcelEmsWithDeclaredValueAndMandatoryPayment = 7060,
        EmsСОбъявленнойЦенностьюИОбязательнымПлатежом = 7060,

        /// <summary>
        /// Secogram.
        /// Секограмма.
        /// </summary>
        Secogram = 8010,
        Секограмма = 8010,

        /// <summary>
        /// Secogram international outgoing.
        /// Секограмма международная исходящая.
        /// </summary>
        SecogramInternationalOutgoing = 8011,
        СекограммаМеждународнаяИсходящая = 8011,

        /// <summary>
        /// Secogram international transit.
        /// Секограмма международная транзитная.
        /// </summary>
        SecogramInternationalTransit = 8013,
        СекограммаМеждународнаяТранзитная = 8013,

        /// <summary>
        /// Bag/M simple outgoing.
        /// Мешок М простой исходящий.
        /// </summary>
        BagMSimpleOutgoing = 9001,
        МешокМПростойИсходящий = 9001,

        /// <summary>
        /// Bag/M simple transit.
        /// Мешок М простой транзитный.
        /// </summary>
        BagMSimpleTransit = 9003,
        МешокМПростойТранзитный = 9003,

        /// <summary>
        /// Bag/M registered outgoing.
        /// Мешок М заказной исходящий.
        /// </summary>
        BagMRegisteredOutgoing = 9011,
        МешокМЗаказнойИсходящий = 9011,

        /// <summary>
        /// Bag/M registered transit.
        /// Мешок М заказной транзитный.
        /// </summary>
        BagMRegisteredTransit = 9013,
        МешокМЗаказнойТранзитный = 9013,

        /// <summary>
        /// Return of accompanying documents.
        /// Возврат сопроводительных документов.
        /// </summary>
        ReturnOfAccompanyingDocuments = 10030,
        ВозвратСопроводительныхДокументов = 10030,

        /// <summary>
        /// Letter 1 class registered.
        /// Письмо 1 класса заказное.
        /// </summary>
        Letter1ClassRegistered = 15010,
        Письмо1КлассаЗаказное = 15010,

        /// <summary>
        /// Letter 1 class with declared value.
        /// Письмо 1 класса с объявленной ценностью.
        /// </summary>
        Letter1ClassWithDeclaredValue = 15020,
        Письмо1КлассаСОбъявленнойЦенностью = 15020,

        /// <summary>
        /// Letter 1 class with declared value and cash on delivery.
        /// Письмо 1 класса с объявленной ценностью и наложенным платежом.
        /// </summary>
        Letter1ClassWithDeclaredValueAndCashOnDelivery = 15040,
        Письмо1КлассаСОбъявленнойЦенностьюИНаложеннымПлатежом = 15040,

        /// <summary>
        /// Wrapper 1 class registered.
        /// Бандероль 1 класса заказная.
        /// </summary>
        Wrapper1ClassRegistered = 16010,
        Бандероль1КлассаЗаказная = 16010,

        /// <summary>
        /// Wrapper 1 class with declared value.
        /// Бандероль 1 класса с объявленной ценностью.
        /// </summary>
        Wrapper1ClassWithDeclaredValue = 16020,
        Бандероль1КлассаСОбъявленнойЦенностью = 16020,

        /// <summary>
        /// Wrapper 1 class with declared value and cash on delivery.
        /// Бандероль 1 класса с объявленной ценностью и наложенным платежом.
        /// </summary>
        Wrapper1ClassWithDeclaredValueAndCashOnDelivery = 16040,
        Бандероль1КлассаСОбъявленнойЦенностьюИНаложеннымПлатежом = 16040,

        /// <summary>
        /// OVPO letter regular.
        /// ОВПО письмо простое.
        /// </summary>
        OvpoLetterRegular = 19000,
        ОвпоПисьмоПростое = 19000,

        /// <summary>
        /// OVPO letter registered.
        /// ОВПО письмо заказное.
        /// </summary>
        OvpoLetterRegistered = 19010,
        ОвпоПисьмоЗаказное = 19010,

        /// <summary>
        /// OVPO card regular.
        /// ОВПО карточка простая.
        /// </summary>
        OvpoCardRegular = 22000,
        ОвпоКарточкаПростая = 22000,

        /// <summary>
        /// OVPO card registered.
        /// ОВПО карточка заказная.
        /// </summary>
        OvpoCardRegistered = 22010,
        ОвпоКарточкаЗаказная = 22010,

        /// <summary>
        /// Parcel Online with declared value.
        /// Посылка онлайн с объявленной ценностью.
        /// </summary>
        ParcelOnlineWithDeclaredValue = 23020,
        ПосылкаОнлайнСОбъявленнойЦенностью = 23020,

        /// <summary>
        /// Parcel online regular.
        /// Посылка онлайн обыкновенная.
        /// </summary>
        ParcelOnlineRegular = 23030,
        ПосылкаОнлайнОбыкновенная = 23030,

        /// <summary>
        /// Parcel online with declared value and cash on delivery.
        /// Посылка онлайн с объявленной ценностью и наложенным платежом.
        /// </summary>
        ParcelOnlineWithDeclaredValueAndCashOnDelivery = 23040,
        ПосылкаОнлайнСОбъявленнойЦенностьюИНаложеннымПлатежом = 23040,

        /// <summary>
        /// Parcel online with declared value and mandatory payment.
        /// Посылка онлайн с объявленной ценностью и обязательным платежом.
        /// </summary>
        ParcelOnlineWithDeclaredValueAndMandatoryPayment = 23060,
        ПосылкаОнлайнСОбъявленнойЦенностьюИОбязательнымПлатежом = 23060,

        /// <summary>
        /// Parcel Online combined.
        /// Посылка онлайн комбинированная.
        /// </summary>
        ParcelOnlineCombined = 23080,
        ПосылкаОнлайнКомбинированная = 23080,

        /// <summary>
        /// Parcel online combined with declared value.
        /// Посылка онлайн комбинированная с объявленной ценностью.
        /// </summary>
        ParcelOnlineCombinedWithDeclaredValue = 23090,
        ПосылкаОнлайнКомбинированнаяСОбъявленнойЦенностью = 23090,

        /// <summary>
        /// Courier online with declared value.
        /// Курьер онлайн с объявленной ценностью.
        /// </summary>
        CourierOnlineWithDeclaredValue = 24020,
        КурьерОнлайнСОбъявленнойЦенностью = 24020,

        /// <summary>
        /// Courier online regular.
        /// Курьер онлайн обыкновенный.
        /// </summary>
        CourierOnlineRegular = 24030,
        КурьерОнлайнОбыкновенный = 24030,

        /// <summary>
        /// Courier online with declared value and cash on delivery.
        /// Курьер онлайн с объявленной ценностью и наложенным платежом.
        /// </summary>
        CourierOnlineWithDeclaredValueAndCashOnDelivery = 24040,
        КурьерОнлайнСОбъявленнойЦенностьюИНаложеннымПлатежом = 24040,

        /// <summary>
        /// Courier online with declared value and mandatory payment.
        /// Курьер онлайн с объявленной ценностью и обязательным платежом.
        /// </summary>
        CourierOnlineWithDeclaredValueAndMandatoryPayment = 24060,
        КурьерОнлайнСОбъявленнойЦенностьюИОбязательнымПлатежом = 24060,

        /// <summary>
        /// Direct Mail Standard.
        /// Директ-мейл Стандарт.
        /// </summary>
        DirectMailStandard = 25000,
        ДиректМейлСтандарт = 25000,

        /// <summary>
        /// Direct Mail Regional.
        /// Директ-мейл Региональный.
        /// </summary>
        DirectMailRegional = 25020,
        ДиректМейлРегиональный = 25020,

        /// <summary>
        /// Direct mail B2B.
        /// Директ-мейл B2B.
        /// </summary>
        DirectMailB2b = 25030,
        ДиректМейлB2b = 25030,

        /// <summary>
        /// Direct Mail Plus.
        /// Директ-мейл плюс.
        /// </summary>
        DirectMailPlus = 25040,
        ДиректМейлПлюс = 25040,

        /// <summary>
        /// Transportation and delivery of Direct mail.
        /// Перевозка и сдача Директ-мейл.
        /// </summary>
        TransportationAndDeliveryOfDirectMail = 25280,
        ПеревозкаИСдачаДиректМейл = 25280,

        /// <summary>
        /// Start-up preparation of Direct mail.
        /// Предпочтовая подготовка Директ-мейл.
        /// </summary>
        StartUpPreparationOfDirectMail = 25290,
        ПредпочтоваяПодготовкаДиректМейл = 25290,

        /// <summary>
        /// Return of Direct mail shipments.
        /// Возврат отправлений Директ-мейл.
        /// </summary>
        ReturnOfDirectMailShipments = 25900,
        ВозвратОтправленийДиректМейл = 25900,

        /// <summary>
        /// Parcel standard with declared value.
        /// Посылка стандарт с объявленной ценностью.
        /// </summary>
        ParcelStandardWithDeclaredValue = 27020,
        ПосылкаСтандартСОбъявленнойЦенностью = 27020,

        /// <summary>
        /// Parcel standard.
        /// Посылка стандарт.
        /// </summary>
        ParcelStandard = 27030,
        ПосылкаСтандарт = 27030,

        /// <summary>
        /// Parcel standard with declared value and cash on delivery.
        /// Посылка стандарт с объявленной ценностью и наложенным платежом.
        /// </summary>
        ParcelStandardWithDeclaredValueAndCashOnDelivery = 27040,
        ПосылкаСтандартСОбъявленнойЦенностьюИНаложеннымПлатежом = 27040,

        /// <summary>
        /// Business courier with declared value.
        /// Бизнес курьер с объявленной ценностью.
        /// </summary>
        BusinessCourierWithDeclaredValue = 30020,
        БизнесКурьерСОбъявленнойЦенностью = 30020,

        /// <summary>
        /// Business Courier.
        /// Бизнес курьер.
        /// </summary>
        BusinessCourier = 30030,
        БизнесКурьер = 30030,

        /// <summary>
        /// Business Courier Express with declared value.
        /// Бизнес курьер экспресс с объявленной ценностью.
        /// </summary>
        BusinessCourierExpressWithDeclaredValue = 31020,
        БизнесКурьерЭкспрессСОбъявленнойЦенностью = 31020,

        /// <summary>
        /// Business Courier Express.
        /// Бизнес курьер экспресс.
        /// </summary>
        BusinessCourierExpress = 31030,
        БизнесКурьерЭкспресс = 31030,

        /// <summary>
        /// Parcel EMS optimal with declared value.
        /// EMS оптимальное с объявленной ценностью.
        /// </summary>
        ParcelEmsOptimalWithDeclaredValue = 34020,
        EmsОптимальноеСОбъявленнойЦенностью = 34020,

        /// <summary>
        /// Parcel EMS optimal.
        /// EMS оптимальное.
        /// </summary>
        ParcelEmsOptimal = 34030,
        EmsОптимальное = 34030,

        /// <summary>
        /// Parcel EMS optimal with declared value and cash on delivery.
        /// EMS оптимальное с объявленной ценностью и наложенным платежом.
        /// </summary>
        ParcelEmsOptimalWithDeclaredValueAndCashOnDelivery = 34040,
        EmsОптимальноеСОбъявленнойЦенностьюИНаложеннымПлатежом = 34040,

        /// <summary>
        /// Parcel EMS optimal with declared value and mandatory payment.
        /// EMS оптимальное с объявленной ценностью и обязательным платежом.
        /// </summary>
        ParcelEmsOptimalWithDeclaredValueAndMandatoryPayment = 34060,
        EmsОптимальноеСОбъявленнойЦенностьюИОбязательнымПлатежом = 34060,

        /// <summary>
        /// Wrapper kit.
        /// Бандероль-комплект.
        /// </summary>
        WrapperKit = 35010,
        БандерольКомплект = 35010,

        /// <summary>
        /// Track-postcard.
        /// Трек-открытка.
        /// </summary>
        TrackPostcard = 36000,
        ТрекОткрытка = 36000,

        /// <summary>
        /// Track-letter.
        /// Трек-письмо.
        /// </summary>
        TrackLetter = 37000,
        ТрекПисьмо = 37000,

        /// <summary>
        /// Parcel EMS RT with declared value.
        /// EMS РТ с объявленной ценностью.
        /// </summary>
        ParcelEmsRtWithDeclaredValue = 41020,
        EmsРтСОбъявленнойЦенностью = 41020,

        /// <summary>
        /// Parcel EMS RT.
        /// EMS РТ.
        /// </summary>
        ParcelEmsRt = 41030,
        EmsРт = 41030,

        /// <summary>
        /// Parcel 1 class with declared value.
        /// Посылка 1 класса с объявленной ценностью.
        /// </summary>
        Parcel1ClassWithDeclaredValue = 47020,
        Посылка1КлассаСОбъявленнойЦенностью = 47020,

        /// <summary>
        /// Parcel 1 class.
        /// Посылка 1 класса.
        /// </summary>
        Parcel1Class = 47030,
        Посылка1Класса = 47030,

        /// <summary>
        /// Parcel 1 class with declared value and cash on delivery.
        /// Посылка 1 класса с объявленной ценностью и наложенным платежом.
        /// </summary>
        Parcel1ClassWithDeclaredValueAndCashOnDelivery = 47040,
        Посылка1КлассаСОбъявленнойЦенностьюИНаложеннымПлатежом = 47040,

        /// <summary>
        /// Parcel 1 class with declared value and mandatory payment.
        /// Посылка 1 класса с объявленной ценностью и обязательным платежом.
        /// </summary>
        Parcel1ClassWithDeclaredValueAndMandatoryPayment = 47060,
        Посылка1КлассаСОбъявленнойЦенностьюИОбязательнымПлатежом = 47060,

        /// <summary>
        /// Parcel Easy Return with declared Value.
        /// Посылка Легкий возврат с объявленной ценностью.
        /// </summary>
        ParcelEasyReturnWithDeclaredValue = 51020,
        ПосылкаЛегкийВозвратСОбъявленнойЦенностью = 51020,

        /// <summary>
        /// Parcel Easy return regular.
        /// Посылка Легкий возврат обыкновенная.
        /// </summary>
        ParcelEasyReturnRegular = 51030,
        ПосылкаЛегкийВозвратОбыкновенная = 51030,

        /// <summary>
        /// Parcel EMS Tender with declared value.
        /// EMS Тендер с объявленной ценностью.
        /// </summary>
        ParcelEmsTenderWithDeclaredValue = 52020,
        EmsТендерСОбъявленнойЦенностью = 52020,

        /// <summary>
        /// Parcel EMS Tender.
        /// EMS Тендер.
        /// </summary>
        ParcelEmsTender = 52030,
        EmsТендер = 52030,

        /// <summary>
        /// Parcel EMS Tender with declared value and cash on delivery.
        /// EMS Тендер с объявленной ценностью и наложенным платежом.
        /// </summary>
        ParcelEmsTenderWithDeclaredValueAndCashOnDelivery = 52040,
        EmsТендерСОбъявленнойЦенностьюИНаложеннымПлатежом = 52040,

        /// <summary>
        /// Parcel EMS Tender with declared value and mandatory payment.
        /// EMS Тендер с объявленной ценностью и обязательным платежом.
        /// </summary>
        ParcelEmsTenderWithDeclaredValueAndMandatoryPayment = 52060,
        EmsТендерСОбъявленнойЦенностьюИОбязательнымПлатежом = 52060,

        /// <summary>
        /// ECOM Marketplace with Declared Value.
        /// ЕКОМ Маркетплейс с объявленной ценностью.
        /// </summary>
        EcomMarketplaceWithDeclaredValue = 54020,
        ЕкомМаркетплейсСОбъявленнойЦенностью = 54020,

        /// <summary>
        /// ECOM Marketplace with declared value and mandatory payment.
        /// ЕКОМ Маркетплейс с объявленной ценностью и обязательным платежом.
        /// </summary>
        EcomMarketplaceWithDeclaredValueAndMandatoryPayment = 54060,
        ЕкомМаркетплейсСОбъявленнойЦенностьюИОбязательнымПлатежом = 54060,

        /// <summary>
        /// Acceptance of long-term powers of attorney for storage.
        /// Прием на хранение долгосрочных доверенностей.
        /// </summary>
        AcceptanceOfLongTermPowersOfAttorneyForStorage = 100813,
        ПриемНаХранениеДолгосрочныхДоверенностей = 100813,

        /// <summary>
        /// Unaddressed distribution of advertising and informational materials.
        /// Безадресное распространение рекламно-информационных материалов.
        /// </summary>
        UnaddressedDistributionOfAdvertisingAndInformationalMaterials = 301000,
        БезадресноеРаспространениеРекламноИнформационныхМатериалов = 301000,

        /// <summary>
        /// Issuance of advertising and information materials in OPS.
        /// Выдача рекламно-информационных материалов в ОПС.
        /// </summary>
        IssuanceOfAdvertisingAndInformationMaterialsInOps = 301100,
        ВыдачаРекламноИнформационныхМатериаловВОпс = 301100,

        /// <summary>
        /// Advertising in the Russian Post magazine.
        /// Размещение рекламы в журнале 'Почта России'.
        /// </summary>
        AdvertisingInTheRussianPostMagazine = 301120,
        РазмещениеРекламыВЖурналеПочтаРоссии = 301120,

        /// <summary>
        /// Advertising in the newspaper "Postal News".
        /// Размещение рекламы в газете 'Почтовые вести'.
        /// </summary>
        AdvertisingInTheNewspaperPostalNews = 301130,
        РазмещениеРекламыВГазетеПочтовыеВести = 301130,

        /// <summary>
        /// Email newsletter.
        /// Email рассылка.
        /// </summary>
        EmailNewsletter = 301200,
        EmailРассылка = 301200,

        /// <summary>
        /// SMS mailing.
        /// SMS рассылка.
        /// </summary>
        SmsMailing = 301210,
        SmsРассылка = 301210,

        /// <summary>
        /// Reception of the migration notification of arrival.
        /// Прием миграционного уведомления о прибытии.
        /// </summary>
        ReceptionOfTheMigrationNotificationOfArrival = 302000,
        ПриемМиграционногоУведомленияОПрибытии = 302000,

        /// <summary>
        /// Acceptance of the migration notice of residence.
        /// Прием миграционного уведомления о проживании.
        /// </summary>
        AcceptanceOfTheMigrationNoticeOfResidence = 302010,
        ПриемМиграционногоУведомленияОПроживании = 302010,

        /// <summary>
        /// Verification of the migration notice of employment.
        /// Проверка миграционного уведомления о трудовой деятельности.
        /// </summary>
        VerificationOfTheMigrationNoticeOfEmployment = 302020,
        ПроверкаМиграционногоУведомленияОТрудовойДеятельности = 302020,

        /// <summary>
        /// Notification of dual citizenship.
        /// Уведомление о двойном гражданстве.
        /// </summary>
        NotificationOfDualCitizenship = 302030,
        УведомлениеОДвойномГражданстве = 302030,

        /// <summary>
        /// Acceptance of the migration notice of departure.
        /// Прием миграционного уведомления об убытии.
        /// </summary>
        AcceptanceOfTheMigrationNoticeOfDeparture = 302040,
        ПриемМиграционногоУведомленияОбУбытии = 302040,

        /// <summary>
        /// Regular email.
        /// Электронное простое письмо.
        /// </summary>
        RegularEmail = 303000,
        ЭлектронноеПростоеПисьмо = 303000,

        /// <summary>
        /// Registered email.
        /// Электронное заказное письмо.
        /// </summary>
        RegisteredEmail = 303010,
        ЭлектронноеЗаказноеПисьмо = 303010,

        /// <summary>
        /// International electronic registered letter.
        /// Международное электронное заказное письмо.
        /// </summary>
        InternationalElectronicRegisteredLetter = 303011,
        МеждународноеЭлектронноеЗаказноеПисьмо = 303011,

        /// <summary>
        /// Accepting subscription and delivery orders.
        /// Прием заказов на подписку и доставку.
        /// </summary>
        AcceptingSubscriptionAndDeliveryOrders = 304150,
        ПриемЗаказовНаПодпискуИДоставку = 304150,

        /// <summary>
        /// Subscription forwarding initiated by the subscriber.
        /// Переадресация подписки по инициативе подписчика.
        /// </summary>
        SubscriptionForwardingInitiatedByTheSubscriber = 304160,
        ПереадресацияПодпискиПоИнициативеПодписчика = 304160,

        /// <summary>
        /// Cancellation of subscription at the subscriber's initiative.
        /// Аннулирование подписки по инициативе подписчика.
        /// </summary>
        CancellationOfSubscriptionAtTheSubscriberSInitiative = 304170,
        АннулированиеПодпискиПоИнициативеПодписчика = 304170,

        /// <summary>
        /// Courier fee.
        /// Курьерский сбор.
        /// </summary>
        CourierFee = 305000,
        КурьерскийСбор = 305000,

        /// <summary>
        /// Acceptance of mandatory payment.
        /// Прием обязательного платежа.
        /// </summary>
        AcceptanceOfMandatoryPayment = 305010,
        ПриемОбязательногоПлатежа = 305010,

        /// <summary>
        /// Extension of the storage period.
        /// Продление срока хранения.
        /// </summary>
        ExtensionOfTheStoragePeriod = 305020,
        ПродлениеСрокаХранения = 305020,

        /// <summary>
        /// Filling out an application for the extension of the storage period.
        /// Заполнение заявления на продление срока хранения.
        /// </summary>
        FillingOutAnApplicationForTheExtensionOfTheStoragePeriod = 305021,
        ЗаполнениеЗаявленияНаПродлениеСрокаХранения = 305021,

        /// <summary>
        /// Delivery of unconverted invoices/notices.
        /// Доставка неконвертованных счетов/извещений.
        /// </summary>
        DeliveryOfUnconvertedInvoicesNotices = 305100,
        ДоставкаНеконвертованныхСчетовИзвещений = 305100,

        /// <summary>
        /// Delivery by rail of containers with invoices/notices.
        /// Доставка железнодорожным транспортом емкостей со счетами/извещениями.
        /// </summary>
        DeliveryByRailOfContainersWithInvoicesNotices = 305110,
        ДоставкаЖелезнодорожнымТранспортомЕмкостейСоСчетамиИзвещениями = 305110,

        /// <summary>
        /// Air transport delivery of containers with invoices/notices.
        /// Доставка авиатранспортом емкостей со счетами/извещениями.
        /// </summary>
        AirTransportDeliveryOfContainersWithInvoicesNotices = 305120,
        ДоставкаАвиатранспортомЕмкостейСоСчетамиИзвещениями = 305120,

        /// <summary>
        /// Exchange rate.
        /// Курс валют.
        /// </summary>
        ExchangeRate = 305200,
        КурсВалют = 305200,

        /// <summary>
        /// Conducting a survey in electronic form.
        /// Проведение опроса в электронном виде.
        /// </summary>
        ConductingASurveyInElectronicForm = 305210,
        ПроведениеОпросаВЭлектронномВиде = 305210,

        /// <summary>
        /// Conducting a survey in paper form.
        /// Проведение опроса в бумажном виде.
        /// </summary>
        ConductingASurveyInPaperForm = 305220,
        ПроведениеОпросаВБумажномВиде = 305220,

        /// <summary>
        /// Delivery from the sender to the OPS.
        /// Доставка от отправителя в ОПС.
        /// </summary>
        DeliveryFromTheSenderToTheOps = 305300,
        ДоставкаОтОтправителяВОпс = 305300,

        /// <summary>
        /// Delivery to the recipient from the OPS.
        /// Доставка получателю из ОПС.
        /// </summary>
        DeliveryToTheRecipientFromTheOps = 305305,
        ДоставкаПолучателюИзОпс = 305305,

        /// <summary>
        /// Scanning shipments.
        /// Сканирование отправлений.
        /// </summary>
        ScanningShipments = 305401,
        СканированиеОтправлений = 305401,

        /// <summary>
        /// Digitization of shipments.
        /// Оцифровка отправлений.
        /// </summary>
        DigitizationOfShipments = 305402,
        ОцифровкаОтправлений = 305402,

        /// <summary>
        /// Document transfer.
        /// Передача документа.
        /// </summary>
        DocumentTransfer = 305403,
        ПередачаДокумента = 305403,

        /// <summary>
        /// Temporary storage of the document.
        /// Временное хранение документа.
        /// </summary>
        TemporaryStorageOfTheDocument = 305404,
        ВременноеХранениеДокумента = 305404,

        /// <summary>
        /// Disposal of documents.
        /// Утилизация документов.
        /// </summary>
        DisposalOfDocuments = 305405,
        УтилизацияДокументов = 305405,

        /// <summary>
        /// Automated data verification.
        /// Автоматизированная верификация данных.
        /// </summary>
        AutomatedDataVerification = 305601,
        АвтоматизированнаяВерификацияДанных = 305601,

        /// <summary>
        /// Verification of data on the ground.
        /// Верификация данных на местности.
        /// </summary>
        VerificationOfDataOnTheGround = 305602,
        ВерификацияДанныхНаМестности = 305602,

        /// <summary>
        /// Forwarding CargoXL.
        /// Экспедирование CargoXL.
        /// </summary>
        ForwardingCargoxl = 306120,
        ЭкспедированиеCargoxl = 306120,

        /// <summary>
        /// FTL Forwarding.
        /// Экспедирование FTL.
        /// </summary>
        FtlForwarding = 306140,
        ЭкспедированиеFtl = 306140,

        /// <summary>
        /// CargoXL Forwarding Service.
        /// Услуга при экспедировании CargoXL.
        /// </summary>
        CargoxlForwardingService = 306190,
        УслугаПриЭкспедированииCargoxl = 306190,

        /// <summary>
        /// Marked postal envelopes.
        /// Маркированые почтовые конверты.
        /// </summary>
        MarkedPostalEnvelopes = 307110,
        МаркированыеПочтовыеКонверты = 307110,

        /// <summary>
        /// Marked postcards.
        /// Маркированые почтовые карточки.
        /// </summary>
        MarkedPostcards = 307120,
        МаркированыеПочтовыеКарточки = 307120,

        /// <summary>
        /// Transmission of an internal telegram, per word.
        /// Передача внутренней телеграммы, за слово.
        /// </summary>
        TransmissionOfAnInternalTelegramPerWord = 308000,
        ПередачаВнутреннейТелеграммыЗаСлово = 308000,

        /// <summary>
        /// Compiling a list of f.103 for batch mailings for 1 postal item (line).
        /// Составление списка ф.103 на партионные почтовые отправления за 1 почтовое отправление (строку).
        /// </summary>
        CompilingAListOfF103ForBatchMailingsFor1PostalItemLine = 311000,
        СоставлениеСпискаФ103НаПартионныеПочтовыеОтправленияЗа1ПочтовоеОтправлениеСтроку = 311000,

        /// <summary>
        /// Subscription of a subscription mailbox cell in the OPS.
        /// Абонирование ячейки абонементного почтового шкафа в ОПС.
        /// </summary>
        SubscriptionOfASubscriptionMailboxCellInTheOps = 312010,
        АбонированиеЯчейкиАбонементногоПочтовогоШкафаВОпс = 312010,

        /// <summary>
        /// Subscription of the AAPS cell outside the OPS.
        /// Абонирование ячейки ААПС вне ОПС.
        /// </summary>
        SubscriptionOfTheAapsCellOutsideTheOps = 312011,
        АбонированиеЯчейкиАапсВнеОпс = 312011,

        /// <summary>
        /// Delivery of registered written correspondence with a controlled response by the OPS operator.
        /// Вручение регистрируемой письменной корреспонденции с контролируемым ответом оператором ОПC.
        /// </summary>
        DeliveryOfRegisteredWrittenCorrespondenceWithAControlledResponseByTheOpsOperator = 314000,
        ВручениеРегистрируемойПисьменнойКорреспонденцииСКонтролируемымОтветомОператоромОпc = 314000,

        /// <summary>
        /// SMS notification of the receipt of the internal RPO in the OPS / about the delivery of the internal RPO to the addressee.
        /// SMS-уведомление о поступлении внутреннего РПО в ОПС / о вручении внутреннего РПО адресату.
        /// </summary>
        SmsNotificationOfTheReceiptOfTheInternalRpoInTheOpsAboutTheDeliveryOfTheInternalRpoToTheAddressee = 316000,
        SmsУведомлениеОПоступленииВнутреннегоРпоВОпсОВрученииВнутреннегоРпоАдресату = 316000,

        /// <summary>
        /// Putting the address on written correspondence when receiving party mail by the OPS operator (for 1 postal item).
        /// Нанесение адреса на письменной корреспонденции при приеме партинной почты оператором ОПС (за 1 почтовое отправление).
        /// </summary>
        PuttingTheAddressOnWrittenCorrespondenceWhenReceivingPartyMailByTheOpsOperatorFor1PostalItem = 325000,
        НанесениеАдресаНаПисьменнойКорреспонденцииПриПриемеПартиннойПочтыОператоромОпсЗа1ПочтовоеОтправление = 325000,

        /// <summary>
        /// Making changes to the subscription catalog for third-party organizations of subscription agencies.
        /// Внесение изменений в подписной каталог для сторонних организаций подписных агентств.
        /// </summary>
        MakingChangesToTheSubscriptionCatalogForThirdPartyOrganizationsOfSubscriptionAgencies = 328000,
        ВнесениеИзмененийВПодписнойКаталогДляСтороннихОрганизацийПодписныхАгентств = 328000,

        /// <summary>
        /// Manual filling in of the postal money transfer form by the OPS operator (f.112EP).
        /// Ручное заполнение бланка почтового перевода денежных средств оператором ОПС (ф.112ЭП).
        /// </summary>
        ManualFillingInOfThePostalMoneyTransferFormByTheOpsOperatorF112ep = 329000,
        РучноеЗаполнениеБланкаПочтовогоПереводаДенежныхСредствОператоромОпсФ112эп = 329000,

        /// <summary>
        /// Registration of forms for written correspondence, including delivery notification forms (for 1 form).
        /// Оформление бланков к письменной корреспонденции, включая бланки уведомлений о вручении (за 1 бланк).
        /// </summary>
        RegistrationOfFormsForWrittenCorrespondenceIncludingDeliveryNotificationFormsFor1Form = 331000,
        ОформлениеБланковКПисьменнойКорреспонденцииВключаяБланкиУведомленийОВрученииЗа1Бланк = 331000,

        /// <summary>
        /// Pasting stamps on written correspondence by an OPS employee (for 1 postal item).
        /// Наклеивание марок на письменную корреспонденцию  сотрудником ОПС (за 1 почтовое отправление).
        /// </summary>
        PastingStampsOnWrittenCorrespondenceByAnOpsEmployeeFor1PostalItem = 332000,
        НаклеиваниеМарокНаПисьменнуюКорреспонденциюСотрудникомОпсЗа1ПочтовоеОтправление = 332000,

        /// <summary>
        /// Wrapping of written correspondence at the party reception (without the cost of the envelope).
        /// Конвертование письменной корреспонденции при партионном приеме (без стоимости конверта).
        /// </summary>
        WrappingOfWrittenCorrespondenceAtThePartyReceptionWithoutTheCostOfTheEnvelope = 333000,
        КонвертованиеПисьменнойКорреспонденцииПриПартионномПриемеБезСтоимостиКонверта = 333000,

        /// <summary>
        /// Packaging of written correspondence when receiving batch mail by the OPS operator (for 1 postal item without the cost of packaging material).
        /// Упаковка письменной корреспонденции при приеме партионной почты оператором ОПС (за 1 почтовое отправление без стоимости упаковочного материала).
        /// </summary>
        PackagingOfWrittenCorrespondenceWhenReceivingBatchMailByTheOpsOperatorFor1PostalItemWithoutTheCostOfPackagingMaterial = 335000,
        УпаковкаПисьменнойКорреспонденцииПриПриемеПартионнойПочтыОператоромОпсЗа1ПочтовоеОтправлениеБезСтоимостиУпаковочногоМатериала = 335000,

        /// <summary>
        /// Franking of written correspondence with the application of the GZPO imprint on 1 postal item or sticker.
        /// Франкирование письменной корреспонденции с нанесением оттиска ГЗПО на 1 почтовое отправление или стикер.
        /// </summary>
        FrankingOfWrittenCorrespondenceWithTheApplicationOfTheGzpoImprintOn1PostalItemOrSticker = 337000,
        ФранкированиеПисьменнойКорреспонденцииСНанесениемОттискаГзпоНа1ПочтовоеОтправлениеИлиСтикер = 337000,

        /// <summary>
        /// Sticker of an address sticker or with an impression of the GZPO when receiving batch mail by the OPS operator for 1 postal item (except parcels).
        /// Наклейка стикера адресного или с оттиском ГЗПО при приеме партионной почты оператором ОПС на 1 почтовое отправление (кроме посылок).
        /// </summary>
        StickerOfAnAddressStickerOrWithAnImpressionOfTheGzpoWhenReceivingBatchMailByTheOpsOperatorFor1PostalItemExceptParcels = 338000,
        НаклейкаСтикераАдресногоИлиСОттискомГзпоПриПриемеПартионнойПочтыОператоромОпсНа1ПочтовоеОтправлениеКромеПосылок = 338000,

        /// <summary>
        /// Storage of newspaper packs for 1 newspaper pack In OPS, starting from the first day of storage.
        /// Хранение газетных пачек за 1 газетную пачку В ОПС, начиная с первого дня хранения.
        /// </summary>
        StorageOfNewspaperPacksFor1NewspaperPackInOpsStartingFromTheFirstDayOfStorage = 343000,
        ХранениеГазетныхПачекЗа1ГазетнуюПачкуВОпсНачинаяСПервогоДняХранения = 343000,

        /// <summary>
        /// Box service: scheduled departures.
        /// Бокс-сервис: выезды по графику.
        /// </summary>
        BoxServiceScheduledDepartures = 348001,
        БоксСервисВыездыПоГрафику = 348001,

        /// <summary>
        /// Box service: trips to additional OPS.
        /// Бокс-сервис: выезды в дополнительное ОПС.
        /// </summary>
        BoxServiceTripsToAdditionalOps = 348002,
        БоксСервисВыездыВДополнительноеОпс = 348002,

        /// <summary>
        /// Box service: one-time trips.
        /// Бокс-сервис: разовые выезды.
        /// </summary>
        BoxServiceOneTimeTrips = 348003,
        БоксСервисРазовыеВыезды = 348003,

        /// <summary>
        /// Box service: a single advantage.
        /// Бокс-сервис: единичный перевес.
        /// </summary>
        BoxServiceASingleAdvantage = 348004,
        БоксСервисЕдиничныйПеревес = 348004,

        /// <summary>
        /// Acceptance of payment at the location (residence) of the client using a portable cash terminal (for one accepted payment).
        /// Прием платежа по месту расположения (проживания) клиента с применением переносного кассового терминала (за один принятый платеж).
        /// </summary>
        AcceptanceOfPaymentAtTheLocationResidenceOfTheClientUsingAPortableCashTerminalForOneAcceptedPayment = 350000,
        ПриемПлатежаПоМестуРасположенияПроживанияКлиентаСПрименениемПереносногоКассовогоТерминалаЗаОдинПринятыйПлатеж = 350000,

        /// <summary>
        /// Regional transportation of FIR.
        /// Региональная перевозка ППИ.
        /// </summary>
        RegionalTransportationOfFir = 350400,
        РегиональнаяПеревозкаПпи = 350400,

        /// <summary>
        /// Unfolding.
        /// Расфальцовка.
        /// </summary>
        Unfolding = 354000,
        Расфальцовка = 354000,

        /// <summary>
        /// Folding.
        /// Фальцовка.
        /// </summary>
        Folding = 355000,
        Фальцовка = 355000,

        /// <summary>
        /// Receiving money transfer at home.
        /// Прием перевода на дому.
        /// </summary>
        ReceivingMoneyTransferAtHome = 356000,
        ПриемПереводаНаДому = 356000,

        /// <summary>
        /// Notification of the delivery of postal money transfer within the framework of the provision of the Postal Money Transfer service.
        /// Уведомление о вручении почтового перевода в рамках оказания услуги "Почтовый перевод денежных средств".
        /// </summary>
        NotificationOfTheDeliveryOfPostalMoneyTransferWithinTheFrameworkOfTheProvisionOfThePostalMoneyTransferService = 357000,
        УведомлениеОВрученииПочтовогоПереводаВРамкахОказанияУслугиПочтовыйПереводДенежныхСредств = 357000,

        /// <summary>
        /// Comprehensive 3-in-1 service.
        /// Комплексный сервис 3-в-1.
        /// </summary>
        Comprehensive3In1Service = 369000,
        КомплексныйСервис3В1 = 369000,

        /// <summary>
        /// Information and technical support for online payments in the budget system of the Russian Federation.
        /// Информационно-техническая поддержка онлайн платежей в бюджетной системе РФ.
        /// </summary>
        InformationAndTechnicalSupportForOnlinePaymentsInTheBudgetSystemOfTheRussianFederation = 372000,
        ИнформационноТехническаяПоддержкаОнлайнПлатежейВБюджетнойСистемеРф = 372000,

        /// <summary>
        /// Loading and unloading of newspaper packs.
        /// Погрузка и разгрузка газетных пачек.
        /// </summary>
        LoadingAndUnloadingOfNewspaperPacks = 375000,
        ПогрузкаИРазгрузкаГазетныхПачек = 375000,

        /// <summary>
        /// Execution of the return of non-delivered written correspondence before the expiration of the storage/delivery period.
        /// Оформление возврата неврученной письменной корреспонденции до истечения срока хранения/вручения.
        /// </summary>
        ExecutionOfTheReturnOfNonDeliveredWrittenCorrespondenceBeforeTheExpirationOfTheStorageDeliveryPeriod = 378000,
        ОформлениеВозвратаНеврученнойПисьменнойКорреспонденцииДоИстеченияСрокаХраненияВручения = 378000,

        /// <summary>
        /// Provision of documents confirming payments for the specified period.
        /// Предоставление документов, подтверждающих выплаты за указанный период.
        /// </summary>
        ProvisionOfDocumentsConfirmingPaymentsForTheSpecifiedPeriod = 383000,
        ПредоставлениеДокументовПодтверждающихВыплатыЗаУказанныйПериод = 383000,

        /// <summary>
        /// Issuance of unclaimed postal items upon application (order).
        /// Выдача невостребованного почтового отправления по заявлению (распоряжению).
        /// </summary>
        IssuanceOfUnclaimedPostalItemsUponApplicationOrder = 384000,
        ВыдачаНевостребованногоПочтовогоОтправленияПоЗаявлениюРаспоряжению = 384000,

        /// <summary>
        /// Issuance of a copy of the telegram certified by the telecom operator.
        /// Выдача копии телеграммы, засвидетельствованной оператором связи.
        /// </summary>
        IssuanceOfACopyOfTheTelegramCertifiedByTheTelecomOperator = 387000,
        ВыдачаКопииТелеграммыЗасвидетельствованнойОператоромСвязи = 387000,

        /// <summary>
        /// Receipt of confirmation of delivery of the telegram to the addressee.
        /// Получение подтверждения о вручении телеграммы адресату.
        /// </summary>
        ReceiptOfConfirmationOfDeliveryOfTheTelegramToTheAddressee = 388000,
        ПолучениеПодтвержденияОВрученииТелеграммыАдресату = 388000,

        /// <summary>
        /// Issuing a certificate of the address of the sender of the telegram.
        /// Выдача справки об адресе отправителя телеграммы.
        /// </summary>
        IssuingACertificateOfTheAddressOfTheSenderOfTheTelegram = 389000,
        ВыдачаСправкиОбАдресеОтправителяТелеграммы = 389000,

        /// <summary>
        /// Repetition of a previously received telegram at the request of a telecommunications company.
        /// Повторение ранее полученной телеграммы по запросу телекоммуникационной компании.
        /// </summary>
        RepetitionOfAPreviouslyReceivedTelegramAtTheRequestOfATelecommunicationsCompany = 390000,
        ПовторениеРанееПолученнойТелеграммыПоЗапросуТелекоммуникационнойКомпании = 390000,

        /// <summary>
        /// Sending and delivery of a telegram to another address specified by the addressee.
        /// Досылка и доставка телеграммы по другому указанному адресатом адресу.
        /// </summary>
        SendingAndDeliveryOfATelegramToAnotherAddressSpecifiedByTheAddressee = 392000,
        ДосылкаИДоставкаТелеграммыПоДругомуУказанномуАдресатомАдресу = 392000,

        /// <summary>
        /// Delivery of the telegram on demand to the full address specified by the addressee.
        /// Доставка телеграммы до востребования по указанному адресатом полному адресу.
        /// </summary>
        DeliveryOfTheTelegramOnDemandToTheFullAddressSpecifiedByTheAddressee = 393000,
        ДоставкаТелеграммыДоВостребованияПоУказанномуАдресатомПолномуАдресу = 393000,

        /// <summary>
        /// Registration and re-registration of a conditional or abbreviated address of a legal entity for the delivery of telegrams.
        /// Регистрация и перерегистрация условного или сокращенного адреса юридического лица для доставки телеграмм.
        /// </summary>
        RegistrationAndReRegistrationOfAConditionalOrAbbreviatedAddressOfALegalEntityForTheDeliveryOfTelegrams = 394000,
        РегистрацияИПеререгистрацияУсловногоИлиСокращенногоАдресаЮридическогоЛицаДляДоставкиТелеграмм = 394000,

        /// <summary>
        /// Cancellation of the transmitted internal telegram.
        /// Аннулирование переданной телеграммы внутренней.
        /// </summary>
        CancellationOfTheTransmittedInternalTelegram = 395000,
        АннулированиеПереданнойТелеграммыВнутренней = 395000,

        /// <summary>
        /// Cancellation of the transmitted internal telegram with notification.
        /// Аннулирование переданной телеграммы внутренней с уведомлением.
        /// </summary>
        CancellationOfTheTransmittedInternalTelegramWithNotification = 396000,
        АннулированиеПереданнойТелеграммыВнутреннейСУведомлением = 396000,

        /// <summary>
        /// Other additional services to telegrams.
        /// Другие дополнительные услуги к телеграммам.
        /// </summary>
        OtherAdditionalServicesToTelegrams = 401000,
        ДругиеДополнительныеУслугиКТелеграммам = 401000,

        /// <summary>
        /// Photocopying for 1 page of the "AH" format.
        /// Ксерокопирование за 1 страницу формата "АХ".
        /// </summary>
        PhotocopyingFor1PageOfTheAhFormat = 404000,
        КсерокопированиеЗа1СтраницуФорматаАх = 404000,

        /// <summary>
        /// Storage and receipt of postal items and PPI in the OPS (in accordance with the application /order).
        /// Хранение и получение в ОПС почтовых отправлений и ППИ (в соответствии с заявлением /распоряжением).
        /// </summary>
        StorageAndReceiptOfPostalItemsAndPpiInTheOpsInAccordanceWithTheApplicationOrder = 405000,
        ХранениеИПолучениеВОпсПочтовыхОтправленийИПпиВСоответствииСЗаявлениемРаспоряжением = 405000,

        /// <summary>
        /// Notification of delivery by telegraph.
        /// Уведомление о вручении телеграфом.
        /// </summary>
        NotificationOfDeliveryByTelegraph = 414000,
        УведомлениеОВрученииТелеграфом = 414000,

        /// <summary>
        /// Notification of delivery by telegraph urgent.
        /// Уведомление о вручении телеграфом срочное.
        /// </summary>
        NotificationOfDeliveryByTelegraphUrgent = 415000,
        УведомлениеОВрученииТелеграфомСрочное = 415000,

        /// <summary>
        /// Telegram delivery (telegraph collection).
        /// Доставка телеграмм (телеграфный сбор).
        /// </summary>
        TelegramDeliveryTelegraphCollection = 418000,
        ДоставкаТелеграммТелеграфныйСбор = 418000,
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
