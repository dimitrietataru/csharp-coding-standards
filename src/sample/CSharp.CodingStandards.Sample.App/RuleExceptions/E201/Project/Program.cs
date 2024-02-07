namespace CSharp.CodingStandards.Sample.App.RuleExceptions.E201.Project;

#pragma warning disable CS7022 // The entry point of the program is global code; ignoring 'Program.Main(object[])' entry point.
internal static class Program
{
    public static void Main(object[] _)
    {
#pragma warning disable CA1303 // Do not pass literals as localized parameters
        Console.WriteLine("Hello world!");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
    }
}
