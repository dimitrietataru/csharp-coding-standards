namespace CSharp.CodingStandards.Sample.App.RuleExceptions.Models;

////#pragma warning disable CA1819 // Properties should not return arrays
public class FooModel
{
    public List<object> Navigations { get; set; } = new List<object>();
    public byte[] RowVersion { get; set; } = Array.Empty<byte>();
}
