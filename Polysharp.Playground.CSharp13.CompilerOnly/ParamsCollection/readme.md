## `params` collections

The `params` modifier isn't limited to array types. You can now use `params` with any recognized collection type, including Span<T>, ReadOnlySpan<T>, and types that implement System.Collections.Generic.IEnumerable<T> and have an Add method. In addition to concrete types, the interfaces System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.ICollection<T>, and System.Collections.Generic.IList<T> can also be used.

When an interface type is used, the compiler synthesizes the storage for the arguments supplied. You can learn more in the feature specification for [`params` collections](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-13.0/params-collections.md).

For example, method declarations can declare spans as `params` parameters:

```csharp
public void Concat<T>(params ReadOnlySpan<T> items)
{
    for (int i = 0; i < items.Length; i++)
    {
        Console.Write(items[i]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
```

## See also

- [What's new in .NET 9 - Params collection (learn.microsoft)](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#params-collections)
- [Params collection proposal (github)](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-13.0/params-collections.md)