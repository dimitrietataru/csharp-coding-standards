﻿namespace CSharp.CodingStandards.Sample.App.RuleExceptions.E501.SampleTests;

////#pragma warning disable IDE1006 // Naming Styles - Async Method should end in Async
public static class RandomName
{
    ////[Fact]

    internal static async Task GivenWhenThen()
    {
        // Arrange

        // Act
        await Task.Delay(1000).ConfigureAwait(false);

        // Assert
    }
}
