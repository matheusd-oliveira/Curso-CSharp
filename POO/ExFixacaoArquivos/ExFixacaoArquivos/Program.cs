using System.Globalization;

namespace ExFixacaoArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\products.txt";
            string filePath = @"c:\temp\out\summary.txt";

            try
            {            
                using (StreamReader sr = File.OpenText(path))
                {
                       
                    while (!sr.EndOfStream)
                    {
                        string[] lines = sr.ReadLine().Split(',');

                        using (StreamWriter sw = File.AppendText(filePath))
                        {
                            foreach (string line in lines)
                            {
                                var name = lines[0];
                                var result = int.Parse(lines[1]) * int.Parse(lines[2]);

                                sw.Write(name);
                                sw.Write(",");
                                sw.Write(result.ToString("F2", CultureInfo.InvariantCulture));
                                sw.WriteLine();

                            }
                        }
                    }
                    
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }



        }
    }
}