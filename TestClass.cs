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
    public void UserClassExists()
    {
        // Act
        User user = new User();

        // Assert
        Assert.NotNull(user);
    }
}