namespace CSharp.CodingStandards.Sample.App.RuleExceptions.E201.Project;

internal static class Program
{
    public static void Main(object[] _)
    {
#pragma warning disable CA1303 // Do not pass literals as localized parameters
        Console.WriteLine("Hello world!");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
    }
}
