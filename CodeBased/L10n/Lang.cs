namespace CodeBased.L10n;

public class Lang
{
    public static string Ru => "ru";
    public static string En => "en";

    public static readonly string Default = Ru;
    public static readonly string[] Supported = { Ru, En };

    public static string Current = Default;
}