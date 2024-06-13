namespace News.Models;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}
public record Personel
{
    public required string FirstName { get; set; }
    public string LastName { get; set; }
}

public record Employee(string FirstName, string LastName, string Email, string Phone, Personel Personel);


public class Category
{
    //public Category()
    //{
    //    //this.Name = "Beverages";
    //    this.Description = "Bu bir kategoridir";
    //}
    //public int Id { get; set; }
    //public required string Name { get; set; }
    //public string Description { get; init; } = "default description";
    //public string ImageUrl { get; set; }

    public Category() { }
    public Category(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public void Update(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }
}