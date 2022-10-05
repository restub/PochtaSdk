using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PochtaSdk.Toolbox;

namespace PochtaSdk.Tariff
{
    /// <summary>
    /// Tariffication object type parameter.
    /// Параметр объекта тарификации и его описание.
    /// https://tariff.pochta.ru/post-calculator-api.pdf (Table 2.6)
    /// </summary>
    [DataContract]
    public class ObjectTypeParameterInfo
    {
        /// <summary>
        /// Parameter identity.
        /// Код параметра.
        /// </summary>
        [DataMember(Name = "id")]
        public string ID { get; set; }

        /// <summary>
        /// Parameter name.
        /// Русскоязычное наименование параметра.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Data type.
        /// Тип данных.
        /// </summary>
        [DataMember(Name = "datatype")]
        public DataType Datatype { get; set; }

        /// <summary>
        /// REST API parameter name.
        /// Наименование параметра в запросе REST API.
        /// </summary>
        [DataMember(Name = "param")]
        public string ParameterName { get; set; }

        /// <summary>
        /// Minimal integer parameter value.
        /// Минимальное значение параметра, если тип числовой.
        /// </summary>
        [DataMember(Name = "min")]
        public int Min { get; set; }

        /// <summary>
        /// Maximal integer parameter value.
        /// Максимальное значение параметра, если тип числовой.
        /// </summary>
        [DataMember(Name = "max")]
        public int Max { get; set; }

        /// <summary>
        /// Default  integer parameter value.
        /// Значение параметра по умолчанию, если тип числовой.
        /// </summary>
        [DataMember(Name = "def")]
        public int? Def { get; set; }

        /// <summary>
        /// Sequential number.
        /// Порядковый номер в пользовательском интерфейсе.
        /// </summary>
        [DataMember(Name = "seq")]
        public int Seq { get; set; }

        /// <summary>
        /// List of allowed values. Array or string.
        /// Список возможных значений. Массив или строка.
        /// </summary>
        /// <remarks>
        /// "list": "country" or
        /// "list": [{"id": 0,"name": "наземным путём","seq": 1},{"id": 1,"name": "по возможности воздушным путём","seq": 2}]
        /// </remarks>
        [DataMember(Name = "list")]
        public object List { get; set; }

        /// <summary>
        /// Measurement unit name in different grammar forms.
        /// Массив наименований единиц измерения (именительный, родительный падеж и множественное число).
        /// </summary>
        [DataMember(Name = "unit")]
        public string[] Unit { get; set; }
    }
}
