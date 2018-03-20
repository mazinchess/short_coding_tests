using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ShortCodingServices;
using ShortCodingTestAPI.Controllers;
using Xunit;

namespace ShortCodingTests.controllers
{
    public class ShortCodingTestControllerTests
    {
        [Fact]
        public void Get_OkResponse_Test()
        {
            var listifyServiceMock = Substitute.For<IListifyService>();

            var controller = new ShortCodingTestController(listifyServiceMock);

            var result = controller.Get(10, 20, 5);

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Get_BadRequest_Test()
        {
            var listifyServiceMock = Substitute.For<IListifyService>();

            var controller = new ShortCodingTestController(listifyServiceMock);

            var badMinValue = controller.Get(-1, 20, 5);
            var minAndMaxValueEquals = controller.Get(20, 20, 5);
            var indexOutOfRange = controller.Get(11, 20, 10);

            Assert.IsType<BadRequestObjectResult>(badMinValue);
            Assert.IsType<BadRequestObjectResult>(minAndMaxValueEquals);
            Assert.IsType<BadRequestObjectResult>(indexOutOfRange);
        }
    }
}