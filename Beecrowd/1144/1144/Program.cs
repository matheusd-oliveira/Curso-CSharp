namespace _1144
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= num; i++)
            {  
                Console.WriteLine($"{i} {i * i} {(i * i) * i}");
                Console.WriteLine($"{i} {(i * i) + 1} {((i* i) * i) + 1}");
            }
        }
    }
}