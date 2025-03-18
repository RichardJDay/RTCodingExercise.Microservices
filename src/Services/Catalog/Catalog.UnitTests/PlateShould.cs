using Catalog.API.Repositories;
using Catalog.API.Services;
using Catalog.Domain;
using Moq;
using System.Collections.Generic;
using System;
using Xunit;
using System.Threading.Tasks;

namespace Catalog.UnitTests
{
    public class PlateTests
    {

        [Fact]
        public async Task GetPlates()
        {
            var mockRepo = new Mock<IPlateRepository>();
            var expectedPlates = new List<Plate>
            {
                { new Plate { Id = Guid.NewGuid(), SalePrice = 100 } },
                { new Plate { Id = Guid.NewGuid(), SalePrice = 100 } }
            };

            mockRepo.Setup(repo => repo.GetPlates()).ReturnsAsync(expectedPlates);

            var plateService = new PlateService(mockRepo.Object);

            var result = await plateService.GetPlates();

            Assert.Equal(expectedPlates, result);

        }
    }
}