using Abstract_.Models;
using System.Collections;
using System.Reflection;

namespace Abstract_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bateri bateri = new Bateri
            {
                Marka = "DW",
                Model = "Performance Series",
                Aciklama = "DW Performance Series Drum Set",
                Fiyat = 3000,
                UretimYeri = "USA",
                Hammadde = Hammadde.Metal,
                DeriTipi = "Cowhide"
            };

            Keman keman = new Keman
            {
                Marka = "Stradivarius",
                Model = "1715",
                Aciklama = "Stradivarius Violin",
                Fiyat = 1600000,
                UretimYeri = "Italy",
                Hammadde = Hammadde.Agac,
                TelTipi = "Gut",
                Arse = "Tourte Bow"
            };

            Gitar gitar = new Gitar
            {
                Marka = "Fender",
                Model = "Stratocaster",
                Aciklama = "Fender Stratocaster Electric Guitar",
                Fiyat = 1200,
                UretimYeri = "USA",
                Hammadde = Hammadde.Agac,
                Akustik = false
            };

            Piano piano = new Piano
            {
                Marka = "Steinway & Sons",
                Model = "Model D",
                Aciklama = "Steinway & Sons Model D Concert Grand Piano",
                Fiyat = 170000,
                UretimYeri = "Germany",
                Hammadde = Hammadde.Agac,
                TelTipi = "Steel",
                TusTakimi = "88 Keys"
            };


            Muzisyen baterist = new() { Adi = "John", Soyadi = "Bonham", Enstruman = bateri };
            Muzisyen gitarist = new() { Adi = "Niccolo", Soyadi = "Paganini", Enstruman = gitar };
            Muzisyen kemanist = new() { Adi = "Jimi", Soyadi = "Hendrix", Enstruman = keman };
            Muzisyen piyanist = new() { Adi = "Ludwig", Soyadi = "van Beethoven", Enstruman = piano };


            ArrayList muzisyenler = new ArrayList();
            muzisyenler.Add(baterist);
            muzisyenler.Add(kemanist);
            muzisyenler.Add(gitarist);
            muzisyenler.Add(piyanist);

            foreach (var muzisyen in muzisyenler)
            {
                PropertyInfo[] properties = muzisyen.GetType().GetProperties();
                //int propLen = properties.Select(p => p.Name).OrderByDescending(name => name.Length).FirstOrDefault().Length;

                Console.WriteLine("Muzisyen" + new String('_', 15));
                foreach (var property in properties)
                {
                    if(property.Name == "Enstruman")
                    {
                        Console.WriteLine("\nEnstruman" + new String('_', 15));

                        var enstruman = property.GetValue(muzisyen);
                        PropertyInfo[] propertiesE = enstruman.GetType().GetProperties();
                        //int propLenE = propertiesE.Select(p => p.Name).OrderByDescending(name => name.Length).FirstOrDefault().Length;

                        foreach (var propertyE in propertiesE)
                        {
                            Console.WriteLine($"    {propertyE.Name.PadRight(15)} : {propertyE.GetValue(enstruman)}");
                        }
                        string[] functionNames = { "Sound", "Ses" };

                        var funcs = enstruman.GetType().GetMethods().
                            Where(m => functionNames.Contains(m.Name));

                        foreach (var func in funcs)
                        {
                            string funcResult = default;

                            if(func.GetParameters().Length > 0)
                            {
                                funcResult = $"{func.Invoke(enstruman, new[] { enstruman.GetType().Name })})";
                            }
                            else
                            {
                                funcResult = $"{func.Invoke(enstruman, null)}";
                            }
                            Console.WriteLine($"    {func.Name.PadRight(15)} : {funcResult}");
                        }
                    }

                    else
                    {
                        Console.WriteLine($"    {property.Name.PadRight(15)} : {property.GetValue(muzisyen)}");
                    }
                }
                Console.WriteLine(new String('-', 50));
            }

        }
    }
}
