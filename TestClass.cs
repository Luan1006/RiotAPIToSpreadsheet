using Xunit;
using Luan1006.RiotAPI;

public class TestClass
{
    [Fact]
    public void TestMethod()
    {
        Assert.True(true);
    }

    [Fact]
    public void UserClassCanBeInstantiated()
    {
        // Act
        User user = new User();

        // Assert
        Assert.NotNull(user);
    }

    [Fact]
    public void UserClassHasGameNameProperty()
    {
        // Arrange
        User user = new User();

        // Act
        user.gameName = "Luan";

        // Assert
        Assert.Equal("Luan", user.gameName);
    }

    [Fact]
    public void UserClassHasTagLineProperty()
    {
        // Arrange
        User user = new User();

        // Act
        user.tagLine = "1006";

        // Assert
        Assert.Equal("1006", user.tagLine);
    }

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