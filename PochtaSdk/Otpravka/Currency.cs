using System.Runtime.Serialization;

namespace PochtaSdk.Otpravka
{
    /// <summary>
    /// Currencies.
    /// Валюты.
    /// https://otpravka.pochta.ru/specification#/dictionary-currencies
    /// </summary>
    [DataContract]
    public enum Currency
    {
        /// <summary>
        /// Australian Dollar
        /// Австралийский доллар
        /// </summary>
        [EnumMember(Value = "AUD")]
        AustralianDollar,

        /// <summary>
        /// Azerbaijani Manat
        /// Азербайджанский манат
        /// </summary>
        [EnumMember(Value = "AZN")]
        AzerbaijaniManat,

        /// <summary>
        /// Albanian lek
        /// Албанский лек
        /// </summary>
        [EnumMember(Value = "ALL")]
        AlbanianLek,

        /// <summary>
        /// Algerian Dinar
        /// Алжирский динар
        /// </summary>
        [EnumMember(Value = "DZD")]
        AlgerianDinar,

        /// <summary>
        /// English Pound Sterling
        /// Английский фунт стерлингов
        /// </summary>
        [EnumMember(Value = "GBP")]
        EnglishPoundSterling,

        /// <summary>
        /// Angolan kwanza
        /// Ангольская кванза
        /// </summary>
        [EnumMember(Value = "AOA")]
        AngolanKwanza,

        /// <summary>
        /// Argentine Peso
        /// Аргентинский песо
        /// </summary>
        [EnumMember(Value = "ARS")]
        ArgentinePeso,

        /// <summary>
        /// Armenian Dram
        /// Армянский драм
        /// </summary>
        [EnumMember(Value = "AMD")]
        ArmenianDram,

        /// <summary>
        /// Afghan Afghani
        /// Афганский афгани
        /// </summary>
        [EnumMember(Value = "AFN")]
        AfghanAfghani,

        /// <summary>
        /// Bangladeshi Tak
        /// Бангладешский так
        /// </summary>
        [EnumMember(Value = "BDT")]
        BangladeshiTak,

        /// <summary>
        /// Bahraini Dinar
        /// Бахрейнский динар
        /// </summary>
        [EnumMember(Value = "BHD")]
        BahrainiDinar,

        /// <summary>
        /// Belorussian Ruble
        /// Белорусский рубль
        /// </summary>
        [EnumMember(Value = "BYN")]
        BelorussianRuble,

        /// <summary>
        /// Bulgarian Lev
        /// Болгарский лев
        /// </summary>
        [EnumMember(Value = "BGN")]
        BulgarianLev,

        /// <summary>
        /// Bolivar
        /// Боливар
        /// </summary>
        [EnumMember(Value = "VEF")]
        Bolivar,

        /// <summary>
        /// Bolivian Boliviano
        /// Боливийский боливиано
        /// </summary>
        [EnumMember(Value = "BOB")]
        BolivianBoliviano,

        /// <summary>
        /// Botswana Pool
        /// Ботсванская пула
        /// </summary>
        [EnumMember(Value = "BWP")]
        BotswanaPool,

        /// <summary>
        /// Brazilian Real
        /// Бразильский реал
        /// </summary>
        [EnumMember(Value = "BRL")]
        BrazilianReal,

        /// <summary>
        /// Brunei Dollar
        /// Брунейский доллар
        /// </summary>
        [EnumMember(Value = "BND")]
        BruneiDollar,

        /// <summary>
        /// Burundian Franc
        /// Бурундийский франк
        /// </summary>
        [EnumMember(Value = "BIF")]
        BurundianFranc,

        /// <summary>
        /// Hungarian Forint
        /// Венгерский форинт
        /// </summary>
        [EnumMember(Value = "HUF")]
        HungarianForint,

        /// <summary>
        /// North Korea's Won
        /// Вона КНДР
        /// </summary>
        [EnumMember(Value = "KPW")]
        NorthKoreanWon,

        /// <summary>
        /// Won of the Republic of Korea
        /// Вон республики Корея
        /// </summary>
        [EnumMember(Value = "KRW")]
        SouthKoreanWon,

        /// <summary>
        /// Vietnamese Dong
        /// Вьетнамский донг
        /// </summary>
        [EnumMember(Value = "VND")]
        VietnameseDong,

        /// <summary>
        /// Gambian Dalasi
        /// Гамбийский даласи
        /// </summary>
        [EnumMember(Value = "GMD")]
        GambianDalasi,

        /// <summary>
        /// Guinea Franc
        /// Гвинейский франк
        /// </summary>
        [EnumMember(Value = "GNF")]
        GuineaFranc,

        /// <summary>
        /// Hong Kong Dollar
        /// Гонконгский доллар
        /// </summary>
        [EnumMember(Value = "HKD")]
        HongKongDollar,

        /// <summary>
        /// Georgian Lari
        /// Грузинский лари
        /// </summary>
        [EnumMember(Value = "GEL")]
        GeorgianLari,

        /// <summary>
        /// Danish Krona
        /// Датская крона
        /// </summary>
        [EnumMember(Value = "DKK")]
        DanishKrona,

        /// <summary>
        /// Djibouti Franc
        /// Джибутийский франк
        /// </summary>
        [EnumMember(Value = "DJF")]
        DjiboutiFranc,

        /// <summary>
        /// United Arab Emirates Dirhams
        /// Дирхам оаэ
        /// </summary>
        [EnumMember(Value = "AED")]
        UnitedArabEmiratesDirhams,

        /// <summary>
        /// Namibian Dollar
        /// Доллар намибии
        /// </summary>
        [EnumMember(Value = "NAD")]
        NamibianDollar,

        /// <summary>
        /// US Dollar
        /// Доллар сша
        /// </summary>
        [EnumMember(Value = "USD")]
        USDollar,

        /// <summary>
        /// Euro
        /// Евро
        /// </summary>
        [EnumMember(Value = "EUR")]
        Euro,

        /// <summary>
        /// Egyptian Pound
        /// Египетский фунт
        /// </summary>
        [EnumMember(Value = "EGP")]
        EgyptianPound,

        /// <summary>
        /// Zambian Kwacha
        /// Замбийская квача
        /// </summary>
        [EnumMember(Value = "ZMK")]
        ZambianKwacha,

        /// <summary>
        /// Israeli New Shekel
        /// Израильский новый шекель
        /// </summary>
        [EnumMember(Value = "ILS")]
        IsraeliNewShekel,

        /// <summary>
        /// Indian Rupee
        /// Индийская рупия
        /// </summary>
        [EnumMember(Value = "INR")]
        IndianRupee,

        /// <summary>
        /// Indonesian Rupiah
        /// Индонезийская рупия
        /// </summary>
        [EnumMember(Value = "IDR")]
        IndonesianRupiah,

        /// <summary>
        /// Jordanian Dinar
        /// Иорданский динар
        /// </summary>
        [EnumMember(Value = "JOD")]
        JordanianDinar,

        /// <summary>
        /// Iraqi Dinar
        /// Иракский динар
        /// </summary>
        [EnumMember(Value = "IQD")]
        IraqiDinar,

        /// <summary>
        /// Iranian Rial
        /// Иранский риал
        /// </summary>
        [EnumMember(Value = "IRR")]
        IranianRial,

        /// <summary>
        /// Icelandic Krona
        /// Исландская крона
        /// </summary>
        [EnumMember(Value = "ISK")]
        IcelandicKrona,

        /// <summary>
        /// Yemeni Rial
        /// Йеменский риал
        /// </summary>
        [EnumMember(Value = "YER")]
        YemeniRial,

        /// <summary>
        /// Kazakh Tenge
        /// Казахский тенге
        /// </summary>
        [EnumMember(Value = "KZT")]
        KazakhTenge,

        /// <summary>
        /// Cambodian Riel
        /// Камбоджийский риель
        /// </summary>
        [EnumMember(Value = "KHR")]
        CambodianRiel,

        /// <summary>
        /// Canadian Dollar
        /// Канадский доллар
        /// </summary>
        [EnumMember(Value = "CAD")]
        CanadianDollar,

        /// <summary>
        /// Qatari Rial
        /// Катарский риал
        /// </summary>
        [EnumMember(Value = "QAR")]
        QatariRial,

        /// <summary>
        /// Kenyan Sheeling
        /// Кенийский шилинг
        /// </summary>
        [EnumMember(Value = "KES")]
        KenyanSheeling,

        /// <summary>
        /// Kyrgyz Som
        /// Киргизский сом
        /// </summary>
        [EnumMember(Value = "KGS")]
        KyrgyzSom,

        /// <summary>
        /// Chinese Yuan
        /// Китайский юань
        /// </summary>
        [EnumMember(Value = "CNY")]
        ChineseYuan,

        /// <summary>
        /// Colombian Peso
        /// Колумбийский песо
        /// </summary>
        [EnumMember(Value = "COP")]
        ColombianPeso,

        /// <summary>
        /// Congolese Franc
        /// Конголезский франк
        /// </summary>
        [EnumMember(Value = "CDF")]
        CongoleseFranc,

        /// <summary>
        /// Costa Rican Colon
        /// Костариканский колон
        /// </summary>
        [EnumMember(Value = "CRC")]
        CostaRicanColon,

        /// <summary>
        /// Cuban Peso
        /// Кубинский песо
        /// </summary>
        [EnumMember(Value = "CUP")]
        CubanPeso,

        /// <summary>
        /// Kuwaiti Dinar
        /// Кувейтский динар
        /// </summary>
        [EnumMember(Value = "KWD")]
        KuwaitiDinar,

        /// <summary>
        /// Lao kip
        /// Лаосский кип
        /// </summary>
        [EnumMember(Value = "LAK")]
        LaoKip,

        /// <summary>
        /// Sierra-Leone Leone
        /// Леоне сьерра-леоне
        /// </summary>
        [EnumMember(Value = "SLL")]
        SierraLeoneLeone,

        /// <summary>
        /// Lebanese Pound
        /// Ливанский фунт
        /// </summary>
        [EnumMember(Value = "LBP")]
        LebanesePound,

        /// <summary>
        /// Libyan Dinar
        /// Ливийский динар
        /// </summary>
        [EnumMember(Value = "LYD")]
        LibyanDinar,

        /// <summary>
        /// Mauritian Rupee
        /// Маврикийская рупия
        /// </summary>
        [EnumMember(Value = "MUR")]
        MauritianRupee,

        /// <summary>
        /// Moorish Ugia
        /// Мавританская угия
        /// </summary>
        [EnumMember(Value = "MRO")]
        MoorishUgia,

        /// <summary>
        /// Macedonian Dinar
        /// Македонский динар
        /// </summary>
        [EnumMember(Value = "MKD")]
        MacedonianDinar,

        /// <summary>
        /// Malawian Kwacha
        /// Малавийская квача
        /// </summary>
        [EnumMember(Value = "MWK")]
        MalawianKwacha,

        /// <summary>
        /// Malagasy Ariari
        /// Малагасийский ариари
        /// </summary>
        [EnumMember(Value = "MGA")]
        MalagasyAriari,

        /// <summary>
        /// Malaysian Ringgit
        /// Малайзийский ринггит
        /// </summary>
        [EnumMember(Value = "MYR")]
        MalaysianRinggit,

        /// <summary>
        /// Moroccan Dirhams
        /// Марокканский дирхам
        /// </summary>
        [EnumMember(Value = "MAD")]
        MoroccanDirhams,

        /// <summary>
        /// Mexican Peso
        /// Мексиканский песо
        /// </summary>
        [EnumMember(Value = "MXN")]
        MexicanPeso,

        /// <summary>
        /// Mozambique Metical
        /// Мозамбикский метикал
        /// </summary>
        [EnumMember(Value = "MZN")]
        MozambiqueMetical,

        /// <summary>
        /// Moldovan Leu
        /// Молдавский лей
        /// </summary>
        [EnumMember(Value = "MDL")]
        MoldovanLeu,

        /// <summary>
        /// Mongolian Tugrik
        /// Монгольский тугрик
        /// </summary>
        [EnumMember(Value = "MNT")]
        MongolianTugrik,

        /// <summary>
        /// Nepalese Rupee
        /// Непальская рупия
        /// </summary>
        [EnumMember(Value = "NPR")]
        NepaleseRupee,

        /// <summary>
        /// Nigerian Naira
        /// Нигерийская найра
        /// </summary>
        [EnumMember(Value = "NGN")]
        NigerianNaira,

        /// <summary>
        /// Nicaraguan golden Cordoba
        /// Никарагуанская золотая кордоба
        /// </summary>
        [EnumMember(Value = "NIO")]
        NicaraguanGoldenCordoba,

        /// <summary>
        /// New Turkish Lira
        /// Новая турецкая лира
        /// </summary>
        [EnumMember(Value = "TRY")]
        NewTurkishLira,

        /// <summary>
        /// New Zealand Dollar
        /// Новозеландский доллар
        /// </summary>
        [EnumMember(Value = "NZD")]
        NewZealandDollar,

        /// <summary>
        /// New Romanian Leu
        /// Новый румынский лей
        /// </summary>
        [EnumMember(Value = "RON")]
        NewRomanianLeu,

        /// <summary>
        /// New Turkmen Manat
        /// Новый туркменский манат
        /// </summary>
        [EnumMember(Value = "TMT")]
        NewTurkmenManat,

        /// <summary>
        /// Norwegian Krone
        /// Норвежская крона
        /// </summary>
        [EnumMember(Value = "NOK")]
        NorwegianKrone,

        /// <summary>
        /// Omani Rial
        /// Оманский риал
        /// </summary>
        [EnumMember(Value = "OMR")]
        OmaniRial,

        /// <summary>
        /// Pakistani Rupee
        /// Пакистанская рупия
        /// </summary>
        [EnumMember(Value = "PKR")]
        PakistaniRupee,

        /// <summary>
        /// Paraguayan Guarani
        /// Парагвайский гуарани
        /// </summary>
        [EnumMember(Value = "PYG")]
        ParaguayanGuarani,

        /// <summary>
        /// Peruvian New Salt
        /// Перуанская новая соль
        /// </summary>
        [EnumMember(Value = "PEN")]
        PeruvianNewSalt,

        /// <summary>
        /// Polish Zloty
        /// Польский злотый
        /// </summary>
        [EnumMember(Value = "PLN")]
        PolishZloty,

        /// <summary>
        /// Riyal of Saudi Arabia
        /// Риял саудовской аравии
        /// </summary>
        [EnumMember(Value = "SAR")]
        SaudiArabiaRiyal,

        /// <summary>
        /// Russian Ruble
        /// Рубль российский
        /// </summary>
        [EnumMember(Value = "RUB")]
        RussianRuble,

        /// <summary>
        /// Swaziland Lilangeni
        /// Свазиледский лилангени
        /// </summary>
        [EnumMember(Value = "SZL")]
        SwazilandLilangeni,

        /// <summary>
        /// Seychelles Rupee
        /// Сейшельская рупия
        /// </summary>
        [EnumMember(Value = "SCR")]
        SeychellesRupee,

        /// <summary>
        /// Serbian Dinar
        /// Сербский динар
        /// </summary>
        [EnumMember(Value = "RSD")]
        SerbianDinar,

        /// <summary>
        /// Singapore Dollar
        /// Сингапурский доллар
        /// </summary>
        [EnumMember(Value = "SGD")]
        SingaporeDollar,

        /// <summary>
        /// Syrian Pound
        /// Сирийский фунт
        /// </summary>
        [EnumMember(Value = "SYP")]
        SyrianPound,

        /// <summary>
        /// Somali Shilling
        /// Сомалийский шиллинг
        /// </summary>
        [EnumMember(Value = "SOS")]
        SomaliShilling,

        /// <summary>
        /// Xdr
        /// Спз
        /// </summary>
        [EnumMember(Value = "XDR")]
        Xdr,

        /// <summary>
        /// Sudanese Dinar
        /// Суданский динар
        /// </summary>
        [EnumMember(Value = "SDG")]
        SudaneseDinar,

        /// <summary>
        /// Surinamese Dollar
        /// Суринамский доллар
        /// </summary>
        [EnumMember(Value = "SRD")]
        SurinameseDollar,

        /// <summary>
        /// Tajik Somoni
        /// Таджикский сомони
        /// </summary>
        [EnumMember(Value = "TJS")]
        TajikSomoni,

        /// <summary>
        /// Thai Baht
        /// Таиландский бат
        /// </summary>
        [EnumMember(Value = "THB")]
        ThaiBaht,

        /// <summary>
        /// Taiwan New Dollar
        /// Тайваньский новый доллар
        /// </summary>
        [EnumMember(Value = "TWD")]
        TaiwanNewDollar,

        /// <summary>
        /// Tanzanian Shilling
        /// Танзанийский шиллинг
        /// </summary>
        [EnumMember(Value = "TZS")]
        TanzanianShilling,

        /// <summary>
        /// Tunisian Dinar
        /// Тунисский динар
        /// </summary>
        [EnumMember(Value = "TND")]
        TunisianDinar,

        /// <summary>
        /// Ugandan Shilling
        /// Угандийский шиллинг
        /// </summary>
        [EnumMember(Value = "UGX")]
        UgandanShilling,

        /// <summary>
        /// Uzbek Sum
        /// Узбекский сум
        /// </summary>
        [EnumMember(Value = "UZS")]
        UzbekSum,

        /// <summary>
        /// Ukrainian hryvnia
        /// Украинская гривна
        /// </summary>
        [EnumMember(Value = "UAH")]
        UkrainianHryvnia,

        /// <summary>
        /// Uruguayan Peso
        /// Уругвайский песо
        /// </summary>
        [EnumMember(Value = "UYU")]
        UruguayanPeso,

        /// <summary>
        /// Philippine Peso
        /// Филиппинский песо
        /// </summary>
        [EnumMember(Value = "PHP")]
        PhilippinePeso,

        /// <summary>
        /// CFA Franc
        /// Франк кфа
        /// </summary>
        [EnumMember(Value = "XAF")]
        CfaFranc,

        /// <summary>
        /// Francs cfa allao //???
        /// Франков кфа всеао
        /// </summary>
        [EnumMember(Value = "XOF")]
        FrancsCfaAllao,

        /// <summary>
        /// Croatian kuna
        /// Хорватская куна
        /// </summary>
        [EnumMember(Value = "HRK")]
        CroatianKuna,

        /// <summary>
        /// Czech Crown
        /// Чешская крона
        /// </summary>
        [EnumMember(Value = "CZK")]
        CzechCrown,

        /// <summary>
        /// Chilean Peso
        /// Чилийский песо
        /// </summary>
        [EnumMember(Value = "CLP")]
        ChileanPeso,

        /// <summary>
        /// Swedish Krona
        /// Шведская крона
        /// </summary>
        [EnumMember(Value = "SEK")]
        SwedishKrona,

        /// <summary>
        /// Swiss Franc
        /// Швейцарский франк
        /// </summary>
        [EnumMember(Value = "CHF")]
        SwissFranc,

        /// <summary>
        /// Sri Lankan Rupee
        /// Шри-ланкийская рупия
        /// </summary>
        [EnumMember(Value = "LKR")]
        SriLankanRupee,

        /// <summary>
        /// Ethiopian birr
        /// Эфиопский быр
        /// </summary>
        [EnumMember(Value = "ETB")]
        EthiopianBirr,

        /// <summary>
        /// South African Rand
        /// Южноафриканский рэнд
        /// </summary>
        [EnumMember(Value = "ZAR")]
        SouthAfricanRand,

        /// <summary>
        /// Japanese Yen
        /// Японская йена
        /// </summary>
        [EnumMember(Value = "JPY")]
        JapaneseYen,
    }
}
