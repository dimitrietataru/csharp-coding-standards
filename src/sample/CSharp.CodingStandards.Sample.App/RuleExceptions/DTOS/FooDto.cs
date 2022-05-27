namespace CSharp.CodingStandards.Sample.App.RuleExceptions.DTOS;

////#pragma warning disable CA1002 // Do not expose generic lists
////#pragma warning disable CA2227 // Collection properties should be read only
public class FooDto
{
    public List<object> Items { get; set; } = new List<object>();
}
