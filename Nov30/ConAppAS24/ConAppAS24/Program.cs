using System;
using System.Reflection;

class Source
{
    public int PatientId { get; set; }
    public string PatientName { get; set; }
    public string SufferingFrom { get; set; }
}
class Destination
{
    public int PatientId { get; set; }
    public string PatientName { get; set; }
    public string Medication { get; set; }
}

public class Program
{
    static void MapProperties(Source source, Destination destination)
    {
        PropertyInfo[] sourceProperties = typeof(Source).GetProperties();
        PropertyInfo[] destinationProperties =  typeof(Destination).GetProperties();

        foreach (PropertyInfo sourceProperty in sourceProperties)
        {
            foreach (PropertyInfo destinationProperty in destinationProperties)
            {
                if(sourceProperty.Name == destinationProperty.Name)
                {
                    destinationProperty.SetValue(destination, sourceProperty.GetValue(source));
                    break;
                }
            }
        }
    }
    static void Main(string[] args)
    {
        Source source = new Source { PatientId = 104, PatientName = "Pandya", SufferingFrom = "Leg Injury"};
        Destination destination = new Destination { Medication = "Take described medicine and take rest"};

        MapProperties(source, destination);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Hello, {destination.PatientName}.");
        Console.ForegroundColor= ConsoleColor.White;
        Console.Write("Your patient id is: ");
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.Write($"{destination.PatientId}.\n");
        Console.ForegroundColor= ConsoleColor.White;
        Console.Write("Your medication is: ");
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.Write($"{destination.Medication}.");
        Console.ReadKey();
    }
}

