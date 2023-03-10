using ExLinq02.Entities;
using System.Globalization;
namespace ExLinq02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            List<Employees> list = new();


            using (StreamReader sr = File.OpenText(path))
            {
                while (!(sr.EndOfStream))
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string mail = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employees(name, mail, salary));
                }
                sr.Close();
            }

            Console.Write("Enter salary: R$");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Realizando operações Linq
            var mails = list.Where(e => e.Salary > value).OrderBy(e => e.Mail).Select(e => e.Mail);
            Console.WriteLine("Email of people have salary more than 2000.00:");
            foreach (var mail in mails)
            {
                Console.WriteLine(mail);
            }
            Console.WriteLine();

            var sumSalarys = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.Write("Sum of Employees that have a name begin with letter M is: R$");
            Console.WriteLine(sumSalarys.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}