using Interface_.Models;
using System.Collections;
using System.Reflection;

Kaleci kaleci = new Kaleci();
kaleci.Adi = "Tafarel";
kaleci.Soyadi = "Tefal";
kaleci.Takim = "Galatasaray";
kaleci.FormaNo = "1";
kaleci.Mevki = "Kaleci";
kaleci.Agresiflik = 10;
kaleci.SutGucu = 10;
kaleci.TopKontrolu = 10;
kaleci.Maas = 1000000;


Defans defans = new Defans()
{
    Adi = "Sabri",
    Soyadi = "Sarioglu",
    Takim = "Galatasaray",
    FormaNo = "55",
    Mevki = "Defans",
    Agresiflik = 100,
    SutGucu = 5,
    TopKontrolu = 5,
    Kondisyon = 5,
    Maas = 50
};

ArrayList futbolcular = new ArrayList();
futbolcular.Add(kaleci);
futbolcular.Add(defans);

foreach (var futbolcu in futbolcular)
{
    #region Ornek1
    if (futbolcu is Kaleci kapici)
    {
        PropertyInfo[] properties = (new Kaleci()).GetType().GetProperties();
        int propertyLength = properties
            .Select(p => p.Name)
            .OrderByDescending(name => name.Length)
            .FirstOrDefault().Length;

        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"{property.Name.PadRight(propertyLength + 5)} : {property.GetValue(kapici)}");
        }

        Console.WriteLine(new String('-', 50));

        //Console.WriteLine(kapici.Adi);
        //Console.WriteLine(kapici.Soyadi);
        //Console.WriteLine(kapici.Takim);
        //Console.WriteLine(new String('-', 50));
    }

    else if (futbolcu is Defans mudafieci)
    {
        PropertyInfo[] properties = (new Defans()).GetType().GetProperties();
        int propertyLength = properties
            .Select(p => p.Name)
            .OrderByDescending(name => name.Length)
            .FirstOrDefault().Length;

        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"{property.Name.PadRight(propertyLength + 5)} : {property.GetValue(mudafieci)}");
        }

        Console.WriteLine(new String('-', 50));

        //Console.WriteLine(mudafieci.Adi);
        //Console.WriteLine(mudafieci.Soyadi);
        //Console.WriteLine(mudafieci.Takim);
    }
    #endregion

    if(futbolcu is IFutbolcu futbolcu1)
    {
        Console.WriteLine(futbolcu1.Adi);
    }

    if(futbolcu.GetType().GetInterface("IFutbolcu")  != null)
    {
        IFutbolcu futbolcun = futbolcu as IFutbolcu;
        Console.WriteLine(futbolcun.Adi);
    }

    if (futbolcu.GetType().GetInterface("IFutbolcu") != null)
    {
        PropertyInfo[] properties = futbolcu
            .GetType()
            .GetProperties();

        int propertyLength = properties
            .Select(p => p.Name)
            .OrderByDescending(name => name.Length)
            .FirstOrDefault().Length;

        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"{property.Name.PadRight(propertyLength)} : {property.GetValue(futbolcu)}");
        }

        Console.WriteLine(new String('-', 50));
    }


}


