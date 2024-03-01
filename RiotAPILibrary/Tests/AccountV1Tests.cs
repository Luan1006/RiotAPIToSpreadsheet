using Xunit;
using Luan1006.RiotAPI.Library;

namespace Luan1006.RiotAPI.Library.Tests
{
    public class AccountV1Tests
    {
        [Fact]
        public void AccountV1ClassCanBeInstantiated()
        {
            // Act
            AccountV1 accountV1 = new AccountV1();

            // Assert
            Assert.NotNull(accountV1);
        }
    }
}