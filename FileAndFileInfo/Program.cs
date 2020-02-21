using System;
using System.IO;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            //string sourcePath = "c:\\temp\\file1.txt"; sem o arroba, seria necessário as duas barras invertidas
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines){
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
