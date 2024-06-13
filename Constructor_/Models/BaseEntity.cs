using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Constructor_.Models;

public static class Helper
{
    public static string GetComputerName()
    {
        return Environment.MachineName;
    }

    public static string GetIp()
    {
        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in host.AddressList)
        {
            if(ip.AddressFamily == AddressFamily.InterNetwork)
            {
                return ip.ToString(); 
            }
        }

        throw new Exception("No network blabla");
    }
    
}

public class BaseEntity
{
    public BaseEntity(int currentUserId)
    {
        Id = currentUserId; 
    }

    public BaseEntity()
    {
        this.CreatedDate = DateTime.UtcNow;
        this.CreatedComputerName = Helper.GetComputerName();
        this.CreatedIp = Helper.GetIp();
    }

    public int Id { get; set; }
    public string CreatedIp { get; set; } = null!;
    public string CreatedComputerName { get; set; } = null!;
    public DateTime CreatedDate { get; set; }

    private string? _updatedIp; 
    public string? UpdatedIp 
    { 
        get => _updatedIp;
        set
        {
            _updatedIp = value; 
            if (value != null)
            {
                this.UpdatedDate = DateTime.UtcNow;
            }
        }
    }

    public DateTime? UpdatedDate { get; set; }
    public bool IsDeleted { get; set; }
}

public class Employee : BaseEntity
{
    public Employee() : base(1) { }
    public Employee(string firstName)
    {
        this.FirstName = firstName;
    }
    public Employee(string firstName, string lastName) : this(firstName)
    {
        //this.FirstName = firstName;
        this.LastName = lastName;
    }
    public Employee(string firstName, string lastName, string email) : this(firstName, lastName)
    {
        //this.FirstName = firstName;
        //this.LastName = lastName;
        this.Email = email;
    }
    public Employee(string firstName, string lastName, string email, string phone) : this (firstName, lastName, email)
    {
        //this.FirstName = firstName;
        //this.LastName = lastName;
        //this.Email = email;
        this.Phone = phone;
    }


    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; }
    public string Phone { get; set; }
}
