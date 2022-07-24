namespace CSharp.CodingStandards.Sample.App.RuleExceptions.E012.Models;

////#pragma warning disable CA1056 // URI-like properties should not be strings
public sealed class Child
{
    public string Url { get; set; } = default!;
    public string ServerUrl { get; set; } = default!;
}
