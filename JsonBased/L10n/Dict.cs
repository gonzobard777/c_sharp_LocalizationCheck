using Newtonsoft.Json;

namespace JsonBased.L10n;

[JsonObject(
    ItemRequired = Required.Always // exception, если в классе поле есть, а в JSON-файле нет
)]
public class Dict
{
    public string NotFound;
    public string InvalidRequest;

    public WorkplaceType WorkplaceType;
}

public class WorkplaceType
{
    public string NotFound;
}