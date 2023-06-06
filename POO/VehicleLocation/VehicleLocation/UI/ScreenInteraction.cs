using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLocation.Backend.Entities;
using VehicleLocation.Backend.Services;

namespace VehicleLocation.UI
{
    public class ScreenInteraction
    {
        LocationService ls = new LocationService();
        public void ChooseScreen()
        {
            Screen sc = new Screen();

            int chooseScreen = int.Parse(Console.ReadLine());

            switch (chooseScreen)
            {
                case 1:
                    RegisterVehicle();
                    break;
                case 2:
                    RegisterUser();
                    break;
                case 3:
                    ListVehicles();
                    break;
                case 4:
                    ListUsers();
                    break;
                case 5:
                    ContractActivated();
                    break;
                case 6:
                    RentVehicle();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    sc.ScreenOptions();
                    break;
            }
        }

        private void RegisterVehicle()
        {
            Console.Clear();
            string[] options = { "o Nome", "a Placa", "a Cor", "o Modelo", "o Ano", "a Marca" };
            string[] filledOptions = new string[options.Length];

            for (int i = 0; i < options.Length; i++)
            {
                Console.Write($"Digite {options[i]}: ");
                var enteredValue = Console.ReadLine();
                Console.Clear();
                filledOptions[i] = enteredValue;
            }

            Vehicle vehicle = new Vehicle
            {
                Name = filledOptions[0],
                Plate = filledOptions[1],
                Color = filledOptions[2],
                Model = filledOptions[3],
                Year = Convert.ToInt32(filledOptions[4]),
                Brand = filledOptions[5]
            };

            ls.RegisterVehicle(vehicle);
        }

        private void RegisterUser()
        {
            Console.Clear();
            string[] options = { "o Nome", "o Cpf" };
            string[] filledOptions = new string[options.Length];

            for (int i = 0; i < options.Length; i++)
            {
                Console.Write($"Digite {options[i]}: ");
                var enteredValue = Console.ReadLine();
                Console.Clear();
                filledOptions[i] = enteredValue;
            }

            User user = new User
            {
                Name = filledOptions[0],
                Cpf = filledOptions[1],
            };

            ls.RegisterUser(user);
        }

        private void ListVehicles()
        {
            Console.Clear();
            Console.WriteLine("Os veiculos cadastrados no sistema são: ");
            Console.WriteLine("---------------------------------------");
            foreach (var vehicle in ls.Vehicles)
            {
                Thread.Sleep(2000);
                Console.WriteLine(vehicle);
            }
            Console.WriteLine();
            Console.WriteLine("Aperte uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private void ListUsers()
        {
            Console.Clear();
            Console.WriteLine("Os usuários cadastrados no sistema são: ");
            Console.WriteLine("---------------------------------------");
            foreach (var user in ls.Users)
            {
                Thread.Sleep(2000);
                Console.WriteLine(user);
            }
            Console.WriteLine();
            Console.WriteLine("Aperte uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private void RentVehicle()
        {
            Console.Clear();
            User user = new User();


            if (ls.Users.Count == 0)
            {
                Console.WriteLine("Não há usuários disponíveis para locar.");
                Thread.Sleep(2000);
                Console.WriteLine();
                Console.WriteLine("Aperte qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Escolha um locador: ");

                for (int i = 0; i < ls.Users.Count; i++)
                {
                    Console.WriteLine(i + "- " + ls.Users[i]);

                }
                int chooseUser = int.Parse(Console.ReadLine());
                user = ls.Users[chooseUser];

                Console.Clear();
                Console.WriteLine("Esses são os veículos disponiveis. Escolha um: ");

                foreach (var vehicle in ls.Vehicles)
                {
                    if (vehicle.Available == true)
                    {
                        ls.VehiclesAvailables.Remove(vehicle);
                    }
                    else
                    {
                        if (ls.VehiclesAvailables.Contains(vehicle))
                            continue;

                        ls.VehiclesAvailables.Add(vehicle);
                    }
                }

                if (ls.VehiclesAvailables.Count == 0)
                {
                    
                    Console.WriteLine("Não há veículos disponíveis para locação.");
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine("Aperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    for (int i = 0; i < ls.VehiclesAvailables.Count; i++)
                    {
                        Console.WriteLine(i + "- " + ls.VehiclesAvailables[i]);
                    }
                    Console.WriteLine();


                    int chooseVehicle = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (ls.VehiclesAvailables[chooseVehicle] != null) ls.VehiclesAvailables[chooseVehicle].Available = true;

                    Vehicle veh = ls.VehiclesAvailables[chooseVehicle];
                    Contract newContract = new Contract(DateTime.Now, user, veh);

                    ls.Users[chooseUser].MyContracts.Add(newContract);
                    ls.RentVehicle(newContract);
                }
            }


        }

        private void ContractActivated()
        {
            Console.Clear();
            Console.WriteLine("Contratos Ativos: ");
            Thread.Sleep(2000);
            if (ls.Contracts.Count == 0)
            {
                Console.WriteLine("Nenhum contrato ativo no momento...");
                Thread.Sleep(3000);
                Console.WriteLine();
                Console.WriteLine("Aperte uma tecla para continuar.");
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                foreach (var contract in ls.Contracts)
                {
                    Console.WriteLine(contract);
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
