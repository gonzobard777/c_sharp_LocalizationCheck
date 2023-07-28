using System.Globalization;
using ResBased.L10n;

namespace ResBased;

public class Program
{
    public static void Main(string[] args)
    {
        var culture = new CultureInfo("en");
        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;

        Console.WriteLine(CommonResource.InvalidRequest);
    }
}