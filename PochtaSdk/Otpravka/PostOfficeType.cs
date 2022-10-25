using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Post office types.
    /// Типы почтовых отделений.
    /// https://otpravka.pochta.ru/specification#/postoffice_passport-unload_passport
    /// </summary>
    [DataContract]
    public enum PostOfficeType
    {
        /// <summary>
        /// Все объекты
        /// </summary>
        [EnumMember(Value = "ALL")]
        All,

        /// <summary>
        /// Отделение почтовой связи
        /// </summary>
        [EnumMember(Value = "OPS")]
        PostOffice,

        /// <summary>
        /// Пункт выдачи заказов
        /// </summary>
        [EnumMember(Value = "PVZ")]
        PickupPoint,

        /// <summary>
        /// Почтомат
        /// </summary>
        [EnumMember(Value = "APS")]
        Postamat,
    }
}
