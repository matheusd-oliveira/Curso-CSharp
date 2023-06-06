using System.Text;
using VehicleLocation.Backend.Entities;
using VehicleLocation.Backend.Services;

namespace VehicleLocation.UI
{
    public class Screen
    {
        ScreenInteraction interaction = new ScreenInteraction();

        public void ScreenOptions()
        {
            var chooseScreen = 0;
            while (chooseScreen != 7)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("1 - Register Vehicle\n" +
                    "2 - Register User\n" +
                    "3 - List Vehicles\n" +
                    "4 - List Users\n" +
                    "5 - Active Contracts\n" +
                    "6 - Locate Vehicle\n" +
                    "7 - EXIT");
                Console.Write("");
                Console.WriteLine(sb.ToString());
                interaction.ChooseScreen();
            }
            
        }

        public void WelcomeScreen()
        {
            Console.Write("Starting System");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Write(".");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("UPLOADED SUCCESSFULLY");
            Thread.Sleep(2000);
            Console.Clear();
        }

        //public void ProcessOptionScreen()
        //{
        //    string option = Console.ReadLine();

        //    switch (option)
        //    {
        //        case "1":
        //            Console.Clear();
        //            Console.Write("Name: ");
        //            string name = Console.ReadLine();
        //            Console.Write("Plate: ");
        //            string plate = Console.ReadLine();
        //            Console.Write("Color: ");
        //            string color = Console.ReadLine();
        //            Console.Write("Model: ");
        //            string model = Console.ReadLine();
        //            Console.Write("Year: ");
        //            int year = int.Parse(Console.ReadLine());
        //            Console.Write("Brand: ");
        //            string brand = Console.ReadLine();

        //            ls.RegisterVehicle(new Vehicle(name, plate, color, model, year, brand));
        //            Console.Clear();
        //            break;

        //        case "2":
        //            Console.Clear();
        //            Console.Write("Name: ");
        //            string nameLessor = Console.ReadLine();
        //            Console.Write("Cpf: ");
        //            string cpf = Console.ReadLine();

        //            ls.RegisterUser(new User(nameLessor, cpf));
        //            Console.Clear();
        //            break;

        //        case "3":
        //            Console.Clear();
        //            ls.ListVehicles();
        //            break;
        //        case "4":
        //            Console.Clear();
        //            Console.WriteLine(ls.ListUser());
        //            break;
        //        case "5":
        //            // TODO : Listar os contratos ativos
        //            break;
        //        case "6":
        //        // TODO: Fazer a locação do veiculo
        //        case "7":
        //            Console.Clear();
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            Console.WriteLine("Digitou algo errado.");
        //            break;

        //    }
        //    ScreenOptions();
        //}
    }
}
