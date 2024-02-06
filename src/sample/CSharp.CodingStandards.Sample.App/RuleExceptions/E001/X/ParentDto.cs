namespace CSharp.CodingStandards.Sample.App.RuleExceptions.E001.X;

////#pragma warning disable CA1002 // Do not expose generic lists
////#pragma warning disable CA2227 // Collection properties should be read only
public sealed class ParentDto
{
    public List<object> Items { get; set; } = [];
}
