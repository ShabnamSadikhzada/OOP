using Static_.Models;

namespace Static_;

internal class Program
{
    static void Main(string[] args)
    {
        FizikKutuphanesi fizikKutuphanesi = new FizikKutuphanesi();
        double sonuc = FizikKutuphanesi.Pi;

        fizikKutuphanesi.ConnectionString = "server=";
        string con = fizikKutuphanesi.ConnectionString;

        //fizikKutuphanesi.ReadOnlyConnection = "readonly";
        string con1 = fizikKutuphanesi.ReadOnlyConnection;
        string con2 = FizikKutuphanesi.ConnectionStringReadOnly;

        FizikKutuphanesi.Domain = "www.domain" + FizikKutuphanesi.Extension;
    }
}
