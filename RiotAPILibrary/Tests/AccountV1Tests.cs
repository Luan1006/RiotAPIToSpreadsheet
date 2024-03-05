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
            Mock<HttpMessageHandler> mockHttpMessageHandler = new Mock<HttpMessageHandler>();
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

            HttpClient client = new HttpClient(mockHttpMessageHandler.Object);
            AccountV1 accountV1 = new AccountV1(client);
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

        [Fact]
        public async Task GetAccountByRiotID_WhenResponseIsSuccess()
        {
            // Arrange
            Mock<HttpMessageHandler> mockHttpMessageHandler = new Mock<HttpMessageHandler>();
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

            HttpClient client = new HttpClient(mockHttpMessageHandler.Object);
            AccountV1 accountV1 = new AccountV1(client);
            string testGameName = "testGameName";
            string testTagLine = "testTagLine";
            string testApiKey = "testApiKey";

            // Act
            AccountDto result = await accountV1.GetAccountByRiotID(testGameName, testTagLine, testApiKey);
        }
    }
}