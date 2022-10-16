using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Order goods pay attr.
    /// Справочнк признаков способов расчета.
    /// https://otpravka.pochta.ru/specification#/enums-payattr
    /// </summary>
    public enum OrderGoodsPayAttr
    {
        /// <summary>
        /// Full advance payment
        /// Полная предварительная оплата до момента передачи предмета расчёта
        /// </summary>
        FullPrepayment = 1,

        /// <summary>
        /// Partial prepayment
        /// Частичная предварительная оплата до момента передачи предмета расчёта
        /// </summary>
        PartialPrepayment = 2,

        /// <summary>
        /// Advance payment
        /// Аванс
        /// </summary>
        Advance = 3,

        /// <summary>
        /// Full payment including advance
        /// Полная оплата, в том числе с учётом аванса (предварительной оплаты) в момент передачи предмета расчёта
        /// </summary>
        FullPaymentIncludingAdvance = 4,

        /// <summary>
        /// Partial prepayment with credit
        /// Частичная оплата предмета расчёта в момент его передачи с последующей оплатой в кредит
        /// </summary>
        PartialPrepaymentWithCredit = 5,

        /// <summary>
        /// No prepayment with credit
        /// Передача предмета расчёта без его оплаты в момент его передачи с последующей оплатой в кредит
        /// </summary>
        NoPrepaymentWithCredit = 6,

        /// <summary>
        /// Credit payment
        /// Оплата предмета расчёта после его передачи с оплатой в кредит (оплата кредита)
        /// </summary>
        CreditPayment = 7,
    }
}
