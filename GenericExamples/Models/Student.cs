namespace GenericExamples.Models;

public class Student : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}
