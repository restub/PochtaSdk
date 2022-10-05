namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Additional service types. 
    /// This enum is serialized as numbers, so it's not decorated with DataContract attribute.
    /// Типы дополнительных услуг или вариантов расчета.
    /// Перечисление сериализуется как числа, поэтому на нем нет атрибута DataContract.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Appendix 2)
    /// </summary>
    public enum ServiceType
    {
        /// <summary>
        /// Simple delivery notification.
        /// Простое уведомление о вручении.
        /// </summary>
        SimpleDeliveryNotification = 1,
        ПростоеУведомлениеОВручении = 1,

        /// <summary>
        /// Registered delivery notification.
        /// Заказное уведомление о вручении.
        /// </summary>
        RegisteredDeliveryNotification = 2,
        ЗаказноеУведомлениеОВручении = 2,

        /// <summary>
        /// Mark 'Careful/Fragile'.
        /// Отметка 'Осторожно/Хрупкая'.
        /// </summary>
        MarkCarefulFragile = 4,
        ОтметкаОсторожноХрупкая = 4,

        /// <summary>
        /// Mark 'Dangerous cargo'.
        /// Отметка 'Опасный груз'.
        /// </summary>
        MarkDangerousCargo = 5,
        ОтметкаОпасныйГруз = 5,

        /// <summary>
        /// Bulky package.
        /// Громоздкая посылка.
        /// </summary>
        BulkyPackage = 6,
        ГромоздкаяПосылка = 6,

        /// <summary>
        /// Delivery by express.
        /// Доставка нарочным.
        /// </summary>
        DeliveryByExpress = 7,
        ДоставкаНарочным = 7,

        /// <summary>
        /// Hand delivery in person.
        /// Вручение лично в руки.
        /// </summary>
        HandDeliveryInPerson = 8,
        ВручениеЛичноВРуки = 8,

        /// <summary>
        /// Document delivery.
        /// Доставка документов.
        /// </summary>
        DocumentDelivery = 9,
        ДоставкаДокументов = 9,

        /// <summary>
        /// Delivery of goods.
        /// Доставка товаров.
        /// </summary>
        DeliveryOfGoods = 10,
        ДоставкаТоваров = 10,

        /// <summary>
        /// Delivery.
        /// Доставка.
        /// </summary>
        Delivery = 11,
        Доставка = 11,

        /// <summary>
        /// Oversized.
        /// Негабарит.
        /// </summary>
        Oversized = 12,
        Негабарит = 12,

        /// <summary>
        /// Payment for OC.
        /// Плата за ОЦ.
        /// </summary>
        PaymentForOc = 13,
        ПлатаЗаОц = 13,

        /// <summary>
        /// Departure insurance.
        /// Страхование отправления.
        /// </summary>
        DepartureInsurance = 14,
        СтрахованиеОтправления = 14,

        /// <summary>
        /// Delivery to a remote OPS.
        /// Доставка в труднодоступное ОПС.
        /// </summary>
        DeliveryToARemoteOps = 15,
        ДоставкаВТруднодоступноеОпс = 15,

        /// <summary>
        /// Reception in a remote OPS.
        /// Прием в труднодоступном ОПС.
        /// </summary>
        ReceptionInARemoteOps = 16,
        ПриемВТруднодоступномОпс = 16,

        /// <summary>
        /// Order fee.
        /// Плата за заказ.
        /// </summary>
        OrderFee = 17,
        ПлатаЗаЗаказ = 17,

        /// <summary>
        /// Mark '18+'.
        /// Отметка '18+'.
        /// </summary>
        Mark18 = 18,
        Отметка18 = 18,

        /// <summary>
        /// SMS notification of arrival at the branch.
        /// СМС-уведомление о прибытии в отделение.
        /// </summary>
        SmsNotificationOfArrivalAtTheBranch = 20,
        СмсУведомлениеОПрибытииВОтделение = 20,

        /// <summary>
        /// SMS notification of delivery.
        /// СМС-уведомление о вручении.
        /// </summary>
        SmsNotificationOfDelivery = 21,
        СмсУведомлениеОВручении = 21,

        /// <summary>
        /// Checking the compliance of the inventory attachment.
        /// Проверка соответствия вложения описи.
        /// </summary>
        CheckingTheComplianceOfTheInventoryAttachment = 22,
        ПроверкаСоответствияВложенияОписи = 22,

        /// <summary>
        /// Making an inventory of the attachment.
        /// Составление описи вложения.
        /// </summary>
        MakingAnInventoryOfTheAttachment = 23,
        СоставлениеОписиВложения = 23,

        /// <summary>
        /// Payment of cash on delivery by the sender.
        /// Оплата наложенного платежа отправителем.
        /// </summary>
        PaymentOfCashOnDeliveryByTheSender = 24,
        ОплатаНаложенногоПлатежаОтправителем = 24,

        /// <summary>
        /// Customs duty.
        /// Таможенный сбор.
        /// </summary>
        CustomsDuty = 25,
        ТаможенныйСбор = 25,

        /// <summary>
        /// Delivery by courier.
        /// Доставка курьером.
        /// </summary>
        DeliveryByCourier = 26,
        ДоставкаКурьером = 26,

        /// <summary>
        /// Packaging 'Russian Post'.
        /// Упаковка 'Почта России'.
        /// </summary>
        PackagingRussianPost = 27,
        УпаковкаПочтаРоссии = 27,

        /// <summary>
        /// Corporate client 'Russian Post'.
        /// Корпоративный клиент 'Почта России'.
        /// </summary>
        CorporateClientRussianPost = 28,
        КорпоративныйКлиентПочтаРоссии = 28,

        /// <summary>
        /// Delivery of a postal order to your home.
        /// Доставка почтового перевода на дом.
        /// </summary>
        DeliveryOfAPostalOrderToYourHome = 29,
        ДоставкаПочтовогоПереводаНаДом = 29,

        /// <summary>
        /// Notification of delivery of a postal order.
        /// Уведомление о вручении почтового перевода.
        /// </summary>
        NotificationOfDeliveryOfAPostalOrder = 30,
        УведомлениеОВрученииПочтовогоПеревода = 30,

        /// <summary>
        /// Certification package.
        /// Заверительный пакет.
        /// </summary>
        CertificationPackage = 31,
        ЗаверительныйПакет = 31,

        /// <summary>
        /// Safety guarantee.
        /// Гарантия сохранности.
        /// </summary>
        SafetyGuarantee = 32,
        ГарантияСохранности = 32,

        /// <summary>
        /// Undelivered Shipments Report.
        /// Отчёт о недоставленных отправлениях.
        /// </summary>
        UndeliveredShipmentsReport = 33,
        ОтчётОНедоставленныхОтправлениях = 33,

        /// <summary>
        /// Application of WK.
        /// Нанесение ШК.
        /// </summary>
        ApplicationOfWk = 34,
        НанесениеШк = 34,

        /// <summary>
        /// Packaging of attachments.
        /// Упаковка вложений.
        /// </summary>
        PackagingOfAttachments = 35,
        УпаковкаВложений = 35,

        /// <summary>
        /// Applying a sticker.
        /// Нанесение стикера.
        /// </summary>
        ApplyingASticker = 36,
        НанесениеСтикера = 36,

        /// <summary>
        /// Transportation and delivery.
        /// Перевозка и сдача.
        /// </summary>
        TransportationAndDelivery = 37,
        ПеревозкаИСдача = 37,

        /// <summary>
        /// Checking the completeness.
        /// Проверка комплектности.
        /// </summary>
        CheckingTheCompleteness = 38,
        ПроверкаКомплектности = 38,

        /// <summary>
        /// Application for the return, change or correction of the address.
        /// Заявление о возврате, изменении или исправлении адреса.
        /// </summary>
        ApplicationForTheReturnChangeOrCorrectionOfTheAddress = 39,
        ЗаявлениеОВозвратеИзмененииИлиИсправленииАдреса = 39,

        /// <summary>
        /// Delivery to a locality that does not have telegraphic and facsimile communication.
        /// Доставка в населённый пункт, не имеющий телеграфной и факсимильной связи.
        /// </summary>
        DeliveryToALocalityThatDoesNotHaveTelegraphicAndFacsimileCommunication = 40,
        ДоставкаВНаселённыйПунктНеИмеющийТелеграфнойИФаксимильнойСвязи = 40,

        /// <summary>
        /// A package of SMS notifications to the sender at a single reception.
        /// Пакет СМС уведомлений отправителю при единичном приеме.
        /// </summary>
        APackageOfSmsNotificationsToTheSenderAtASingleReception = 41,
        ПакетСмсУведомленийОтправителюПриЕдиничномПриеме = 41,

        /// <summary>
        /// A package of SMS notifications to the recipient at a single reception.
        /// Пакет СМС уведомлений получателю при единичном приеме.
        /// </summary>
        APackageOfSmsNotificationsToTheRecipientAtASingleReception = 42,
        ПакетСмсУведомленийПолучателюПриЕдиничномПриеме = 42,

        /// <summary>
        /// A package of SMS notifications to the sender during batch reception.
        /// Пакет СМС уведомлений отправителю при партионном приеме.
        /// </summary>
        APackageOfSmsNotificationsToTheSenderDuringBatchReception = 43,
        ПакетСмсУведомленийОтправителюПриПартионномПриеме = 43,

        /// <summary>
        /// A package of SMS notifications to the recipient during batch reception.
        /// Пакет СМС уведомлений получателю при партионном приеме.
        /// </summary>
        APackageOfSmsNotificationsToTheRecipientDuringBatchReception = 44,
        ПакетСмсУведомленийПолучателюПриПартионномПриеме = 44,

        /// <summary>
        /// Prolongation of the contract.
        /// Пролонгация договора.
        /// </summary>
        ProlongationOfTheContract = 45,
        ПролонгацияДоговора = 45,

        /// <summary>
        /// Payment at the time of delivery (COD).
        /// Оплата в момент доставки (COD).
        /// </summary>
        PaymentAtTheTimeOfDeliveryCod = 46,
        ОплатаВМоментДоставкиCod = 46,

        /// <summary>
        /// Sticking stamps.
        /// Наклеивание марок.
        /// </summary>
        StickingStamps = 47,
        НаклеиваниеМарок = 47,

        /// <summary>
        /// Administrative.
        /// Административное.
        /// </summary>
        Administrative = 48,
        Административное = 48,

        /// <summary>
        /// Elective.
        /// Выборное.
        /// </summary>
        Elective = 49,
        Выборное = 49,

        /// <summary>
        /// Return rate.
        /// Возвратный тариф.
        /// </summary>
        ReturnRate = 50,
        ВозвратныйТариф = 50,

        /// <summary>
        /// Government.
        /// Правительственное.
        /// </summary>
        Government = 51,
        Правительственное = 51,

        /// <summary>
        /// Military.
        /// Воинское.
        /// </summary>
        Military = 52,
        Воинское = 52,

        /// <summary>
        /// Official.
        /// Служебное.
        /// </summary>
        Official = 53,
        Служебное = 53,

        /// <summary>
        /// Judicial.
        /// Судебное.
        /// </summary>
        Judicial = 54,
        Судебное = 54,

        /// <summary>
        /// Presidential.
        /// Президентское.
        /// </summary>
        Presidential = 55,
        Президентское = 55,

        /// <summary>
        /// Credit.
        /// Кредитное.
        /// </summary>
        Credit = 56,
        Кредитное = 56,

        /// <summary>
        /// Interoperational.
        /// Межоператорское.
        /// </summary>
        Interoperational = 57,
        Межоператорское = 57,

        /// <summary>
        /// Delivery in OPS.
        /// Вручение в ОПС.
        /// </summary>
        DeliveryInOps = 58,
        ВручениеВОпс = 58,

        /// <summary>
        /// Starting preparation.
        /// Предпочтовая подготовка.
        /// </summary>
        StartingPreparation = 59,
        ПредпочтоваяПодготовка = 59,

        /// <summary>
        /// Agency functions to third parties.
        /// Агентские функции третьим лицам.
        /// </summary>
        AgencyFunctionsToThirdParties = 60,
        АгентскиеФункцииТретьимЛицам = 60,

        /// <summary>
        /// Delivery by call.
        /// Доставка по звонку.
        /// </summary>
        DeliveryByCall = 61,
        ДоставкаПоЗвонку = 61,

        /// <summary>
        /// Electronic delivery notification.
        /// Электронное уведомление о вручении.
        /// </summary>
        ElectronicDeliveryNotification = 62,
        ЭлектронноеУведомлениеОВручении = 62,

        /// <summary>
        /// Maintenance of consolidators.
        /// Обслуживание консолидаторов.
        /// </summary>
        MaintenanceOfConsolidators = 63,
        ОбслуживаниеКонсолидаторов = 63,

        /// <summary>
        /// SMS Service Package.
        /// Пакет СМС-сервис.
        /// </summary>
        SmsServicePackage = 64,
        ПакетСмсСервис = 64,

        /// <summary>
        /// Courier fee.
        /// Курьерский сбор.
        /// </summary>
        CourierFee = 65,
        КурьерскийСбор = 65,

        /// <summary>
        /// Return of accompanying documents.
        /// Возврат сопроводительных документов.
        /// </summary>
        ReturnOfAccompanyingDocuments = 66,
        ВозвратСопроводительныхДокументов = 66,

        /// <summary>
        /// Issuance via APS.
        /// Выдача через АПС.
        /// </summary>
        IssuanceViaAps = 67,
        ВыдачаЧерезАпс = 67,

        /// <summary>
        /// Delivery and delivery at home.
        /// Доставка и вручение на дому.
        /// </summary>
        DeliveryAndDeliveryAtHome = 68,
        ДоставкаИВручениеНаДому = 68,

        /// <summary>
        /// Collection of the return by courier to the recipient's address.
        /// Забор возврата курьером по адресу получателя.
        /// </summary>
        CollectionOfTheReturnByCourierToTheRecipientSAddress = 69,
        ЗаборВозвратаКурьеромПоАдресуПолучателя = 69,

        /// <summary>
        /// Availability of an individual contract with a postal communication company.
        /// Наличие индивидуального договора с предприятием почтовой связи.
        /// </summary>
        AvailabilityOfAnIndividualContractWithAPostalCommunicationCompany = 70,
        НаличиеИндивидуальногоДоговораСПредприятиемПочтовойСвязи = 70,

        /// <summary>
        /// SMS notification of expiration of the storage period.
        /// СМС-уведомление об истечении срока хранения.
        /// </summary>
        SmsNotificationOfExpirationOfTheStoragePeriod = 71,
        СмсУведомлениеОбИстеченииСрокаХранения = 71,

        /// <summary>
        /// SMS notification of the extension of the storage period.
        /// СМС-уведомление о продлении срока хранения.
        /// </summary>
        SmsNotificationOfTheExtensionOfTheStoragePeriod = 72,
        СмсУведомлениеОПродленииСрокаХранения = 72,

        /// <summary>
        /// SMS notification of the expiration of the second storage period.
        /// СМС-уведомление об истечении второго срока хранения.
        /// </summary>
        SmsNotificationOfTheExpirationOfTheSecondStoragePeriod = 73,
        СмсУведомлениеОбИстеченииВторогоСрокаХранения = 73,

        /// <summary>
        /// SMS notification of the return of the shipment.
        /// СМС-уведомление о возврате отправления.
        /// </summary>
        SmsNotificationOfTheReturnOfTheShipment = 74,
        СмсУведомлениеОВозвратеОтправления = 74,

        /// <summary>
        /// SMS notification of receipt of the shipment to the courier service.
        /// СМС-уведомление о поступлении отправления в курьерскую службу.
        /// </summary>
        SmsNotificationOfReceiptOfTheShipmentToTheCourierService = 75,
        СмсУведомлениеОПоступленииОтправленияВКурьерскуюСлужбу = 75,

        /// <summary>
        /// SMS notification about the transfer of the shipment to the courier for delivery.
        /// СМС-уведомление о передачи отправления курьеру для доставки.
        /// </summary>
        SmsNotificationAboutTheTransferOfTheShipmentToTheCourierForDelivery = 76,
        СмсУведомлениеОПередачиОтправленияКурьеруДляДоставки = 76,

        /// <summary>
        /// SMS notification of an unsuccessful attempt to deliver a shipment to the addressee.
        /// СМС-уведомление о неудачной попытке доставки отправления адресату.
        /// </summary>
        SmsNotificationOfAnUnsuccessfulAttemptToDeliverAShipmentToTheAddressee = 77,
        СмсУведомлениеОНеудачнойПопыткеДоставкиОтправленияАдресату = 77,

        /// <summary>
        /// SMS notification of the second unsuccessful attempt to deliver the shipment to the addressee.
        /// СМС-уведомление о второй неудачной попытке доставки отправления адресату.
        /// </summary>
        SmsNotificationOfTheSecondUnsuccessfulAttemptToDeliverTheShipmentToTheAddressee = 78,
        СмсУведомлениеОВторойНеудачнойПопыткеДоставкиОтправленияАдресату = 78,

        /// <summary>
        /// Premium for the cost of investment.
        /// Надбавка за стоимость вложения.
        /// </summary>
        PremiumForTheCostOfInvestment = 79,
        НадбавкаЗаСтоимостьВложения = 79,

        /// <summary>
        /// Taking the shipment from the sender.
        /// Забор отправления у отправителя.
        /// </summary>
        TakingTheShipmentFromTheSender = 80,
        ЗаборОтправленияУОтправителя = 80,

        /// <summary>
        /// Checking the attachment upon delivery.
        /// Проверка вложения при вручении.
        /// </summary>
        CheckingTheAttachmentUponDelivery = 81,
        ПроверкаВложенияПриВручении = 81,

        /// <summary>
        /// Checking the attachment by fitting.
        /// Проверка вложения примеркой.
        /// </summary>
        CheckingTheAttachmentByFitting = 82,
        ПроверкаВложенияПримеркой = 82,

        /// <summary>
        /// Checking the attachment for operability.
        /// Проверка вложения на работоспособность.
        /// </summary>
        CheckingTheAttachmentForOperability = 83,
        ПроверкаВложенияНаРаботоспособность = 83,

        /// <summary>
        /// Delivery at the agreed time.
        /// Доставка в согласованное время.
        /// </summary>
        DeliveryAtTheAgreedTime = 84,
        ДоставкаВСогласованноеВремя = 84,

        /// <summary>
        /// Full refund after verification.
        /// Возврат после проверки полный.
        /// </summary>
        FullRefundAfterVerification = 85,
        ВозвратПослеПроверкиПолный = 85,

        /// <summary>
        /// Partial refund after verification.
        /// Возврат после проверки частичный.
        /// </summary>
        PartialRefundAfterVerification = 86,
        ВозвратПослеПроверкиЧастичный = 86,

        /// <summary>
        /// Return of previously received goods.
        /// Возврат ранее полученного товара.
        /// </summary>
        ReturnOfPreviouslyReceivedGoods = 87,
        ВозвратРанееПолученногоТовара = 87,

        /// <summary>
        /// Prepaid.
        /// Предоплаченное.
        /// </summary>
        Prepaid = 88,
        Предоплаченное = 88,

        /// <summary>
        /// Pre - filled.
        /// Предзаполненное.
        /// </summary>
        PreFilled = 89,
        Предзаполненное = 89,

        /// <summary>
        /// Extension of the storage period.
        /// Продление срока хранения.
        /// </summary>
        ExtensionOfTheStoragePeriod = 90,
        ПродлениеСрокаХранения = 90,

        /// <summary>
        /// Redirection.
        /// Переадресация.
        /// </summary>
        Redirection = 91,
        Переадресация = 91,

        /// <summary>
        /// Reception on the sender's territory.
        /// Прием на территории отправителя.
        /// </summary>
        ReceptionOnTheSenderSTerritory = 92,
        ПриемНаТерриторииОтправителя = 92,

        /// <summary>
        /// Return delivery to the sender.
        /// Доставка возврата отправителю.
        /// </summary>
        ReturnDeliveryToTheSender = 93,
        ДоставкаВозвратаОтправителю = 93,

        /// <summary>
        /// Widget of delivery points.
        /// Виджет пунктов выдачи.
        /// </summary>
        WidgetOfDeliveryPoints = 94,
        ВиджетПунктовВыдачи = 94,

        /// <summary>
        /// Free storage for up to 7 days.
        /// Бесплатное хранение до 7 дней.
        /// </summary>
        FreeStorageForUpTo7Days = 95,
        БесплатноеХранениеДо7Дней = 95,

        /// <summary>
        /// Opening hours of the PVZ and post offices in the evening.
        /// Время работы ПВЗ и почтаматов в вечернее время.
        /// </summary>
        OpeningHoursOfThePvzAndPostOfficesInTheEvening = 96,
        ВремяРаботыПвзИПочтаматовВВечернееВремя = 96,

        /// <summary>
        /// Delivery to OPS and partner PVZ and post offices.
        /// Доставка до ОПС и партнерских ПВЗ и почтаматов.
        /// </summary>
        DeliveryToOpsAndPartnerPvzAndPostOffices = 97,
        ДоставкаДоОпсИПартнерскихПвзИПочтаматов = 97,

        /// <summary>
        /// Delivery and delivery on weekends.
        /// Доставка и выдача в выходные дни.
        /// </summary>
        DeliveryAndDeliveryOnWeekends = 98,
        ДоставкаИВыдачаВВыходныеДни = 98,

        /// <summary>
        /// Loading/unloading of shipments when collected from the warehouse.
        /// Погрузка/разгрузка отправлений при сборе со склада.
        /// </summary>
        LoadingUnloadingOfShipmentsWhenCollectedFromTheWarehouse = 99,
        ПогрузкаРазгрузкаОтправленийПриСбореСоСклада = 99,

        /// <summary>
        /// Getting information about the movement of a shipment in real time.
        /// Получение информации о движении отправления в реальном времени.
        /// </summary>
        GettingInformationAboutTheMovementOfAShipmentInRealTime = 100,
        ПолучениеИнформацииОДвиженииОтправленияВРеальномВремени = 100,

        /// <summary>
        /// Sender's Notification.
        /// Уведомление отправителя.
        /// </summary>
        SenderSNotification = 101,
        УведомлениеОтправителя = 101,

        /// <summary>
        /// Delivery Management.
        /// Управление доставкой.
        /// </summary>
        DeliveryManagement = 102,
        УправлениеДоставкой = 102,

        /// <summary>
        /// Identification of the recipient by PIN code.
        /// Идентификация получателя по ПИН-коду.
        /// </summary>
        IdentificationOfTheRecipientByPinCode = 103,
        ИдентификацияПолучателяПоПинКоду = 103,

        /// <summary>
        /// Reception via the mobile app.
        /// Прием через мобильное приложение.
        /// </summary>
        ReceptionViaTheMobileApp = 104,
        ПриемЧерезМобильноеПриложение = 104,

        /// <summary>
        /// Simplified reception.
        /// Упрощенный прием.
        /// </summary>
        SimplifiedReception = 105,
        УпрощенныйПрием = 105,

        /// <summary>
        /// Billing.
        /// Тарификация.
        /// </summary>
        Billing = 110,
        Тарификация = 110,

        /// <summary>
        /// Calculation of control dates.
        /// Расчет контрольных сроков.
        /// </summary>
        CalculationOfControlDates = 111,
        РасчетКонтрольныхСроков = 111,

        /// <summary>
        /// Checking input parameters.
        /// Проверка входных параметров.
        /// </summary>
        CheckingInputParameters = 112,
        ПроверкаВходныхПараметров = 112,

        /// <summary>
        /// Service fee.
        /// Плата за услугу.
        /// </summary>
        ServiceFee = 115,
        ПлатаЗаУслугу = 115,

        /// <summary>
        /// Additional payment for the service.
        /// Доплата за услугу.
        /// </summary>
        AdditionalPaymentForTheService = 116,
        ДоплатаЗаУслугу = 116,

        /// <summary>
        /// Sale of goods.
        /// Продажа товара.
        /// </summary>
        SaleOfGoods = 117,
        ПродажаТовара = 117,

        /// <summary>
        /// Additional service.
        /// Дополнительная услуга.
        /// </summary>
        AdditionalService = 118,
        ДополнительнаяУслуга = 118,

        /// <summary>
        /// Payment for the place of delivery.
        /// Плата за место вручения.
        /// </summary>
        PaymentForThePlaceOfDelivery = 120,
        ПлатаЗаМестоВручения = 120,

        /// <summary>
        /// Overload.
        /// Перегрузка.
        /// </summary>
        Overload = 121,
        Перегрузка = 121,

        /// <summary>
        /// Air carrier's tariff.
        /// Тариф авиаперевозчика.
        /// </summary>
        AirCarrierSTariff = 122,
        ТарифАвиаперевозчика = 122,

        /// <summary>
        /// Postal fee.
        /// Почтовый сбор.
        /// </summary>
        PostalFee = 123,
        ПочтовыйСбор = 123,

        /// <summary>
        /// Overweight allowance.
        /// Надбавка за перевес.
        /// </summary>
        OverweightAllowance = 124,
        НадбавкаЗаПеревес = 124,

        /// <summary>
        /// Combined delivery.
        /// Комбинированная доставка.
        /// </summary>
        CombinedDelivery = 125,
        КомбинированнаяДоставка = 125,

        /// <summary>
        /// Delivery on the first mile.
        /// Доставка на первой миле.
        /// </summary>
        DeliveryOnTheFirstMile = 126,
        ДоставкаНаПервойМиле = 126,

        /// <summary>
        /// Last Mile Delivery.
        /// Доставка на последней миле.
        /// </summary>
        LastMileDelivery = 127,
        ДоставкаНаПоследнейМиле = 127,

        /// <summary>
        /// Standard delivery time within the country.
        /// Нормативный срок доставки внутри страны.
        /// </summary>
        StandardDeliveryTimeWithinTheCountry = 130,
        НормативныйСрокДоставкиВнутриСтраны = 130,

        /// <summary>
        /// Standard delivery time of the international part.
        /// Нормативный срок доставки международной части.
        /// </summary>
        StandardDeliveryTimeOfTheInternationalPart = 131,
        НормативныйСрокДоставкиМеждународнойЧасти = 131,

        /// <summary>
        /// The deadline, taking into account the work schedule.
        /// Срок с учетом расписания работы.
        /// </summary>
        TheDeadlineTakingIntoAccountTheWorkSchedule = 132,
        СрокСУчетомРасписанияРаботы = 132,

        /// <summary>
        /// Penalty for improper quality.
        /// Штраф за ненадлежащее качество.
        /// </summary>
        PenaltyForImproperQuality = 133,
        ШтрафЗаНенадлежащееКачество = 133,

        /// <summary>
        /// Quality Bonus.
        /// Бонус за качество.
        /// </summary>
        QualityBonus = 134,
        БонусЗаКачество = 134,

        /// <summary>
        /// Without autopsy.
        /// Без вскрытия.
        /// </summary>
        WithoutAutopsy = 135,
        БезВскрытия = 135,

        /// <summary>
        /// Alcoholic beverages.
        /// Алкогольная продукция.
        /// </summary>
        AlcoholicBeverages = 136,
        АлкогольнаяПродукция = 136,

        /// <summary>
        /// Name cell.
        /// Именная ячейка.
        /// </summary>
        NameCell = 137,
        ИменнаяЯчейка = 137,

        /// <summary>
        /// Attachment of registered items.
        /// Вложение регистрируемых отправлений.
        /// </summary>
        AttachmentOfRegisteredItems = 138,
        ВложениеРегистрируемыхОтправлений = 138,

        /// <summary>
        /// Cargo crate.
        /// Обрешетка груза.
        /// </summary>
        CargoCrate = 139,
        ОбрешеткаГруза = 139,

        /// <summary>
        /// Filling in and printing the customs declaration.
        /// Заполнение и печать таможенной декларации.
        /// </summary>
        FillingInAndPrintingTheCustomsDeclaration = 140,
        ЗаполнениеИПечатьТаможеннойДекларации = 140,

        /// <summary>
        /// Delivery by rover.
        /// Доставка ровером.
        /// </summary>
        DeliveryByRover = 141,
        ДоставкаРовером = 141,

        /// <summary>
        /// Extended address verification.
        /// Расширенная верификация адреса.
        /// </summary>
        ExtendedAddressVerification = 142,
        РасширеннаяВерификацияАдреса = 142,

        /// <summary>
        /// Mark 'Urgent'.
        /// Отметка 'Срочно'.
        /// </summary>
        MarkUrgent = 143,
        ОтметкаСрочно = 143,

        /// <summary>
        /// The mark of delivery by a certain date.
        /// Отметка вручения к определенной дате.
        /// </summary>
        TheMarkOfDeliveryByACertainDate = 144,
        ОтметкаВрученияКОпределеннойДате = 144,

        /// <summary>
        /// Art form.
        /// Художественный бланк.
        /// </summary>
        ArtForm = 145,
        ХудожественныйБланк = 145,

        /// <summary>
        /// Certification inscription.
        /// Заверительная надпись.
        /// </summary>
        CertificationInscription = 146,
        ЗаверительнаяНадпись = 146,

        /// <summary>
        /// Writing by the operator when receiving.
        /// Написание оператором при приеме.
        /// </summary>
        WritingByTheOperatorWhenReceiving = 147,
        НаписаниеОператоромПриПриеме = 147,

        /// <summary>
        /// Text selection.
        /// Подбор текста.
        /// </summary>
        TextSelection = 148,
        ПодборТекста = 148,

        /// <summary>
        /// Issuing a certificate of address.
        /// Выдача справки об адресе.
        /// </summary>
        IssuingACertificateOfAddress = 149,
        ВыдачаСправкиОбАдресе = 149,

        /// <summary>
        /// Telegraph collection.
        /// Телеграфный сбор.
        /// </summary>
        TelegraphCollection = 150,
        ТелеграфныйСбор = 150,

        /// <summary>
        /// Ordinary telegraphic delivery notification.
        /// Обыкновенное телеграфное уведомление о вручении.
        /// </summary>
        OrdinaryTelegraphicDeliveryNotification = 151,
        ОбыкновенноеТелеграфноеУведомлениеОВручении = 151,

        /// <summary>
        /// Urgent telegraphic notification of delivery.
        /// Срочное телеграфное уведомление о вручении.
        /// </summary>
        UrgentTelegraphicNotificationOfDelivery = 152,
        СрочноеТелеграфноеУведомлениеОВручении = 152,

        /// <summary>
        /// Data refinement.
        /// Уточнение данных.
        /// </summary>
        DataRefinement = 153,
        УточнениеДанных = 153,

        /// <summary>
        /// Providing a POD.
        /// Предоставление POD.
        /// </summary>
        ProvidingAPod = 154,
        ПредоставлениеPod = 154,

        /// <summary>
        /// Social benefits.
        /// Социальные выплаты.
        /// </summary>
        SocialBenefits = 155,
        СоциальныеВыплаты = 155,

        /// <summary>
        /// Cash on delivery surcharge.
        /// Надбавка за наложенный платеж.
        /// </summary>
        CashOnDeliverySurcharge = 156,
        НадбавкаЗаНаложенныйПлатеж = 156,

        /// <summary>
        /// Bulk weight allowance.
        /// Надбавка за объемный вес.
        /// </summary>
        BulkWeightAllowance = 157,
        НадбавкаЗаОбъемныйВес = 157,

        /// <summary>
        /// Fuel collection.
        /// Топливный сбор.
        /// </summary>
        FuelCollection = 158,
        ТопливныйСбор = 158,

        /// <summary>
        /// Stock.
        /// Акция.
        /// </summary>
        Stock = 159,
        Акция = 159,

        /// <summary>
        /// Non-refundable.
        /// Возврату не подлежит.
        /// </summary>
        NonRefundable = 160,
        ВозвратуНеПодлежит = 160,

        /// <summary>
        /// Cross-delivery.
        /// Кроссдоставка.
        /// </summary>
        CrossDelivery = 161,
        Кроссдоставка = 161,

        /// <summary>
        /// Pharmacological products.
        /// Фармакологическая продукция.
        /// </summary>
        PharmacologicalProducts = 162,
        ФармакологическаяПродукция = 162,

        /// <summary>
        /// Promotional rate.
        /// Акционный тариф.
        /// </summary>
        PromotionalRate = 163,
        АкционныйТариф = 163,

    }
}
