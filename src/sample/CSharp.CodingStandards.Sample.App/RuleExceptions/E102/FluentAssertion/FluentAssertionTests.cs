using FluentAssertions;

namespace CSharp.CodingStandards.Sample.App.RuleExceptions.E102.FluentAssertion;

public static class FluentAssertionTests
{
    private const string GivenValue = "123";
    private const int ExpectedLength = 3;

    ////[Fact]
    internal static void GivenWhenThen()
    {
        // Arrange
        string value;

        // Act
        value = GivenValue;

        // Assert
////#pragma warning disable IDE0058 // Expression value is never used
        value.Should().NotBeNullOrEmpty();
////#pragma warning restore IDE0058 // Expression value is never used

        _ = value.Should().HaveLength(ExpectedLength);
    }
}
