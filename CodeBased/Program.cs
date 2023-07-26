using CodeBased.L10n;

namespace CodeBased;

public class Program
{
    public static void Main(string[] args)
    {
        Lang.Current = Lang.En;
        Console.WriteLine(Tr.WorkplaceType.NotFoundById(123));
    }
}