using Xunit;
using Luan1006.RiotAPI;

public class ProgramTests
{
    [Fact]
    public void APIKeyIsNotEmpty()
    {
        // Arrange
        string key = Program.key;

        // Act
        bool result = key.Length > 0;

        // Assert
        Assert.True(result);
    }
}