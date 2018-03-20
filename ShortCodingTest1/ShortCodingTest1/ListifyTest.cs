using NSubstitute;
using ShortCodingTest1.impl;
using Xunit;

namespace ShortCodingTest1
{
    public class ListifyTest
    {
        [Fact]
        public void GetElementAtPosition()
        {
            var mock = Substitute.For<ListifyCustom>(100, 200);
            var element = mock.GetElementAtPosition(50);
            var element2 = mock[50];
            Assert.Equal(150, element);
            Assert.Equal(150, element2);
            Assert.Equal(element, element2);
            Assert.NotEqual(160, element);
            Assert.NotEqual(160, element2);
        }
    }
}