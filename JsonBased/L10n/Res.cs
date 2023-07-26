using Newtonsoft.Json;

namespace JsonBased.L10n;

public class Res
{
    public static Dict Dict => Localizations[Lang.Current];
    public static Dictionary<string, Dict> Localizations { get; set; }

    public static void LoadLocalizations()
    {
        var settings = new JsonSerializerSettings
        {
            MissingMemberHandling = MissingMemberHandling.Error // exception, если в JSON-файле поле есть, а в классе нет
        };
        Localizations = new Dictionary<string, Dict>();
        string dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "L10n/Localizations");
        foreach (var file in new DirectoryInfo(dirPath).GetFiles("*.json"))
        {
            var lang = Path.GetFileNameWithoutExtension(file.Name);
            if (!Lang.Supported.Contains(lang))
                throw new Exception($"Localization file name '{lang}' consists of unsupported culture. Correct file names: {string.Join(", ", Lang.Supported)}.");

            Dict dict;
            try
            {
                dict = JsonConvert.DeserializeObject<Dict>(File.ReadAllText(file.FullName), settings)!;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error loading localization file '{file.Name}': {file.FullName}");
                Console.WriteLine($"{e.Message} ");
                Console.WriteLine($"{e.InnerException?.Message}");
                throw;
            }

            Localizations.Add(lang, dict);
        }
    }
}