namespace CodeBased.L10n;

public partial class Tr
{
    public static string GetStr(string ruStr, string enStr) =>
        Lang.Current == Lang.En ? enStr : ruStr;

    public static string NotFound(string title) => GetStr(
        $"{title} отсутствует", // не найдено
        $"{title} not found"
    );

    public static string InvalidRequest => GetStr(
        "Некорректный запрос",
        "Invalid request"
    );
}