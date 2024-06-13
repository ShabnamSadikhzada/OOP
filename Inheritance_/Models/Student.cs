namespace Inheritance_.Models;


public class BaseAuditEntity
{
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}

public class BaseEmployee {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
}
public class Student : BaseEmployee
{
    public string StudentNo { get; set; }
}

public class Teacher : BaseEmployee
{
    public string Department { get; set; }
    public string Salary { get; set; }
}