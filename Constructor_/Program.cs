using Constructor_.Models;

namespace Constructor_;

internal class Program
{
    static void Main(string[] args)
    {
        //Employee employee = new Employee("xcgfc");

        Employee employee = new Employee();

        employee.FirstName = "Test";
        employee.LastName = "Test";
        employee.Email = "Test";
        employee.Phone = "Test";

        Console.WriteLine(employee.FirstName);

    }
}
