using FluentAssertions;
using Xunit;

namespace Polysharp.Playground.CSharp13.CompilerOnly.NewEscapeCharacter;

public class EscapeCharacterTests
{
    [Fact]
    public void EscapeCharacter_ShouldBeEquivalentToHexCodePoint()
    {
        // Arrange
        char escapeChar = '\e';
        char expectedChar = (char)0x1b;

        // Assert
        escapeChar.Should().Be(expectedChar, 
            "the '\\e' escape sequence should represent the ESCAPE character with the hex code point 0x1b.");
    }

    [Fact]
    public void EscapeCharacter_ShouldBeEquivalentToUnicodeEscapeLowercase()
    {
        // Arrange
        char escapeChar = '\e';
        char expectedChar = '\u001b';

        // Assert
        escapeChar.Should().Be(expectedChar, 
            @"the '\e' escape sequence should be equivalent to the Unicode escape sequence '\u001b'.");
    }

    [Fact]
    public void EscapeCharacter_ShouldBeEquivalentToUnicodeEscapeUppercase()
    {
        // Arrange
        char escapeChar = '\e';
        char expectedChar = '\U0000001b';

        // Assert
        escapeChar.Should().Be(expectedChar, 
            @"the '\e' escape sequence should be equivalent to the Unicode escape sequence '\U0000001b'.");
    }

    [Fact]
    public void EscapeCharacter_ShouldBeEquivalentToHexEscapeSequence()
    {
        // Arrange
        char escapeChar = '\e';
        char expectedChar = '\x1b';

        // Assert
        escapeChar.Should().Be(expectedChar, 
            @"the '\e' escape sequence should be equivalent to the hex escape sequence '\x1b'.");
    }
}