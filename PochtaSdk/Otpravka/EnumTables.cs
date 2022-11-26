using System.Collections.Generic;
using PochtaSdk.Tariff;

namespace PochtaSdk.Otpravka
{
    public static class EnumTables
    {
        /// <summary>
        /// Коды видов почтовых отправлений (РТМ-2 MailType).
        /// Идентификатор: MailType
        /// https://tracking.pochta.ru/support/dictionaries/mailtype
        /// Сопоставление с перечислением MailType
        /// https://otpravka.pochta.ru/specification#/enums-base-mail-type
        /// </summary>
        internal static Dictionary<MailType, int> MailTypeCodes { get; } =
            new Dictionary<MailType, int>
            {
                { MailType.Banderol, 3 },
                { MailType.BanderolClass1, 16 },
                { MailType.BusinessCourier, 30 },
                { MailType.BusinessCourierExpress, 31 },
                { MailType.Combined, -100 }, // отсутствует в таблице
                { MailType.EasyReturn, 51 },
                { MailType.Ecom, 53 },
                { MailType.EcomMarketplace, 54 },
                { MailType.Ems, 7 },
                { MailType.EmsOptimal, 34 },
                { MailType.EmsRt, 41 },
                { MailType.EmsTender, 52 },
                { MailType.HyperCargo, 57 },
                { MailType.Letter, 2 },
                { MailType.LetterClass1, 15 },
                { MailType.OnlineCourier, 24 },
                { MailType.OnlineParcel, 23 },
                { MailType.ParcelClass1, 47 },
                { MailType.PostalParcel, 4 },
                { MailType.SmallPacket, 5 },
                { MailType.VgpoClass1, 46 },
                { MailType.Vsd, 10 },
            };

        /// <summary>
        /// Коды категорий почтовых и непочтовых отправлений (РТМ-2 MailCtg).
        /// Идентификатор: MailCtg
        /// https://tracking.pochta.ru/support/dictionaries/category_codes
        /// Сопоставление с перечислением MailCategory
        /// https://otpravka.pochta.ru/specification#/enums-base-mail-category
        /// </summary>
        internal static Dictionary<MailCategory, int> MailCategoryCodes { get; } =
            new Dictionary<MailCategory, int>
            {
                { MailCategory.Combined, -100 }, // отсутствует в таблице
                { MailCategory.CombinedOrdinary, 8 },
                { MailCategory.CombinedWithDeclaredValue, 9 },
                { MailCategory.CombinedWithDeclaredValueAndCashOnDelivery, 10 },
                { MailCategory.Ordered, 1 },
                { MailCategory.Ordinary, 3 }, // обыкновенное
                { MailCategory.Simple, 0 }, // простое
                { MailCategory.WithCompulsoryPayment, 7 },
                { MailCategory.WithDeclaredValue, 2 },
                { MailCategory.WithDeclaredValueAndCashOnDelivery, 4 },
                { MailCategory.WithDeclaredValueAndCompulsoryPayment, 6 },
            };

        /// <summary>
        /// Generates object type code out of otpravka enum values.
        /// Генерирует тип объекта расчета для тарификатора 
        /// из перечислений API otpravka-api.pochta.ru.
        /// </summary>
        /// <returns>
        /// Integer code corresponding to the ObjectType enum member.
        /// Целочисленный код, соответствующий элементу ObjectType.
        /// </returns>
        internal static int GetObjectTypeCode(MailType mt, MailCategory mc)
        {
            if (MailTypeCodes.TryGetValue(mt, out var mtc) && mtc > 0)
            {
                if (MailCategoryCodes.TryGetValue(mc, out var mcc) && mcc > 0)
                {
                    // например, 4020 = Посылка с объявленной ценностью
                    return mtc * 1000 + mcc * 10;
                }
            }

            return -1;
        }

        /// <summary>
        /// Converts a combination of <see cref="MailType"/> and <see cref="MailCategory"/>
        /// into the <see cref="ObjectType"/> enum member.
        /// </summary>
        /// <param name="mt"><see cref="MailType"/> enum member.</param>
        /// <param name="mc"><see cref="MailCategory"/> enum member.</param>
        /// <returns><see cref="ObjectType"/> enum member.</returns>
        public static ObjectType GetObjectType(this MailType mt, MailCategory mc) =>
            (ObjectType)GetObjectTypeCode(mt, mc);

        /// <summary>
        /// Converts a combination of <see cref="MailType"/> and <see cref="MailCategory"/>
        /// into the <see cref="ObjectType"/> enum member.
        /// </summary>
        /// <param name="mc"><see cref="MailCategory"/> enum member.</param>
        /// <param name="mt"><see cref="MailType"/> enum member.</param>
        /// <returns><see cref="ObjectType"/> enum member.</returns>
        public static ObjectType GetObjectType(this MailCategory mc, MailType mt) =>
            (ObjectType)GetObjectTypeCode(mt, mc);
    }
}
