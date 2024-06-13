using GenericExamples.Models;
using static GenericExamples.Helpers.Helper;
using static GenericExamples.Helpers.Extensions;

namespace GenericExamples;

internal class Program
{
    static void Main(string[] args)
    {
        Category c1 = Load(new Category());
        Product p1 = Load(new Product());
        Student s1 = Load(new Student());

        #region oncekiHali
        //Category category = new Category();
        //category.CategoryName = "Test";
        //category.Description = "Test";

        //Product product = new Product();
        //product.ProductName = "Test";
        //product.UnitPrice = 100;
        //product.UnitsInStock = 10;
        //product.CategoryId = 1;
        #endregion

        c1.WriteToConsole();
        p1.WriteToConsole();
        s1.WriteToConsole();
    }
}
