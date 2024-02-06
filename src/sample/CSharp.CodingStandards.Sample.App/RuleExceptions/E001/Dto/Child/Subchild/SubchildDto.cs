namespace CSharp.CodingStandards.Sample.App.RuleExceptions.E001.Dto;

////#pragma warning disable CA1002 // Do not expose generic lists
////#pragma warning disable CA2227 // Collection properties should be read only
public sealed class SubchildDto
{
    public List<object> Items { get; set; } = [];
}
