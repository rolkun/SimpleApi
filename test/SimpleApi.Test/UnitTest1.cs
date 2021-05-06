using Xunit;
using SimpleApi.Controllers;
using Moq;
using Microsoft.Extensions.Logging;

namespace SimpleApi.Test
{
    public class UnitTest1
    {
        Mock<ILogger<ValuesController>> logger;

        ValuesController controller;

        public UnitTest1()
        {
            logger = new Mock<ILogger<ValuesController>>();
            this.controller = new ValuesController(this.logger.Object);
        }

        [Fact]
        public void GetByNumber1ShouldReturnMyName()
        {
            var result = controller.Get(1);

            Assert.Equal("Roland Kunz", result.Value);
        }
    }
}
