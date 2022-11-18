using System.Collections.Generic;
using System.Linq;
using PochtaSdk.Tariff;
using PochtaSdk.Tracking.SingleRequest;

namespace PochtaSdk.Tracking
{
    /// <summary>
    /// Helper methods for mail tracking history.
    /// </summary>
    internal static class HistoryExtensions
    {
        public static IEnumerable<HistoryRecord> Flatten(this IEnumerable<OperationHistoryRecord> records)
        {
            if (records == null || !records.Any())
            {
                yield break;
            }

            OksmCountryCode getCountryCode(int? a) =>
                a.HasValue ? (OksmCountryCode)a.Value : OksmCountryCode.Russia;

            int strToInt(string value) =>
                int.TryParse(value ?? "0", out var result) ? result : 0;

            foreach (var record in records)
            {
                if (record == null)
                {
                    continue;
                }

                yield return new HistoryRecord
                {
                    // AddressParameters
                    DestinationAddressPostCode = record.AddressParameters?.DestinationAddress?.Index,
                    DestinationAddressDescription = record.AddressParameters?.DestinationAddress?.Description,
                    OperationAddressPostCode = record.AddressParameters?.OperationAddress?.Index,
                    OperationAddressDescription = record.AddressParameters?.OperationAddress?.Description,
                    DestinationCountryCode = getCountryCode(record.AddressParameters?.MailDirect?.Id),
                    DestinationCountryCode2A = record.AddressParameters?.MailDirect?.Code2A,
                    DestinationCountryCode3A = record.AddressParameters?.MailDirect?.Code3A,
                    DestinationCountryName =   record.AddressParameters?.MailDirect?.Name,
                    DestinationCountryNameRu = record.AddressParameters?.MailDirect?.NameRU,
                    DestinationCountryNameEn = record.AddressParameters?.MailDirect?.NameEN,
                    SourceCountryCode = getCountryCode(record.AddressParameters?.CountryFrom?.Id),
                    SourceCountryCode2A = record.AddressParameters?.CountryFrom?.Code2A,
                    SourceCountryCode3A = record.AddressParameters?.CountryFrom?.Code3A,
                    SourceCountryName = record.AddressParameters?.CountryFrom?.Name,
                    SourceCountryNameRu = record.AddressParameters?.CountryFrom?.NameRU,
                    SourceCountryNameEn = record.AddressParameters?.CountryFrom?.NameEN,
                    OperationCountryCode = getCountryCode(record.AddressParameters?.CountryOper?.Id),
                    OperationCountryCode2A = record.AddressParameters?.CountryOper?.Code2A,
                    OperationCountryCode3A = record.AddressParameters?.CountryOper?.Code3A,
                    OperationCountryName   = record.AddressParameters?.CountryOper?.Name,
                    OperationCountryNameRu = record.AddressParameters?.CountryOper?.NameRU,
                    OperationCountryNameEn = record.AddressParameters?.CountryOper?.NameEN,

                    // FinanceParameters
                    CashOnDeliveryPayment = strToInt(record.FinanceParameters?.Payment),
                    DeclaredValue = strToInt(record.FinanceParameters?.Value),
                    MassRate = strToInt(record.FinanceParameters?.MassRate),
                    InsuranceRate = strToInt(record.FinanceParameters?.InsrRate),
                    AirRate = strToInt(record.FinanceParameters?.AirRate),
                    Rate = strToInt(record.FinanceParameters?.Rate),
                    CustomsDuty = strToInt(record.FinanceParameters?.CustomDuty),

                    // ItemParameters
                    ItemBarcode = record.ItemParameters?.Barcode,
                    ItemInternum = record.ItemParameters?.Internum,
                    ItemValidRuType = record.ItemParameters?.ValidRuType ?? false,
                    ItemValidEnType = record.ItemParameters?.ValidEnType ?? false,
                    ItemComplexName = record.ItemParameters?.ComplexItemName,
                    MailRankID = record.ItemParameters?.MailRank?.Id ?? 0,
                    MailRankName = record.ItemParameters?.MailRank?.Name,
                    PostMarkID = record.ItemParameters?.PostMark?.Id ?? 0,
                    PostMarkName = record.ItemParameters?.PostMark?.Name,
                    MailTypeID = record.ItemParameters?.MailType?.Id ?? 0,
                    MailTypeName = record.ItemParameters?.MailType?.Name,
                    MailCategoryID = record.ItemParameters?.MailCtg?.Id ?? 0,
                    MailCategoryName = record.ItemParameters?.MailCtg?.Name,
                    Mass = strToInt(record.ItemParameters?.Mass),
                    MaxMassRu = record.ItemParameters?.MaxMassRU,
                    MaxMassEn = record.ItemParameters?.MaxMassEN,

                    // OperationParameters
                    OperationTypeID = record.OperationParameters?.OperType?.Id ?? 0,
                    OperationTypeName = record.OperationParameters?.OperType?.Name,
                    OperationAttributeID = record.OperationParameters?.OperAttr?.Id ?? 0,
                    OperationAttributeName = record.OperationParameters?.OperAttr?.Name,
                    OperationDate = record.OperationParameters?.OperDate,

                    // UserParameters
                    SenderCategoryID = record.UserParameters?.SendCtg?.Id ?? 0,
                    SenderCategoryName = record.UserParameters?.SendCtg?.Name,
                    Sender = record.UserParameters?.Sndr,
                    Recipient = record.UserParameters?.Rcpn,
                };
            }
        }
    }
}
