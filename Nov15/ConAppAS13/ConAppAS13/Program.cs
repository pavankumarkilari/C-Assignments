using System;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace ConAppAS13
{
    public class Validation
    {
        public void Words(string text)
        {
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Words count = {words.Length}");
        }
        public void EmailAddress(string text)
        {
            //string[] words = Regex.Split(text, @"\s+");
            string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(EmailPattern);
            //foreach (string word in words)
            //{
            //    if (regex.IsMatch(word))
            //    {
            //        Console.WriteLine($"{word} is a valid email.");
            //    }
            //}

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine($"{match.Value} is a valid email.");
            }
        }
        public void MobileNumber(string text)
        {
            //string[] words = Regex.Split(text, @"\s+");
            string MobilePattern = @"\b\d{10}\b";
            Regex regex = new Regex(MobilePattern);
            //foreach (string word in words)
            //{
            //    if (regex.IsMatch(word))
            //    {
            //        Console.WriteLine($"{word} is a valid mobile number.");
            //    }
            //}

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine($"{match.Value} is a valid mobile number.");
            }

        }
        public void CustomSearch(string text)
        {
            try
            {
                // string[] words = Regex.Split(text, @"\s+");
                Console.WriteLine("Enter your custom regular expression: ");
                string CustomRegex = Console.ReadLine();
                Regex regex = new Regex(CustomRegex);
                Console.WriteLine("Result for your search");
                //foreach (string word in words)
                //{
                //    if (regex.IsMatch(word))
                //    {
                //        Console.WriteLine($"{word}");
                //    }
                //}
                MatchCollection matches = regex.Matches(text);

                Console.WriteLine("Result for your search");
                foreach (Match match in matches)
                {
                    Console.WriteLine($"{match.Value}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
            finally { Console.WriteLine("Finished!!!"); }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a piece of text: ");
            string Text = Console.ReadLine();
            Validation validation = new Validation();
            validation.Words(Text);
            validation.EmailAddress(Text);
            validation.MobileNumber(Text);
        }
    }
}
