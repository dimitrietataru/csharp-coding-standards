namespace CSharp.CodingStandards.Sample.App.RuleExceptions.E013.Entities;

////#pragma warning disable CA1056 // URI-like properties should not be strings
internal sealed class Child
{
    public string Url { get; set; } = default!;
    public string ServerUrl { get; set; } = default!;
}
