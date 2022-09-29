﻿namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Additional service types.
    /// Типы дополнительных услуг или вариантов расчета.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Appendix 2)
    /// </summary>
    public enum ServiceType
    {
        ПростоеУведомлениеОВручении = 1,
        ЗаказноеУведомлениеОВручении = 2,
        ОтметкаОсторожноХрупкая = 4,
        ОтметкаОпасныйГруз = 5,
        ГромоздкаяПосылка = 6,
        ДоставкаНарочным = 7,
        ВручениеЛичноВРуки = 8,
        ДоставкаДокументов = 9,
        ДоставкаТоваров = 10,
        Доставка = 11,
        НестандартныйРазмерНегабарит=12,
        ПлатаЗаОц = 13,
        СтрахованиеОтправления = 14,
        ДоставкаВТруднодоступноеОпс = 15,
        ПриемВТруднодоступномОпс = 16,
        ПлатаЗаЗаказ = 17,
        НадбавкаЗаНаложенныйПлатеж = 18,
        НадбавкаЗаОбъемныйВес = 19,
        СмсУведомлениеОПрибытииВОтделение = 20,
        СмсУведомлениеОВручении = 21,
        ПроверкаСоответствияВложенияОписи = 22,
        СоставлениеОписиВложения = 23,
        ОплатаНаложенногоПлатежаОтправителем = 24,
        ТаможенныйСбор = 25,
        ДоставкаКурьером = 26,
        УпаковкаПочтаРоссии = 27,
        КорпоративныйКлиентПочтаРоссии = 28,
        ДоставкаПочтовогоПереводаНаДом = 29,
        УведомлениеОВрученииПочтовогоПеревода = 30,
        ЗаверительныйПакет = 31,
        ГарантияСохранности = 32,
        ОтчётОНедоставленныхОтправлениях = 33,
        НанесениеШк = 34,
        УпаковкаВложений = 35,
        НанесениеСтикера = 36,
        ПеревозкаИСдача = 37,
        ПроверкаКомплектности = 38,
        ЗаявлениеОВозвратеИзмененииИлиИсправленииАдреса = 39,
        ДоставкаВНаселённыйПунктНеИмеющийТелеграфнойИФаксимильнойСвязи = 40,
        ПакетСмсУведомленийОтправителюПриЕдиничномПриеме = 41,
        ПакетСмсУведомленийПолучателюПриЕдиничномПриеме = 42,
        ПакетСмсУведомленийОтправителюПриПартионномПриеме = 43,
        ПакетСмсУведомленийПолучателюПриПартионномПриеме = 44,
        ПролонгацияДоговора = 45,
        ОплатаВМоментДоставки = 46,
        НаклеиваниеМарок = 47,
        Административное = 48,
        Выборное = 49,
        ВозвратныйТариф = 50,
        Правительственное = 51,
        Воинское = 52,
        Служебное = 53,
        Судебное = 54,
        Президентское = 55,
        Кредитное = 56,
        Межоператорское = 57,
        ВручениеВОпс = 58,
        ПредпочтоваяПодготовка = 59,
        АгентскиеФункцииТретьимЛицам = 60,
        ДоставкаПоЗвонку = 61,
        ЭлектронноеУведомлениеОВручении = 62,
        ОбслуживаниеКонсолидаторов = 63,
        ПакетСмсСервис = 64,
        КурьерскийСбор = 65,
        ВозвратСопроводительныхДокументов = 66,
        ВыдачаЧерезАпс = 67,
        ДоставкаИВручениеПочтальонамиМелкихПакетовНаДому = 68,
        ЗаборВозвратаКурьеромПоАдресуПолучателя = 69,
        НаличиеИндивидуальногоДоговораСПредприятиемПочтовойСвязи = 70,
        СмсУведомлениеОбИстеченииСрокаХранения = 71,
        СмсУведомлениеОПродленииСрокаХранения = 72,
        СмсУведомлениеОбИстеченииВторогоСрокаХранения = 73,
        СмсУведомлениеОВозвратеОтправления = 74,
        СмсУведомлениеОПоступленииОтправленияВКурьерскуюСлужбу = 75,
        СмсУведомлениеОПередачиОтправленияКурьеруДляДоставки = 76,
        СмсУведомлениеОНеудачнойПопыткеДоставкиОтправленияАдресату = 77,
        СмсУведомлениеОВторойНеудачнойПопыткеДоставкиОтправленияАдресату = 78,
        НадбавкаЗаСтоимостьВложения = 79,
        ЗаборОтправленияУОтправителя = 80,
        ПростаяПроверкаВложения = 81,
        ПроверкаВложенияПримеркой = 82,
        ПроверкаВложенияНаРаботоспособность = 83,
        ДоставкаВСогласованноеВремя = 84,
        ВозвратПослеПроверкиПолный = 85,
        ВозвратПослеПроверкиЧастичный = 86,
        ВозвратРанееПолученногоТовара = 87,
        Предоплаченное = 88,
        Предзаполненное = 89,
        ПродлениеСрокаХранения = 90,
        Переадресация = 91,
        ПриемНаТерриторииОтправителя = 92,
        ДоставкаВозвратаОтправителю = 93,
        ВиджетПунктовВыдачи = 94,
        БесплатноеХранениеДо7Дней = 95,
        ВремяРаботыПвзИПочтаматовВВечернееВремя = 96,
        ДоставкаДоОпсИПартнерскихПвзИПочтаматов = 97,
        ДоставкаИВыдачаВВыходныеДни = 98,
        ПогрузкаРазгрузкаОтправленийПриСбореСоСклада = 99,
        ПолучениеИнформацииОДвиженииОтправленияВРеальномВремени = 100,
        УведомлениеОтправителя = 101,
        УправлениеДоставкой = 102,
        ИдентификацияПолучателяПоПинКоду = 103,
        ПриемЧерезМобильноеПриложение = 104,
        УпрощенныйПрием = 105,
        Тарификация = 110,
        РасчетКонтрольныхСроков = 111,
        ПроверкаВходныхПараметров = 112,
        ПризнакДополнительнаяУслуга = 118,
        НадбавкаЗаМестоВручения = 120,
        Перегрузка = 121,
        ТарифАвиаперевозчика = 122,
        ПочтовыйСбор = 123,
        НадбавкаЗаПеревес = 124,
        КомбинированнаяДоставка = 125,
        НормативныйСрокДоставкиВнутриСтраны = 130,
        НормативныйСрокДоставкиМеждународнойЧасти = 131,
        СрокСУчетомРасписанияРаботы = 132,
        ШтрафЗаКачествоДоставки = 133,
        БонусЗаКачествоДоставки = 134,
        ИменнаяЯчейка = 137,
        ВложениеРегистрируемыхОтправлений = 138,
        ОбрешеткаГруза = 139,
        ЗаполнениеИПечатьТаможеннойДекларации = 140,
        РасширеннаяВерификацияАдреса = 142,

        SimpleDeliveryNotification = 1,
        RegisteredDeliveryNotification = 2,
        MarkСarefulFragile = 4,
        MarkDangerousCargo = 5,
        BulkyPackage = 6,
        DeliveryByExpress = 7,
        DeliveryInPerson = 8,
        DocumentDelivery = 9,
        DeliveryOfGoods = 10,
        Delivery = 11,
        NonStandardSizeOversized = 12,
        OcFee = 13,
        DepartureInsurance = 14,
        DeliveryToHardToReachOps = 15,
        ReceptionInARemoteOps = 16,
        OrderFee = 17,
        CashOnDeliverySurcharge = 18,
        BulkWeightAllowance = 19,
        SmsNotificationOfArrivalAtTheBranch = 20,
        SmsNotificationOfDelivery = 21,
        CheckingTheComplianceOfTheInventoryAttachment = 22,
        MakingAnInventoryOfAttachments = 23,
        PaymentOfCashOnDeliveryByTheSender = 24,
        CustomsDuty = 25,
        DeliveryByCourier = 26,
        PackagingRussianPost = 27,
        CorporateClientRussianPost = 28,
        HomeDeliveryOfPostalOrder = 29,
        NotificationOfDeliveryOfPostalOrder = 30,
        CertificationPackage = 31,
        SafetyGuarantee = 32,
        UndeliveredItemsReport = 33,
        ApplicationofWk = 34,
        PackingOfAttachments = 35,
        StickerApplication = 36,
        TransportationAndDelivery = 37,
        CompletenessCheck = 38,
        ApplicationForTheReturnChangeOrCorrectionOfTheAddress = 39,
        DeliveryToALocalityThatDoesNotHaveTelegraphicAndFacsimileCommunication = 40,
        SmsNotificationsPackageToTheSenderAtASingleReception = 41,
        SmsNotificationsPackageToTheRecipientAtASingleReception = 42,
        SmsNotificationsPackageToTheSenderAtBatchReception = 43,
        SmsNotificationsPackageToTheRecipientAtBatchReception = 44,
        ContractProlongation = 45,
        PaymentAtTheTimeOfDelivery = 46,
        StickingStamps = 47,
        Administrative = 48,
        Elective = 49,
        ReturnRate = 50,
        Government = 51,
        Military = 52,
        Service = 53,
        Judicial = 54,
        Presidential = 55,
        Credit = 56,
        Interoperational = 57,
        DeliveryInOps = 58,
        StartingPreparation = 59,
        AgencyFunctionsToThirdParties = 60,
        DeliveryByCall = 61,
        ElectronicDeliveryNotification = 62,
        MaintenanceOfConsolidators = 63,
        SmsServicePackage = 64,
        CourierFee = 65,
        ReturnOfAccompanyingDocuments = 66,
        IssuanceViaAps = 67,
        DeliveryAndDeliveryOfSmallPackagesByPostmenAtHome = 68,
        CollectionOfTheReturnByCourierToTheRecipientsAddress = 69,
        AvailabilityOfAnIndividualContractWithAPostalCommunicationCompany = 70,
        SmsNotificationOfExpirationOfTheStoragePeriod = 71,
        SmsNotificationOfTheExtensionOfTheStoragePeriod = 72,
        SmsNotificationOfTheExpirationOfTheSecondStoragePeriod = 73,
        SmsNotificationOfTheReturnOfTheShipment = 74,
        SmsNotificationOfReceiptOfTheShipmentToTheCourierService = 75,
        SmsNotificationOfTheTransferOfTheShipmentToTheCourierForDelivery = 76,
        SmsNotificationOfAnUnsuccessfulAttemptToDeliverTheShipmentToTheAddressee = 77,
        SmsNotificationOfTheSecondUnsuccessfulAttemptToDeliverTheShipmentToTheAddressee = 78,
        PremiumForTheCostOfInvestment = 79,
        CollectionOfTheShipmentFromTheSender = 80,
        SimpleAttachmentCheck = 81,
        CheckingTheAttachmentByFitting = 82,
        CheckingTheAttachmentForOperability = 83,
        DeliveryAtTheAgreedTime = 84,
        FullRefundAfterVerification = 85,
        PartialRefundAfterVerification = 86,
        ReturnOfPreviouslyReceivedGoods = 87,
        Prepaid = 88,
        Prefilled = 89,
        ExtensionOfShelfLife = 90,
        Redirection = 91,
        ReceptionOnTheSendersTerritory = 92,
        ReturnDeliveryToSender = 93,
        WidgetOfPickUpPoints = 94,
        FreeStorageUpTo7Days = 95,
        TheWorkingHoursOfThePvzAndPostOfficesInTheEvening = 96,
        DeliveryToOpsAndPartnerPvzAndPostOffices = 97,
        DeliveryAndDeliveryOnWeekends = 98,
        LoadingUnloadingOfShipmentsWhenCollectedFromTheWarehouse = 99,
        GettingInformationAboutTheMovementOfTheShipmentInRealTime = 100,
        SenderNotification = 101,
        DeliveryManagement = 102,
        IdentificationOfTheRecipientByPinCode = 103,
        ReceptionViaMobileApp = 104,
        SimplifiedReception = 105,
        Billing = 110,
        CalculationOfControlDates = 111,
        CheckingInputParameters = 112,
        TheAdditionalServiceAttribute = 118,
        PremiumForThePlaceOfDelivery = 120,
        Overload = 121,
        AirCarrierFare = 122,
        Postage = 123,
        OverweightAllowance = 124,
        CombinedDelivery = 125,
        StandardDeliveryTimeWithinTheCountry = 130,
        StandardDeliveryTimeOfTheInternationalPart = 131,
        CalculateDeliveryTermsTakingIntoAccountTheWorkSchedule = 132,
        PenaltyForTheQualityOfDelivery = 133,
        BonusForTheQualityOfDelivery = 134,
        NameCell = 137,
        AttachmentOfRegisteredItems = 138,
        CargoCrate = 139,
        FillingInAndPrintingTheCustomsDeclaration = 140,
        ExtendedAddressVerification = 142,
    }
}
