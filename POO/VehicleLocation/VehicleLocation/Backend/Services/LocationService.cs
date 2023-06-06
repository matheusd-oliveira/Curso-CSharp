using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLocation.Backend.Entities;

namespace VehicleLocation.Backend.Services
{
    public class LocationService
    {
        public List<User> Users { get; set; } = new();

        public List<Vehicle> Vehicles { get; set; } = new();

        public List<Vehicle> VehiclesAvailables { get; set; } = new();

        public List<Contract> Contracts { get; set; } = new();

        public void RegisterUser(User lessor)
        {
            Users.Add(lessor);
        }

        public void RegisterVehicle(Vehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public List<User> ListUser()
        {
            return Users.ToList();
        }

        public List<Vehicle> ListVehicles()
        {
            return Vehicles.ToList();
        }

        public void RentVehicle(Contract contract)
        {
            Contracts.Add(contract);
        }

        public List<Contract> ContractActivated()
        {
            return Contracts.ToList();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
