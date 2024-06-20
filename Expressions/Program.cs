// Expression Trees

using System.Linq.Expressions;
using Expressions.Models;

#region Ornek1
Expression<Func<int, int>> square = x => x * x;
var result = square.Compile();

//Console.WriteLine(result(5));
#endregion

#region Ornek2
Expression<Func<int, int, bool>> IsGreater = (n1, n2) => n1 > n2;
Func<int, int, bool> IsGreaterFunc = IsGreater.Compile();

//Console.WriteLine(IsGreaterFunc(3,5));
//Console.WriteLine(IsGreaterFunc(5,3));
#endregion

#region Ornek3
var employees = new List<Employee>
{
    new Employee { FirstName = "John",    LastName = "Doe",      Age = 25 },
    new Employee { FirstName = "Jane",    LastName = "Smith",    Age = 30 },
    new Employee { FirstName = "Michael", LastName = "Johnson",  Age = 45 },
    new Employee { FirstName = "Emily",   LastName = "Davis",    Age = 15 },
    new Employee { FirstName = "David",   LastName = "Brown",    Age = 35 },
    new Employee { FirstName = "Sarah",   LastName = "Wilson",   Age = 28 },
    new Employee { FirstName = "Robert",  LastName = "Taylor",   Age = 50 },
    new Employee { FirstName = "Linda",   LastName = "Anderson", Age = 14 },
    new Employee { FirstName = "James",   LastName = "Thomas",   Age = 33 }
};

Expression<Func<Employee, bool>> isAdultExpression = e => e.Age > 17;

if(isAdultExpression.Body is BinaryExpression )
{
    //var binaryExpression = (BinaryExpression)isAdultExpression.Body;
}

if (isAdultExpression.Body is BinaryExpression binaryExpression)
{
    //Console.WriteLine(binaryExpression);
    //Console.WriteLine(binaryExpression.Left);
    //Console.WriteLine(binaryExpression.Right);
    //Console.WriteLine(binaryExpression.NodeType);
}

var adultEmployees = employees.Where(x => isAdultExpression.Compile()(x));

foreach(Employee employee in adultEmployees)
{
    //Console.WriteLine(employee);
}
#endregion


List<string> strings = new()
    { "f_mdk", "@3ifjijv", "DIKSN@fkd" };

Expression<Func<string, string>> expression = s => s.ToLower().Replace("@", "").Replace("_", "");

//var newStrings = strings.Where( toLowerExpression.Compile()(x));

var retVal = strings.AsQueryable().Select(expression).ToList();

foreach(var item in retVal)
{
    Console.WriteLine(item);
}