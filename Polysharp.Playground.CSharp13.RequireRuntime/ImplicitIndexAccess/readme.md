## Implicit index access


The implicit "from the end" index operator, `^`, is now allowed in an object initializer expression. For example, you can now initialize an array in an object initializer as shown in the following code:

```csharp
var countdown = new TimerRemaining()
{
    buffer =
    {
        [^1] = 0,
        [^2] = 1,
        [^3] = 2,
        [^4] = 3,
        [^5] = 4,
        [^6] = 5,
        [^7] = 6,
        [^8] = 7,
        [^9] = 8,
        [^10] = 9
    }
};
```



- [What's new in .NET 9 - Implicit index access (learn.microsoft)](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#implicit-index-access)
- [Lock object proposal (github)](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-13.0/lock-object.md)