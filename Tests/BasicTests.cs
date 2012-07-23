using NUnit.Framework;
using Shouldly;

namespace RDumont.MailChimpApi.Tests
{
    public class BasicTests
    {
        [Test]
        public void Should_create_a_client_with_correct_key()
        {
            // Arrange
            var apiKey = "fb6cd31d4b0f2ff22bc3d2a90edc58d3-us5";
            var dc = "us5";

            // Act
            var client = new MailChimpClient(apiKey);

            // Assert
            client.ShouldNotBe(null);
            client.ApiKey.ShouldBe(apiKey);
            client.Dc.ShouldBe(dc);
        }
    }
}
