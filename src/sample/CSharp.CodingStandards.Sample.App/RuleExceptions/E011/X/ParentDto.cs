namespace CSharp.CodingStandards.Sample.App.RuleExceptions.E011.Dtos.X;

////#pragma warning disable CA1056 // URI-like properties should not be strings
public sealed class ParentDto
{
    public string Url { get; set; } = default!;
    public string ServerUrl { get; set; } = default!;
}
