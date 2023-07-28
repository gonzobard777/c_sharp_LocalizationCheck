using System.Globalization;

namespace ResBased;

public class Program
{
    public static void Main(string[] args)
    {
        var culture = new CultureInfo("es");
        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;
        
            //Console.WriteLine(CommonResource.InvalidRequest);
    }
}