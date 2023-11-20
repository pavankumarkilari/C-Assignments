using System;

namespace ConAppAS03
{
    internal class Program
    {
        static void Main()
        {
            // P-01
            // TryParse for converting string to int
            Console.Write("Enter an integer value: ");
            string inputInt = Console.ReadLine();

            if (int.TryParse(inputInt, out int resultInt))
            {
                Console.WriteLine($"Successfully converted to integer: {resultInt}");
            }
            else
            {
                Console.WriteLine("Invalid input. Unable to convert to integer.");
            }

            // Convert for converting string to double
            Console.Write("Enter a double value: ");
            string inputDouble = Console.ReadLine();

            double resultDouble;
            if (double.TryParse(inputDouble, out resultDouble))
            {
                Console.WriteLine($"Successfully converted to double: {resultDouble}");
            }
            else
            {
                Console.WriteLine("Invalid input. Unable to convert to double.");
            }

            // Parse for converting string to decimal
            Console.Write("Enter a decimal value: ");
            string inputDecimal = Console.ReadLine();

            decimal resultDecimal;
            if (decimal.TryParse(inputDecimal, out resultDecimal))
            {
                Console.WriteLine($"Successfully converted to decimal: {resultDecimal}");
            }
            else
            {
                Console.WriteLine("Invalid input. Unable to convert to decimal.");
            }

            // P-02
            // TryParse for converting string to int
            Console.Write("Enter an integer value: ");
            string inputInt1 = Console.ReadLine();

            if (int.TryParse(inputInt1, out int resultInt1))
            {
                Console.WriteLine($"Result after multiplying by 5: {resultInt1 * 5}");
            }
            else
            {
                Console.WriteLine("Invalid input. Unable to convert to integer.");
            }

            // Convert for converting string to DateTime
            Console.Write("Enter a DateTime value: ");
            string inputDateTime = Console.ReadLine();

            DateTime resultDateTime;
            bool isDateTimeConversionSuccessful = DateTime.TryParse(inputDateTime, out resultDateTime);

            if (isDateTimeConversionSuccessful)
            {
                resultDateTime = resultDateTime.AddMonths(-1);
                Console.WriteLine($"Result after subtracting 1 month: {resultDateTime}");
            }
            else
            {
                Console.WriteLine("Invalid input. Unable to convert to DateTime.");
            }

            // Parse for converting string to TimeSpan
            Console.Write("Enter a TimeSpan value: ");
            string inputTimeSpan = Console.ReadLine();

            TimeSpan resultTimeSpan;
            bool isTimeSpanConversionSuccessful = TimeSpan.TryParse(inputTimeSpan, out resultTimeSpan);

            if (isTimeSpanConversionSuccessful)
            {
                resultTimeSpan = resultTimeSpan.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine($"Result after adding 2 hours: {resultTimeSpan}");
            }
            else
            {
                Console.WriteLine("Invalid input. Unable to convert to TimeSpan.");
            }
        }
    }

}

