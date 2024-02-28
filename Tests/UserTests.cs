using Xunit;
using Luan1006.RiotAPI;

public class UserTests
{
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
    public void UserClassHasPuuidProperty()
    {
        // Arrange
        User user = new User();

        // Act
        user.puuid = "1234";

        // Assert
        Assert.Equal("1234", user.puuid);
    }
}