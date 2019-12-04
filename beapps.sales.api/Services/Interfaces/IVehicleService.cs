using beapps.sales.api.Entities;
using System.Collections.Generic;

namespace beapps.sales.api.Services.Interfaces
{
    public interface IVehicleService
    {
        bool Create(Vehicle vehicle);
        List<Vehicle> GetVehicles();
    }
}
