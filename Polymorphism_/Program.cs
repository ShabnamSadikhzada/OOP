﻿using Polymorphism_.Models;

namespace Polymorphism_;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        BasePhone basePhone = new BasePhone();
        Console.WriteLine(basePhone.Sound());

        MobilePhone mobilePhone = new MobilePhone();
        Console.WriteLine(mobilePhone.Sound());

        SmartPhone smartPhone = new SmartPhone();
        Console.WriteLine(smartPhone.Sound());

        smartPhone.Brand = "Samsung";
        smartPhone.OS = "Android";
        smartPhone.ConnectionType = "4G";

        Console.WriteLine(smartPhone);
    }
}
