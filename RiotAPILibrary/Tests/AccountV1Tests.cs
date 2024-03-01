using Xunit;
using Moq;
using Moq.Protected;
using System.Net;
using System.Text;
using Luan1006.RiotAPI.Library;

namespace Luan1006.RiotAPI.Library.Tests
{
    public class AccountV1Tests
    {
        [Fact]
        public async Task GetAccountByPuuid_ReturnsAccountDto_WhenResponseIsSuccess()
        {
            // Arrange
            var mockHttpMessageHandler = new Mock<HttpMessageHandler>();
            mockHttpMessageHandler
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("{\"puuid\": \"testPuuid\", \"gameName\": \"testGameName\", \"tagLine\": \"testTagLine\"}", Encoding.UTF8, "application/json"),
                });

            var client = new HttpClient(mockHttpMessageHandler.Object);
            var accountV1 = new AccountV1(client);
            string testPuuid = "testPuuid";
            string testApiKey = "testApiKey";

            // Act
            AccountDto result = await accountV1.GetAccountByPuuid(testPuuid, testApiKey);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(testPuuid, result.puuid);
            Assert.Equal("testGameName", result.gameName);
            Assert.Equal("testTagLine", result.tagLine);
        }
    }
}