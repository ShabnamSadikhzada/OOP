using GenericExamples.Models;
using System.Reflection;

namespace GenericExamples.Helpers;

public static class Extensions
{
    public static void WriteToConsole(this IEntity ent)
    {
        if (ent.GetType() != null)
        {
            PropertyInfo[] properties = (ent)
                .GetType()
                .GetProperties();

            int propertyLength = properties
                .Select(p => p.Name)
                .OrderByDescending(name => name.Length)
                .FirstOrDefault().Length;

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"{property.Name.PadRight(propertyLength)} : {property.GetValue(ent)}");
            }

            Console.WriteLine(new String('-', 50));
        }
    }
}
