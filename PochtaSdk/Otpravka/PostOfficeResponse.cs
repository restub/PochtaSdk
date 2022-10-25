using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Search post offices by address response.
    /// Поиск ОПС по адресу.
    /// https://otpravka.pochta.ru/specification#/services-postoffice-by-address
    /// </summary>
    [DataContract]
    public class PostOfficeResponse
    {
        /// <summary>
        /// Флаг, говорящий, является ли переданный в параметре address адрес 
        /// точным адресом ОПС (случай, когда переданный адрес и есть адрес ОПС). 
        /// Данный флаг определяется только для первого ОПС в списке, т.е. он говорит о том, 
        /// является ли переданный адрес точным адресом самого релевантного найденного ОПС.
        /// </summary>
        /// <remarks>
        /// Попасть практически нереально, видимо, адрес сравнивает с точностью до символа.
        /// Почти всегда возвращается false.
        /// </remarks>
        [DataMember(Name = "is-matched")]
        public bool IsMatched { get; set; }

        /// <summary>
        /// Список почтовых индексов найденных ОПС отсортированный по релевантности
        /// </summary>
        [DataMember(Name = "postoffices")]
        public string[] PostOffices { get; set; }
    }
}
