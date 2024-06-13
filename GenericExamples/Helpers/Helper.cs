using GenericExamples.Models;
using System.Reflection;

namespace GenericExamples.Helpers;
public class Helper
{
    public static T Load<T>(T entity) 
        where T : IEntity, new()
    {
        foreach (PropertyInfo prop in entity.GetType().GetProperties())
        {
            if(prop.Name == "Id")
            {
                continue;
            }

            Console.WriteLine($"Ludfen {prop.Name} giriniz: ");
            string value = Console.ReadLine();

            #region yapmicakmisiz
            //if(prop.PropertyType == typeof(int))
            //{
            //    prop.SetValue(entity, int.Parse(value));
            //}
            //else if(prop.PropertyType == typeof(decimal))
            //{
            //    prop.SetValue(entity, decimal.Parse(value));
            //}
            //else if (prop.PropertyType == typeof(short))
            //{
            //    prop.SetValue(entity, short.Parse(value));
            //}
            //else if (prop.PropertyType == typeof(string))
            //{
            //    prop.SetValue(entity, value);
            //}
            #endregion

            try
            {
                object convertedValue = Convert.ChangeType(value, prop.PropertyType);
                prop.SetValue(entity, convertedValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"gecersiz deger girdiniz, Hata: {ex.Message}");
                return Load(entity);
            }
        }

        return entity;
    }
}


