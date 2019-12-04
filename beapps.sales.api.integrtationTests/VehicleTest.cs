using beapps.sales.api.Controllers;
using beapps.sales.api.Entities;
using beapps.sales.api.Services.Interfaces;
using GenFu;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace beapps.sales.api.integrtationTests
{
    public class VehicleTest
    {
        [Fact]
        public void GetVehicles()
        {
            var _vehicleService = new Mock<IVehicleService>();
            var vehicles = GenFu.GenFu.ListOf<Vehicle>();

            _vehicleService.Setup(x => x.GetVehicles()).Returns(vehicles);
            var controller = new VehicleController(_vehicleService.Object);

            var response = controller.GetVehicles().Result;
            Assert.IsType<OkObjectResult>(response);
            _vehicleService.Verify(x => x.GetVehicles(), Times.Once);
        }
    }
}
