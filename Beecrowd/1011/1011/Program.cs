using System;
using System.Globalization;
namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R;
            double volume;

            R = double.Parse(Console.ReadLine());

            volume = (4  * 3.14159) * (Math.Pow(R, 3)) / 3;

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
            
        }
    }
}
