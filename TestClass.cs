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
}