namespace CodeBased.L10n;

public partial class Tr
{
    public static class WorkplaceType
    {
        public static string NotFound => GetStr(
            NotFound("Тип рабочего места"),
            NotFound("Workplace type")
        );

        public static string NotFoundById(int id) => GetStr(
            NotFound($"Тип рабочего места id={id}"),
            NotFound($"Workplace type id={id}")
        );

        public static string CannotBeDeleted(int workplaceCount) => GetStr(
            $"Нельзя удалить. Используется в ({workplaceCount}) рабочих мест",
            $"Cannot be deleted. Used in ({workplaceCount}) workplaces"
        );
    }
}