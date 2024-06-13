namespace Static_.Models;

public class FizikKutuphanesi
{
    public const double Pi = 3.14;
    public string ConnectionString = "server";
    public readonly string ReadOnlyConnection = "readonly";
    public static readonly string ConnectionStringReadOnly = "readonly";

    public static string Domain {  get; set; }
    public static readonly string Extension = "edu.az";
}

