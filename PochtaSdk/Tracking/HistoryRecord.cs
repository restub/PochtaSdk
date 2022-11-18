using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PochtaSdk.Tariff;

namespace PochtaSdk.Tracking
{
    /// <summary>
    /// Flattened parcel tracking history record.
    /// Запись об истории обработки посылки.
    /// https://tracking.pochta.ru/specification#getOperationHistory
    /// </summary>
    public class HistoryRecord
    {
        /// <summary>
        /// Почтовый индекс места назначения.
        /// Не возвращается для зарубежных операций.
        /// </summary>
        public string DestinationAddressPostCode { get; set; }

        /// <summary>
        /// Адрес и/или название места назначения.
        /// </summary>
        public string DestinationAddressDescription { get; set; }

        /// <summary>
        /// Почтовый индекс места проведения операции.
        /// Не возвращается для зарубежных операций.
        /// </summary>
        public string OperationAddressPostCode { get; set; }

        /// <summary>
        /// Адрес и/или название места проведения операции.
        /// </summary>
        public string OperationAddressDescription { get; set; }

        /// <summary>
        /// Код страны назначения. Возможные коды приведены в поле "Код" справочника стран.
        /// </summary>
        public OksmCountryCode DestinationCountryCode { get; set; }

        /// <summary>
        /// Двухбуквенный идентификатор страны назначения. Возможные идентификаторы
        /// приведены в поле "Alpha2 код" справочника стран.
        /// </summary>
        public string DestinationCountryCode2A { get; set; }

        /// <summary>
        /// Трехбуквенный идентификатор страны назначения. Возможные идентификаторы
        /// приведены в поле "Alpha3 код" справочника стран.
        /// </summary>
        public string DestinationCountryCode3A { get; set; }

        /// <summary>
        /// Название страны назначения.
        /// </summary>
        public string DestinationCountryName { get; set; }

        /// <summary>
        /// Российское название страны назначения. Возможные названия приведены
        /// в поле "Наименование страны пересылки" справочника стран.
        /// </summary>
        public string DestinationCountryNameRu { get; set; }

        /// <summary>
        /// Международное название страны назначения. Возможные названия приведены
        /// в поле «Английское наименование страны пересылки» справочника стран.
        /// </summary>
        public string DestinationCountryNameEn { get; set; }

        /// <summary>
        /// Код страны отправления. Возможные коды приведены в поле "Код" справочника стран.
        /// </summary>
        public OksmCountryCode SourceCountryCode { get; set; }

        /// <summary>
        /// Двухбуквенный идентификатор страны отправления. Возможные идентификаторы
        /// приведены в поле "Alpha2 код" справочника стран.
        /// </summary>
        public string SourceCountryCode2A { get; set; }

        /// <summary>
        /// Трехбуквенный идентификатор страны отправления. Возможные идентификаторы
        /// приведены в поле "Alpha3 код" справочника стран.
        /// </summary>
        public string SourceCountryCode3A { get; set; }

        /// <summary>
        /// Название страны отправления.
        /// </summary>
        public string SourceCountryName { get; set; }

        /// <summary>
        /// Российское название страны отправления. Возможные названия приведены
        /// в поле "Наименование страны пересылки" справочника стран.
        /// </summary>
        public string SourceCountryNameRu { get; set; }

        /// <summary>
        /// Международное название страны отправления. Возможные названия приведены
        /// в поле «Английское наименование страны пересылки» справочника стран.
        /// </summary>
        public string SourceCountryNameEn { get; set; }

        /// <summary>
        /// Код страны операции. Возможные коды приведены в поле "Код" справочника стран.
        /// </summary>
        public OksmCountryCode OperationCountryCode { get; set; }

        /// <summary>
        /// Двухбуквенный идентификатор страны операции. Возможные идентификаторы
        /// приведены в поле "Alpha2 код" справочника стран.
        /// </summary>
        public string OperationCountryCode2A { get; set; }

        /// <summary>
        /// Трехбуквенный идентификатор страны операции. Возможные идентификаторы
        /// приведены в поле "Alpha3 код" справочника стран.
        /// </summary>
        public string OperationCountryCode3A { get; set; }

        /// <summary>
        /// Название страны операции.
        /// </summary>
        public string OperationCountryName { get; set; }

        /// <summary>
        /// Российское название страны операции. Возможные названия приведены
        /// в поле "Наименование страны пересылки" справочника стран.
        /// </summary>
        public string OperationCountryNameRu { get; set; }

        /// <summary>
        /// Международное название страны операции. Возможные названия приведены
        /// в поле «Английское наименование страны пересылки» справочника стран.
        /// </summary>
        public string OperationCountryNameEn { get; set; }

        /// <summary>
        /// Сумма наложенного платежа в копейках.
        /// </summary>
        public int CashOnDeliveryPayment { get; set; }

        /// <summary>
        /// Сумма объявленной ценности в копейках.
        /// </summary>
        public int DeclaredValue { get; set; }

        /// <summary>
        /// Общая сумма платы за пересылку наземным
        /// и воздушным транспортом в копейках.
        /// </summary>
        public int MassRate { get; set; }

        /// <summary>
        /// Сумма платы за объявленную ценность в копейках.
        /// </summary>
        public int InsuranceRate { get; set; }

        /// <summary>
        /// Выделенная сумма платы за пересылку воздушным
        /// транспортом из общей суммы платы за пересылку в копейках.
        /// </summary>
        public int AirRate { get; set; }

        /// <summary>
        /// Сумма дополнительного тарифного сбора в копейках.
        /// </summary>
        public int Rate { get; set; }

        /// <summary>
        /// Сумма таможенного платежа в копейках.
        /// </summary>
        public int CustomsDuty { get; set; }

        /// <summary>
        /// Идентификатор почтового отправления, текущий для данной операции.
        /// </summary>
        public string ItemBarcode { get; set; }

        /// <summary>
        /// Служебная информация, идентифицирующая отправление, может иметь значение 
        /// ДМ квитанции, связанной с отправлением или иметь значение null
        /// </summary>
        public string ItemInternum { get; set; }

        /// <summary>
        /// Признак корректности вида и категории отправления для внутренней пересылки
        /// </summary>
        public bool ItemValidRuType { get; set; }

        /// <summary>
        /// Признак корректности вида и категории отправления для международной пересылки
        /// </summary>
        public bool ItemValidEnType { get; set; }

        /// <summary>
        /// Содержит текстовое описание вида и категории отправления.
        /// </summary>
        public string ItemComplexName { get; set; }

        /// <summary>
        /// Код разряда почтового отправления.
        /// </summary>
        public int MailRankID { get; set; }

        /// <summary>
        /// Название разряда почтового отправления.
        /// </summary>
        public string MailRankName { get; set; }

        /// <summary>
        /// Код отметки почтового отправления.
        /// </summary>
        public int PostMarkID { get; set; }

        /// <summary>
        /// Наименование отметки почтового отправления.
        /// </summary>
        public string PostMarkName { get; set; }

        /// <summary>
        /// Код вида почтового отправления.
        /// </summary>
        public int MailTypeID { get; set; }

        /// <summary>
        /// Название вида почтового отправления.
        /// </summary>
        public string MailTypeName { get; set; }

        /// <summary>
        /// Код категории почтового отправления.
        /// </summary>
        public int MailCategoryID { get; set; }

        /// <summary>
        /// Название категории почтового отправления.
        /// </summary>
        public string MailCategoryName { get; set; }

        /// <summary>
        /// Вес отправления в граммах.
        /// </summary>
        public int Mass { get; set; }

        /// <summary>
        /// Значение максимально возможного веса для данного
        /// вида и категории отправления для внутренней пересылки.
        /// </summary>
        public string MaxMassRu { get; set; }

        /// <summary>
        /// Значение максимально возможного веса для данного
        /// вида и категории отправления для международной пересылки.
        /// </summary>
        public string MaxMassEn { get; set; }

        /// <summary>
        /// Код операции над отправлением.
        /// </summary>
        public int OperationTypeID { get; set; }

        /// <summary>
        /// Название операции над отправлением.
        /// </summary>
        public string OperationTypeName { get; set; }

        /// <summary>
        /// Код атрибута операции над отправлением.
        /// </summary>
        public int OperationAttributeID { get; set; }

        /// <summary>
        /// Название атрибута операции над отправлением.
        /// </summary>
        public string OperationAttributeName { get; set; }

        /// <summary>
        /// Содержит данные о дате и времени проведения операции над отправлением.
        /// </summary>
        public DateTime? OperationDate { get; set; }

        /// <summary>
        /// Идентификатор категории отправителя.
        /// </summary>
        public int SenderCategoryID { get; set; }

        /// <summary>
        /// Название категории отправителя.
        /// </summary>
        public string SenderCategoryName { get; set; }

        /// <summary>
        /// Содержит данные об отправителе.
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// Содержит данные о получателе отправления.
        /// </summary>
        public string Recipient { get; set; }
    }
}
