
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.WriteLine(folderPath);
            string fileName = "example.txt";
            string filePath = Path.Combine(folderPath, fileName);
            Console.WriteLine(filePath);

            File.Create(filePath).Close();
            File.WriteAllText(filePath, "HI MY FRIEND XDXDXD" + Environment.NewLine);
            File.AppendAllText(filePath, "       DOMA OTKRITO????");
            File.WriteAllText(filePath, "WHY YOU DELETE ALL TEXT???");

            string[] words = new string[] { "aaa", "dsds", "asasrefi" };
            File.WriteAllLines(filePath, words);
            File.AppendAllLines(filePath, words);
            File.AppendAllText(filePath, "KAVABANGA");

            string convert = File.ReadAllText(filePath);
            string[] convert1 = File.ReadAllLines(filePath);

            Console.WriteLine(convert);
            foreach (string x in convert1)
            {
                Console.Write(x + " ");
            }


            string folderPath2 = Path.Combine(filePath, "ExampleFolder");
            string filePath1 = Path.Combine(folderPath2, "EnotherExmple.txt");
            if (Directory.Exists(filePath1))
            {
                Directory.Delete(filePath1);
            }
            if (File.Exists(filePath1))
            {
                File.Delete(filePath1);
            }
            Directory.CreateDirectory(filePath1);   
            File.Create(filePath1).Close();
            string ext = "txt";


            string folderPath12 = Path.GetDirectoryName(filePath1);
            string fileName2 = Path.GetFileName(filePath1);

        }
    }
}
