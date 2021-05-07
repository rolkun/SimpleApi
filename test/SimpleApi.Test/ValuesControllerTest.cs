using Xunit;
using SimpleApi.Controllers;
using Moq;
using Microsoft.Extensions.Logging;

namespace SimpleApi.Test
{
    public class ValuesControllerTest
    {
        Mock<ILogger<ValuesController>> logger;

        ValuesController controller;

        public ValuesControllerTest()
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
