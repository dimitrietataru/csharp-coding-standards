namespace CSharp.CodingStandards.Sample.App.RuleExceptions.E301.Reflection;

////#pragma warning disable IDE0051 // Remove unused private members
public static class FakeDto
{
    public static T Get<T>()
        where T : class
    {
        string propertyName = $"Fake{typeof(T).Name}";

        return typeof(FakeDto)
            .GetProperty(propertyName)
            ?.GetValue(null) as T
            ?? throw new NotImplementedException(propertyName);
    }

    private static XyzDto FakeXyzDto => new(string.Empty);
}
