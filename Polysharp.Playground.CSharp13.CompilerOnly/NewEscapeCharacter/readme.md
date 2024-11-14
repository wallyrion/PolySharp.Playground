
## New escape sequence
You can use `\e` as a [character literal](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/lexical-structure#6455-character-literals) escape sequence for the `ESCAPE` character, Unicode `U+001B`. Previously, you used `\u001b` or `\x1b`. Using `\x1b` wasn't recommended because if the next characters following `1b` were valid hexadecimal digits, those characters became part of the escape sequence.


With the implementation of this proposal, the following assertions should be true:


```csharp
char escape_char = '\e';

Assert.IsTrue(escape_char == (char)0x1b, "...");
Assert.IsTrue(escape_char == '\u001b', "...");
Assert.IsTrue(escape_char == '\U0000001b', "...");
Assert.IsTrue(escape_char == '\x1b', "...");
```

## See also

- [What's new in .NET 9 - New escape sequence (learn.microsoft)](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-13.0/esc-escape-sequence.md)
- [String/Character escape sequence proposal (github)](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-13.0/esc-escape-sequence.md)