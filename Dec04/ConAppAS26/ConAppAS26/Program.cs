using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;

namespace Assignmet_Serialization
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee()
            {
                Id = 999,
                FirstName = "Chris",
                LastName = "Gayle",
                Salary = 150000.00
            };

            //Binary Serialization and Deserialization
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("employee.bin", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream("employee.bin",FileMode.Open, FileAccess.Read);

            Employee employee = (Employee)formatter.Deserialize(stream);
            Console.WriteLine("* Binary Deserialized Employee *");
            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.LastName);
            Console.WriteLine(employee.Salary);

            //XML Serialization and Deserialization
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextWriter writer = new StreamWriter("employee.Xml"))
            {
                serializer.Serialize(writer, obj);
            }

            using (TextReader reader = new StreamReader("employee.xml"))
            {
                Employee deserializedEmployee = (Employee)serializer.Deserialize(reader);
                Console.WriteLine("\n** XML Deserialized Employee **");
                Console.WriteLine($"Id:{deserializedEmployee.Id}, FirstName: {deserializedEmployee.FirstName}, LastName: {deserializedEmployee.LastName}, Salary: {deserializedEmployee.Salary}");
            }
            Console.ReadKey();
        }
    }
}