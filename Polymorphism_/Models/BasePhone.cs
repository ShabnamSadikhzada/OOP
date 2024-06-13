namespace Polymorphism_.Models;

public class BasePhone
{
    public string Brand { get; set; }
    public string ConnectionType { get; set; }
    public virtual string Sound() => "default phone sound";
}

public class MobilePhone : BasePhone
{
    public string OS { get; set; }
    //public string Sound() => "mobile phone sound";
    public override string Sound()
    {
        return "mobile phone sound";
    }
}

public class SmartPhone : MobilePhone
{
    //public string Sound() => "smart phone sound";
    public override string Sound()
    {
        return "smart phone sound";
    }

    public override string ToString()
    {
        return $"{this.Brand}\n{this.OS}\n{this.ConnectionType}";
    }
}
