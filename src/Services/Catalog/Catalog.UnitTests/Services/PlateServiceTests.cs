using Catalog.API.Repositories;
using Catalog.API.Services;
using Catalog.Domain;
using Moq;
using System.Collections.Generic;
using System;
using Xunit;
using System.Threading.Tasks;

namespace Catalog.UnitTests.Services
{
    public class PlateServiceTests
    {
        [Fact]
        public async Task GetPlates_ShouldReturnListOfPlates()
        {
            var mockRepo = new Mock<IPlateRepository>();
            var expectedPlates = new List<Plate>
            {
                new Plate { Id = Guid.NewGuid(), SalePrice = 100 },
                new Plate { Id = Guid.NewGuid(), SalePrice = 100 }
            };

            mockRepo.Setup(repo => repo.GetPlates(20, 1)).ReturnsAsync(expectedPlates);

            var plateService = new PlateService(mockRepo.Object);

            var result = await plateService.GetPlates(20, 1);

            Assert.Equal(expectedPlates, result);
        }

        [Fact]
        public async Task CreatePlates_ShouldReturnCreatedPlate()
        {
            var mockRepo = new Mock<IPlateRepository>();

            var newPlate = new Plate { Id = Guid.NewGuid(), SalePrice = 100 };
            mockRepo.Setup(repo => repo.CreatePlate(newPlate)).ReturnsAsync(newPlate);

            var plateService = new PlateService(mockRepo.Object);

            var result = await plateService.CreatePlate(newPlate);

            Assert.Equal(newPlate, result);
        }
    }
}