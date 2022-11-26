using NUnit.Framework;
using PochtaSdk.Otpravka;
using PochtaSdk.Tariff;
using PochtaSdk.Toolbox;

namespace PochtaSdk.Tests
{
    [TestFixture]
    public class HelperMethodsTests
    {
        [Test]
        public void CoalesceReturnsTheFirstNonEmptyString()
        {
            Assert.That("".Coalesce(null, "  ", "Hello", "World"), Is.EqualTo("Hello"));
            Assert.That(default(string).Coalesce(null, "  ", "", "hi"), Is.EqualTo("hi"));
            Assert.That("  ".Coalesce(null, "  ", "", null, ""), Is.EqualTo(""));
            Assert.That("".Coalesce(null, null), Is.EqualTo(null));
            Assert.That("".Coalesce(null), Is.EqualTo(""));
        }

        [Test]
        public void GetObjectTypeReturnsObjectTypes()
        {
            Assert.That(MailType.Letter.GetObjectType(MailCategory.Simple), Is.EqualTo(ObjectType.LetterRegular));
            Assert.That(MailType.BanderolClass1.GetObjectType(MailCategory.WithDeclaredValue), Is.EqualTo(ObjectType.Wrapper1ClassWithDeclaredValue));
            Assert.That(MailType.OnlineParcel.GetObjectType(MailCategory.WithDeclaredValueAndCashOnDelivery), Is.EqualTo(ObjectType.ParcelOnlineWithDeclaredValueAndCashOnDelivery));
            Assert.That(MailType.OnlineCourier.GetObjectType(MailCategory.WithDeclaredValue), Is.EqualTo(ObjectType.CourierOnlineWithDeclaredValue));

            Assert.That(MailCategory.Ordinary.GetObjectType(MailType.PostalParcel), Is.EqualTo(ObjectType.Parcel));
            Assert.That(MailCategory.CombinedOrdinary.GetObjectType(MailType.OnlineParcel), Is.EqualTo(ObjectType.ParcelOnlineCombined));
            Assert.That(MailCategory.CombinedWithDeclaredValue.GetObjectType(MailType.OnlineParcel), Is.EqualTo(ObjectType.ParcelOnlineCombinedWithDeclaredValue));
            Assert.That(MailCategory.Ordered.GetObjectType(MailType.Letter), Is.EqualTo(ObjectType.LetterRegistered));
        }
    }
}
