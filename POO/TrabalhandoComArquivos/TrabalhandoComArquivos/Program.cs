using System.IO;

namespace TrabalhandoComArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            // Testando a classe Path.
            string path = @"c:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " +  Path.GetTempPath());


            //string path = @"c:\temp\myfolder";

            
            //try
            //{
            //    // Pegando todas as subpastas a partir da original / pasta informada.
            //    // Nome do arquivo, qualquer nome do arquivo ponto qualquer extensao, opção de busca
            //    var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FOLDERS: ");
            //    foreach (string folderName in folders)
            //    {
            //        Console.WriteLine(folderName);
            //    }
            //    // Listando todos os arquivos
            //    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FILES: ");
            //    foreach (string f in files)
            //    {
            //        Console.WriteLine(f);
            //    }

            //    Directory.CreateDirectory(@"c:\temp\myfolder\newfolder");
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            //string sourcePath = @"c:\temp\file1.txt";
            //string targetPath = @"c:\temp\file2.txt";

            //try
            //{
            //    string[] lines = File.ReadAllLines(sourcePath);

            //    using (StreamWriter sw = File.AppendText(targetPath))
            //    {
            //        foreach (string line in lines)
            //        {
            //            sw.WriteLine(line.ToUpper());
            //        }
            //    }

            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}




            //string path = @"c:\temp\file1.txt";

            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            //try
            //{
            //    using (FileStream fs = new FileStream(path, FileMode.Open))
            //    {
            //        // é possivel fazer uma cascata de using também
            //        using (StreamReader sr = new StreamReader(fs))
            //        {
            //            while (!sr.EndOfStream)
            //            {
            //                string line = sr.ReadLine();
            //                Console.WriteLine(line);
            //            }
            //        }
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}


            //string path = @"c:\temp\file1.txt";
            //StreamReader sr = null;

            //try
            //{
            //    sr = File.OpenText(path);
            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }   
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (sr != null) sr.Close();
            //}


            //string sourcePath = @"c:\temp\file1.txt";
            //string targetPath = @"c:\temp\file2.txt";

            //try
            //{
            //    FileInfo fileInfo = new FileInfo(sourcePath);
            //    fileInfo.CopyTo(targetPath);

            //    string[] lines = File.ReadAllLines(sourcePath);
            //    foreach (string line in lines)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}