using System;
using System.IO;

namespace ConAppAS12
{
    public class FileManipulation
    {
        public void CreateFile()
        {
            string path = "C:\\Users\\kpava\\source\\repos\\ConAppAS12\\";
            Console.WriteLine("Enter the file name:");
            string fileName = Console.ReadLine();
            Console.WriteLine("Enter the content that you want to written in the file: ");
            string content = Console.ReadLine();
            string filePath = path + fileName;
            if (!File.Exists(filePath))
            {
                StreamWriter streamWriter = new StreamWriter(filePath);
                streamWriter.WriteLine(content);
                streamWriter.Dispose();
                streamWriter.Close();
            }
            else
            {
                Console.WriteLine("File already exists!");
            }
        }

        public void ReadFile()
        {
            string path = "C:\\Users\\kpava\\source\\repos\\ConAppAS12\\";
            Console.WriteLine("Enter the file name:");
            string fileName = Console.ReadLine();
            string filePath = path + fileName;
            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists and the content is:");
                StreamReader streamReader = new StreamReader(filePath);
                string text = streamReader.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("File does not exists!");
            }
        }

        public void AppendToFile()
        {
            string path = "C:\\Users\\kpava\\source\\repos\\ConAppAS12\\";
            Console.WriteLine("Enter the file name:");
            string fileName = Console.ReadLine();
            string filePath = path + fileName;
            if (File.Exists(filePath))
            {
                Console.WriteLine("Enter the content that you want to append to the file: ");
                string content = Console.ReadLine();
                StreamWriter streamWriter = File.AppendText(filePath);
                streamWriter.WriteLine(content);
                streamWriter.Dispose();
                streamWriter.Close();
            }
            else
            {
                Console.WriteLine("File does not exists!");
            }
        }
        public void DeleteFile()
        {
            string path = "C:\\Users\\kpava\\source\\repos\\ConAppAS12\\";
            Console.WriteLine("Enter the file name:");
            string fileName = Console.ReadLine();
            string filePath = path + fileName;
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("File deleted successfully!");
            }
            else
            {
                Console.WriteLine("File does not exists!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose one of the methods of file: \n 1. Create a file, \n 2. Read a file, \n 3. Append to a file, \n 4. Delete a file.");
            int choice = Convert.ToInt32(Console.ReadLine());
            FileManipulation fileManipulation = new FileManipulation();
            switch (choice)
            {
                case 1:
                    fileManipulation.CreateFile();
                    break;
                case 2:
                    fileManipulation.ReadFile();
                    break;
                case 3:
                    fileManipulation.AppendToFile();
                    break;
                case 4:
                    fileManipulation.DeleteFile();
                    break;
                default:
                    Console.WriteLine("Invalid option!!! Choose a vaild option.");
                    break;
            }

        }
    }
}

