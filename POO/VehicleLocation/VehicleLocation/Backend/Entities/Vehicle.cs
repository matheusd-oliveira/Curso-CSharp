using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLocation.Backend.Entities
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Plate { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
        public bool Available { get; set; } = false;

        public Vehicle()
        {
        }

        public Vehicle(string name, string plate, string color, string model, int year, string brand, bool available)
        {
            Name = name;
            Plate = plate;
            Color = color;
            Model = model;
            Year = year;
            Brand = brand;
            Available = available;
        }

        public override string ToString()
        {
            return Name + "| " + Plate + "| " + Color + "| " + Model + "| " + Year + "| " + Brand;
        }

    }
}
