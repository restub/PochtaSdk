﻿using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Linear dimensions.
    /// Линейные размеры.
    /// https://otpravka.pochta.ru/specification#/orders-creating_order
    /// https://otpravka.pochta.ru/specification#/orders-creating_order_v2
    /// https://otpravka.pochta.ru/specification#/nogroup-rate_calculate
    /// </summary>
    [DataContract]
    public class Dimensions
    {
        /// <summary>
        /// Линейная высота (сантиметры)
        /// </summary>
        [DataMember(Name = "height")]
        public int Height { get; set; }

        /// <summary>
        /// Линейная длина (сантиметры)
        /// </summary>
        [DataMember(Name = "length")]
        public int Length { get; set; }

        /// <summary>
        /// Линейная ширина (сантиметры)
        /// </summary>
        [DataMember(Name = "width")]
        public int Width { get; set; }
    }
}