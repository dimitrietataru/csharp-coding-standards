namespace CSharp.CodingStandards.Sample.App.RuleExceptions.E003.Entities;

////#pragma warning disable CA1002 // Do not expose generic lists
////#pragma warning disable CA1819 // Properties should not return arrays
////#pragma warning disable CA2227 // Collection properties should be read only
public class SubchildEntity
{
    public List<object> Items { get; set; } = [];
    public object[] Objects { get; set; } = [];
}
