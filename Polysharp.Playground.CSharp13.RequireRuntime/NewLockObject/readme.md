The .NET 9 runtime includes a new type for thread synchronization, the System.Threading.Lock type. This type provides better thread synchronization through its API. The Lock.EnterScope() method enters an exclusive scope. The ref struct returned from that supports the Dispose() pattern to exit the exclusive scope.

The C# lock statement recognizes if the target of the lock is a Lock object. If so, it uses the updated API, rather than the traditional API using System.Threading.Monitor. The compiler also recognizes if you convert a Lock object to another type and the Monitor based code would be generated. You can read more in the feature specification for the new lock object.

This feature allows you to get the benefits of the new library type by changing the type of object you lock. No other code needs to change.


```csharp
private readonly Lock _lock = new();
public int Count { get; private set; }

public void DoConcurrentOperationWithScope()
{
    using var scope = _lock.EnterScope();

    Count++;
} 
```



- [What's new in .NET 9 - lock object (learn.microsoft)](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#new-lock-object)
- [Lock object proposal (github)](https://github.com/dotnet/csharplang/blob/main/proposals/csharp-13.0/lock-object.md)