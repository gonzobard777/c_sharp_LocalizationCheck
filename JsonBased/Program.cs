using JsonBased.L10n;

namespace JsonBased;

public class Program
{
    public static void Main(string[] args)
    {
        Res.LoadLocalizations();
        Lang.Current = Lang.Ru;
        var res = string.Format(Res.Dict.WorkplaceType.NotFound, 1, "Hello");
        Console.WriteLine(res);
    }
}