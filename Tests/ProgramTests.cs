using Xunit;
using Luan1006.RiotAPI;
using System.Text.RegularExpressions;

public class ProgramTests
{
    [Fact]
    public void APIKeyIsNotEmpty()
    {
        // Arrange
        string key = Program.Key;

        // Act
        bool result = key.Length > 0;

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void APIKeyIsValidFormat()
    {
        // Arrange
        string key = APIKey.Key;

        // Act
        Regex rgx = new Regex(@"^RGAPI-\w{8}-\w{4}-\w{4}-\w{4}-\w{12}$");
        bool result = rgx.IsMatch(key);

        // Assert
        Assert.True(result, "API key is not in valid format");
    }
}