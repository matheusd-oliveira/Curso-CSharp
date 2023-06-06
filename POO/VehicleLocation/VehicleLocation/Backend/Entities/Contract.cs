using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLocation.Backend.Entities
{
    public class Contract
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public User Name { get; set; }
        public Vehicle Vehicle { get; set; }



        public Contract() { }
        public Contract(DateTime Date, User name, Vehicle vehicle)
        {
            Date = Date;
            Name = name;
            Vehicle = vehicle;
        }


        public override string ToString()
        {
            return "Name: " + Name + "| " + "Date: " + Date.ToString("dd/MM/yyyy") + "| " + "Vehicle Name and Plate: " + Vehicle.Name + ", " + Vehicle.Plate;
        }
    }
}
