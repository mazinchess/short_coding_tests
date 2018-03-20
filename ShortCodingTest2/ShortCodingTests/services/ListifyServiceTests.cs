using NSubstitute;
using ShortCodingServices.impls;
using Xunit;

namespace ShortCodingTests.services
{
    public class ListifyServiceTests
    {
        [Fact]
        public void GetElement_Test()
        {
            var mock = Substitute.For<ListifyServiceImpl>();
            var element = mock.GetElement(10, 20, 5);
            Assert.Equal(15, element);
            Assert.NotEqual(16, element);
        }
    }
}