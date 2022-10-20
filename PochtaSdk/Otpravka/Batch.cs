using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Batch properties.
    /// https://otpravka.pochta.ru/specification#/batches-create_batch_from_N_orders
    /// </summary>
    [DataContract]
    public class Batch
    {
        /// <summary>
        /// Количество отправлений, прибывших в отделение связи (для БК)
        /// </summary>
        [DataMember(Name = "accepted-count")]
        public int AcceptedCount { get; set; }

        /// <summary>
        /// Номер партии
        /// </summary>
        [DataMember(Name = "batch-name")]
        public string BatchName { get; set; }

        /// <summary>
        /// Статус партии.
        /// </summary>
        [DataMember(Name = "batch-status")]
        public BatchStatus BatchStatus { get; set; }

        /// <summary>
        /// Дата обновления статуса.
        /// </summary>
        [DataMember(Name = "batch-status-date")]
        public string BatchStatusDate { get; set; }

        /// <summary>
        /// Хэш-код бандероль-комплектов.
        /// </summary>
        [DataMember(Name = "bk-hash")]
        public int? BkHash { get; set; }

        /// <summary>
        /// Идентификатор подразделения.
        /// </summary>
        [DataMember(Name = "branch-name")]
        public string BranchName { get; set; }

        /// <summary>
        /// Типы отправлений в комбинированной партии.
        /// </summary>
        [DataMember(Name = "combined-batch-mail-types")]
        public MailType[] CombinedBatchMailTypes { get; set; }

        /// <summary>
        /// Плата за услугу "Курьерский сбор" с НДС.
        /// </summary>
        [DataMember(Name = "courier-call-rate-with-vat")]
        public int? CourierCallRateWithVat { get; set; }

        /// <summary>
        /// Плата за услугу "Курьерский сбор" без НДС
        /// </summary>
        [DataMember(Name = "courier-call-rate-wo-vat")]
        public int? CourierCallRateWoVat { get; set; }

        /// <summary>
        /// Статусы заявки на вызов курьера.
        /// </summary>
        [DataMember(Name = "courier-order-statuses")]
        public CourierOrderStatus[] CourierOrderStatuses { get; set; }

        /// <summary>
        /// Количество отправлений, врученных адресату (для БК)
        /// </summary>
        [DataMember(Name = "delivery-count")]
        public int DeliveryCount { get; set; }

        /// <summary>
        /// Способ оплаты уведомления о вручении РПО.
        /// </summary>
        [DataMember(Name = "delivery-notice-payment-method")]
        public PaymentMethod? DeliveryNoticePaymentMethod { get; set; }

        /// <summary>
        /// Статус необходимости скачивания новых документов.
        /// </summary>
        [DataMember(Name = "document-download-status")]
        public DocumentDownloadStatus? DocumentDownloadStatus { get; set; }

        /// <summary>
        /// Электронный формат Ф-103
        /// </summary>
        [DataMember(Name = "electronic-f103")]
        public bool ElectronicF103 { get; set; }

        /// <summary>
        /// Наименование группы бандероль-комплектов
        /// </summary>
        [DataMember(Name = "group-name")]
        public string GroupName { get; set; }

        /// <summary>
        /// Статус по гиперлокальной доставке.
        /// </summary>
        [DataMember(Name = "hyper-local-status")]
        public HyperLocalStatus? HyperLocalStatus { get; set; }

        /// <summary>
        /// Признак международной почты
        /// </summary>
        [DataMember(Name = "international")]
        public bool International { get; set; }

        /// <summary>
        /// Является ли место приема УКД
        /// </summary>
        [DataMember(Name = "is-postoffice-ukd")]
        public bool IsPostofficeUkd { get; set; }

        /// <summary>
        /// Номер документа для сдачи партии
        /// </summary>
        [DataMember(Name = "list-number")]
        public int ListNumber { get; set; }

        /// <summary>
        /// Дата документа для сдачи партии (yyyy-MM-dd)
        /// </summary>
        [DataMember(Name = "list-number-date")]
        public string ListNumberDate { get; set; }

        /// <summary>
        /// Категория РПО.
        /// </summary>
        [DataMember(Name = "mail-category")]
        public MailCategory? MailCategory { get; set; }

        /// <summary>
        /// Категория РПО (текст)
        /// </summary>
        [DataMember(Name = "mail-category-text")]
        public string MailCategoryText { get; set; }

        /// <summary>
        /// Код разряда партии.
        /// </summary>
        [DataMember(Name = "mail-rank")]
        public MailRank? MailRank { get; set; }

        /// <summary>
        /// Вид РПО.
        /// </summary>
        [DataMember(Name = "mail-type")]
        public MailType? MailType { get; set; }

        /// <summary>
        /// Вид РПО (текст)
        /// </summary>
        [DataMember(Name = "mail-type-text")]
        public string MailTypeText { get; set; }

        /// <summary>
        /// Способ оплаты уведомления.
        /// </summary>
        [DataMember(Name = "notice-payment-method")]
        public PaymentMethod? NoticePaymentMethod { get; set; }

        /// <summary>
        /// Способ оплаты.
        /// </summary>
        [DataMember(Name = "payment-method")]
        public PaymentMethod? PaymentMethod { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [DataMember(Name = "person-code")]
        public string PersonCode { get; set; }

        /// <summary>
        /// Отметки внутренних и международных отправлений.
        /// </summary>
        [DataMember(Name = "postmarks")]
        public PostMark[] PostMarks { get; set; }

        /// <summary>
        /// Адрес места приема.
        /// </summary>
        [DataMember(Name = "postoffice-address")]
        public string PostOfficeAddress { get; set; }

        /// <summary>
        /// Индекс места приема
        /// </summary>
        [DataMember(Name = "postoffice-code")]
        public string PostOfficeCode { get; set; }

        /// <summary>
        /// Наименование места приема
        /// </summary>
        [DataMember(Name = "postoffice-name")]
        public string PostOfficeName { get; set; }

        /// <summary>
        /// Предпочтовая подготовка
        /// </summary>
        [DataMember(Name = "pre-postal-preparation")]
        public bool PrePostalPreparation { get; set; }

        /// <summary>
        /// Сумма платы за авиа пересылку в копейках, без НДС
        /// </summary>
        [DataMember(Name = "shipment-avia-rate-sum")]
        public int? ShipmentAviaRateSum { get; set; }

        /// <summary>
        /// НДС от суммы платы за авиа пересылку в копейках
        /// </summary>
        [DataMember(Name = "shipment-avia-rate-vat-sum")]
        public int? ShipmentAviaRateVatSum { get; set; }

        /// <summary>
        /// Сумма платы за проверку комплектности в копейках, без НДС
        /// </summary>
        [DataMember(Name = "shipment-completeness-checking-rate-sum")]
        public int? ShipmentCompletenessCheckingRateSum { get; set; }

        /// <summary>
        /// НДС от суммы платы за проверку комплектности в копейках
        /// </summary>
        [DataMember(Name = "shipment-completeness-checking-rate-vat-sum")]
        public int? ShipmentCompletenessCheckingRateVatSum { get; set; }

        /// <summary>
        /// Сумма платы за проверку вложений в копейках, без НДС
        /// </summary>
        [DataMember(Name = "shipment-contents-checking-rate-sum")]
        public int? ShipmentContentsCheckingRateSum { get; set; }

        /// <summary>
        /// НДС от суммы платы за проверку вложений в копейках
        /// </summary>
        [DataMember(Name = "shipment-contents-checking-rate-vat-sum")]
        public int? ShipmentContentsCheckingRateVatSum { get; set; }

        /// <summary>
        /// Количество заказов в партии.
        /// </summary>
        [DataMember(Name = "shipment-count")]
        public int ShipmentCount { get; set; }

        /// <summary>
        /// Сумма платы за проверку вложений с проверкой функциональности в копейках, без НДС
        /// </summary>
        [DataMember(Name = "shipment-functionality-checking-rate-sum")]
        public int? ShipmentFunctionalityCheckingRateSum { get; set; }

        /// <summary>
        /// НДС от суммы платы за проверку вложений с проверкой функциональности в копейках
        /// </summary>
        [DataMember(Name = "shipment-functionality-checking-rate-vat-sum")]
        public int? ShipmentFunctionalityCheckingRateVatSum { get; set; }

        /// <summary>
        /// НДС от суммы платы за проверку вложений с проверкой функциональности в копейках
        /// </summary>
        [DataMember(Name = "shipment-ground-rate-sum")]
        public int? ShipmentGroundRateSum { get; set; }

        /// <summary>
        /// НДС от суммы платы за наземную пересылку в копейках
        /// </summary>
        [DataMember(Name = "shipment-ground-rate-vat-sum")]
        public int? ShipmentGroundRateVatSum { get; set; }

        /// <summary>
        /// Сумма платы за объявленную ценность в копейках, без НДС
        /// </summary>
        [DataMember(Name = "shipment-insure-rate-sum")]
        public int? ShipmentInsureRateSum { get; set; }

        /// <summary>
        /// НДС от суммы платы за объявленную ценность в копейках
        /// </summary>
        [DataMember(Name = "shipment-insure-rate-vat-sum")]
        public int? ShipmentInsureRateVatSum { get; set; }

        /// <summary>
        /// Сумма платы за опись вложения в копейках, без НДС
        /// </summary>
        [DataMember(Name = "shipment-inventory-rate-sum")]
        public int? ShipmentInventoryRateSum { get; set; }

        /// <summary>
        /// НДС от суммы платы за опись вложения в копейках, без НДС
        /// </summary>
        [DataMember(Name = "shipment-inventory-rate-vat-sum")]
        public int? ShipmentInventoryRateVatSum { get; set; }

        /// <summary>
        /// Общий вес в граммах
        /// </summary>
        [DataMember(Name = "shipment-mass")]
        public int ShipmentMass { get; set; }

        /// <summary>
        /// Сумма платы за пересылку в копейках, без НДС
        /// </summary>
        [DataMember(Name = "shipment-mass-rate-sum")]
        public int? ShipmentMassRateSum { get; set; }

        /// <summary>
        /// НДС от суммы платы за пересылку в копейках
        /// </summary>
        [DataMember(Name = "shipment-mass-rate-vat-sum")]
        public int? ShipmentMassRateVatSum { get; set; }

        /// <summary>
        /// Сумма надбавки за уведомление о вручении в копейках
        /// </summary>
        [DataMember(Name = "shipment-notice-rate-sum")]
        public int? ShipmentNoticeRateSum { get; set; }

        /// <summary>
        /// НДС от суммы надбавки за уведомление о вручении в копейках
        /// </summary>
        [DataMember(Name = "shipment-notice-rate-vat-sum")]
        public int? ShipmentNoticeRateVatSum { get; set; }

        /// <summary>
        /// Сумма платы за частичный выкуп в копейках, без НДС
        /// </summary>
        [DataMember(Name = "shipment-partial-redemption-rate-sum")]
        public int? ShipmentPartialRedemptionRateSum { get; set; }

        /// <summary>
        /// НДС от суммы платы за частичный выкуп в копейках
        /// </summary>
        [DataMember(Name = "shipment-partial-redemption-rate-vat-sum")]
        public int? ShipmentPartialRedemptionRateVatSum { get; set; }

        /// <summary>
        /// Сумма платы за услугу 'Предпочтовая подготовка' в копейках, без НДС
        /// </summary>
        [DataMember(Name = "shipment-pre-postal-preparation-rate-sum")]
        public int? ShipmentPrePostalPreparationRateSum { get; set; }

        /// <summary>
        /// НДС от суммы платы за услугу 'Предпочтовая подготовка' в копейках
        /// </summary>
        [DataMember(Name = "shipment-pre-postal-preparation-rate-vat-sum")]
        public int? ShipmentPrePostalPreparationRateVatSum { get; set; }

        /// <summary>
        /// Сумма платы за смс нотификацию в копейках, без НДС
        /// </summary>
        [DataMember(Name = "shipment-sms-notice-rate-sum")]
        public int? ShipmentSmsNoticeRateSum { get; set; }

        /// <summary>
        /// НДС от суммы платы за смс нотификацию в копейках
        /// </summary>
        [DataMember(Name = "shipment-sms-notice-rate-vat-sum")]
        public int? ShipmentSmsNoticeRateVatSum { get; set; }

        /// <summary>
        /// Сумма платы за проверку вложений с примеркой в копейках, без НДС
        /// </summary>
        [DataMember(Name = "shipment-with-fitting-rate-sum")]
        public int? ShipmentWithFittingRateSum { get; set; }

        /// <summary>
        /// НДС от суммы платы за проверку вложений с примеркой в копейках
        /// </summary>
        [DataMember(Name = "shipment-with-fitting-rate-vat-sum")]
        public int? ShipmentWithFittingRateVatSum { get; set; }

        /// <summary>
        /// Категория уведомления о вручении РПО.
        /// </summary>
        [DataMember(Name = "shipping-notice-type")]
        public ShippingNoticeType? ShippingNoticeType { get; set; }

        /// <summary>
        /// Вид транспортировки.
        /// </summary>
        [DataMember(Name = "transport-type")]
        public TransportType? TransportType { get; set; }

        /// <summary>
        /// УКД
        /// </summary>
        [DataMember(Name = "ukd")]
        public bool Ukd { get; set; }

        /// <summary>
        /// Признак использования онлайн-баланса
        /// </summary>
        [DataMember(Name = "use-online-balance")]
        public bool UseOnlineBalance { get; set; }

        /// <summary>
        /// Без указания массы
        /// </summary>
        [DataMember(Name = "wo-mass")]
        public bool WithoutMass { get; set; }
    }
}
