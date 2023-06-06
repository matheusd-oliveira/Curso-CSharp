using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLocation.Backend.Entities
{
    public class User
    {
        public string Name { get; set; }
        public string Cpf { get; set; }

        public List<Contract> MyContracts { get; set; } = new();

        public User() { }
        public User(string name, string cpf)
        {
            Name = name;
            Cpf = cpf;
        }
        public override string ToString()
        {
            return Name + " | Cpf: " + Cpf;
        }

    }
}
