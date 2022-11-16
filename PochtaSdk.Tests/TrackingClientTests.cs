using NUnit.Framework;

namespace PochtaSdk.Tests
{
    [TestFixture]
    public class TrackingClientTests : TestBase
    {
        private TrackingClient Client { get; } = new TrackingClient(
            Env("TRACKING_USER_NAME"),
            Env("TRACKING_USER_PASSWORD")
        );

        [Test]
        public void GetOperationHistory()
        {
            // Российская почта
            var result = Client.GetOperationHistory("12542476046939");
            Assert.That(result, Is.Not.Null.And.Not.Empty);

            // Международная почта
            result = Client.GetOperationHistory("LC528964811CN");
            Assert.That(result, Is.Not.Null.And.Not.Empty);
        }
    }
}
