using Xunit;
using static Luan1006.RiotAPI.Library.HelperMethods;

namespace Luan1006.RiotAPI.Library.Tests
{
    public class HelperMethodsTests
    {
        [Fact]
        public static void CreateApiURL_WithNoQuestionMarkInParameter_ReturnsLinkWithQuestionMark()
        {
            // Arrange
            string endpoint = "someEndpoint";
            string apiKey = "someAPIKey";
            string expected = "someEndpoint?api_key=someAPIKey";

            // Act
            string actual = CreateApiURL(endpoint, apiKey);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public static void CreateApiURL_WithQuestionMarkInParamter_ReturnsLinkWithAmpersand()
        {
            // Arrange
            string endpoint = "someEndpoint?someQuery";
            string apiKey = "someAPIKey";
            string expected = "someEndpoint?someQuery&api_key=someAPIKey";

            // Act
            string actual = CreateApiURL(endpoint, apiKey);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}