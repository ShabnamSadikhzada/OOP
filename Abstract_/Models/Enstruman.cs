namespace Abstract_.Models;

public enum Hammadde
{
    Agac,
    Metal,
    Plastik
}

public class Muzisyen
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public Enstruman Enstruman { get; set; }
}


public interface IEnstruman { }
public abstract class Enstruman : IEnstruman
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Aciklama { get; set; }
    public decimal Fiyat { get; set; }
    public string UretimYeri { get; set; }
    public Hammadde Hammadde { get; set; }
    public virtual string Ses(string name) => $"{name} Enstrumani Default Sound";
    public abstract string Sound();
}


public class Bateri : Enstruman
{
    public string DeriTipi { get; set; }
    
    public override string Sound() => "Tak Tak Tak";
}

public class Keman : Enstruman
{
    public string TelTipi { get; set; }
    public string Arse {  get; set; }

    public override string Sound()
    {
        throw new NotImplementedException();
    }
}

public class Gitar : Enstruman
{
    public bool Akustik { get; set; }
    public override string Sound()
    {
        throw new NotImplementedException();
    }
}

public class Piano : Enstruman
{
    public string TelTipi { get; set; }
    public string TusTakimi { get; set; }
    public override string Sound()
    {
        throw new NotImplementedException();
    }
}