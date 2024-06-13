using News.Models;

namespace News;

internal class Program
{
    static void Main(string[] args)
    {
        #region student ornek
        //var st1 = new Student();
        //st1.FirstName = "Mehmet";

        //Student st2 = st1;
        //st2.FirstName = "Ali";

        //Console.WriteLine(st1.FirstName);
        //Console.WriteLine(st2.FirstName);

        #endregion

        #region employee ornek
        //var emp1 = new Employee("Ahmet", "Yilmaz", "ahmet@ahmet.com", "123", null);
        //var emp2 = new Employee("Ahmet", "Yilmaz", "ahmet@ahmet.com", "123", null);

        //if (emp1 == emp2)
        //{
        //    Console.WriteLine("esit");
        //}
        //else
        //{
        //    Console.WriteLine("esit degil");
        //}

        //Console.WriteLine(emp1);
        //Console.WriteLine(emp2);

        //Employee emp3 = emp1;
        //emp3.FirstName = "abuzer";

        //Employee emp3 = emp1 with { FirstName = "Abuzer" };
        //Console.WriteLine(emp3);
        #endregion

        #region personel ornek
        //Personel p = new() 
        //{ 
        //    FirstName = "Abuzer" 
        //};
        //p.FirstName = "Mehmet";
        //p.LastName = "sahin";
        //Console.WriteLine(p);

        #endregion

        //Category c = new()
        //{
        //    Name = "",
        //    //Description = "Aciklama"
        //};

        //c.Description = "Aciklama";

        Category updated = new();
        updated.Update("","");

        Category newC = new("","");
    }
}
