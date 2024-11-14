## More partial members

You can declare `partial` properties and `partial` indexers in C# 13. Partial properties and indexers generally follow the same rules as `partial` methods: you create one _declaring declaration_ and one implementing declaration. The signatures of the two declarations must match. One restriction is that you can't use an auto-property declaration for a partial property. Properties that don't declare a body are considered the _declaring declaration_.

```csharp
public partial class C
{
    // Declaring declaration
    public partial string Name { get; set; }
}

public partial class C
{
    // implementation declaration:
    private string _name;
    public partial string Name
    {
        get => _name;
        set => _name = value;
    }
}
```

## See also

- [What's new in .NET 9 - More partial members (learn.microsoft)](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#more-partial-members)
- [Partial properties proposal (github)](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-13.0/partial-properties.md)
- [Partial member](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/partial-member)