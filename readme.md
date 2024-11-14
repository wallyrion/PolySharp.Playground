# C# Features

### TL;DR
This repo highlights modern C# features compatible with .NET Framework projects for developers staying on .NET Framework.


### Features list
This table lists the features introduced in C# versions 8 - 13 and indicates whether they are **_available out of the
box_**, **_require additional polyfills_**, or **_require a runtime_**.
- **Out of the Box**. You can just set version of the c# manually in csproj for the feature. sdk's (msbuild) version upgrade is required.
- **Require Additional polyfills**. Polyfills are needed, which can be easily added using the **[PolySharp](https://github.com/Sergio0694/PolySharp) library;**
- **Require Runtime**.  This feature is integrated within both the Roslyn compiler and the runtime itself.


>⚠️ SDK-style .csproj is required for the PolySharp to generate required polyfills. It can be upgraded quite easily using **[Upgrade Assistant](https://learn.microsoft.com/en-us/dotnet/core/porting/upgrade-assistant-overview)**




## C# 8.0 Features

| Feature                                                                                                        | Out of the Box | Require polyfills | Require Runtime |
|:---------------------------------------------------------------------------------------------------------------|:--------------:|:-----------------:|:---------------:|
| [Non-nullable references](./Polysharp.Playground.CSharp8.CompilerOnly/NullableExample.cs)                      |       ✔️       |         ❌         |        ❌        |
| [Switch Expressions](./Polysharp.Playground.CSharp8.CompilerOnly/SwitchExpressionsExample.cs)                  |       ✔️       |         ❌         |        ❌        |
| [Property pattern matching](./Polysharp.Playground.CSharp8.CompilerOnly/PropertyPatternMatchingExample.cs)     |       ✔️       |         ❌         |        ❌        |
| [Positional pattern matching](./Polysharp.Playground.CSharp8.CompilerOnly/PositionalPatternMatchingExample.cs) |       ✔️       |         ❌         |        ❌        |
| [Static local functions](./Polysharp.Playground.CSharp8.CompilerOnly/StaticLocalFunctionExample.cs)            |       ✔️       |         ❌         |        ❌        |
| [Using declarations](./Polysharp.Playground.CSharp8.CompilerOnly/UsingDeclarationExample.cs)                   |       ✔️       |         ❌         |        ❌        |
| [Null-coalescing assignment](./Polysharp.Playground.CSharp8.CompilerOnly/NullCoalescingAssignmentExample.cs)   |       ✔️       |         ❌         |        ❌        |
| [Read-only members](./Polysharp.Playground.CSharp8.CompilerOnly/ReadonlyMembersExample.cs)                     |       ✔️       |         ❌         |        ❌        |
| [Asynchronous streams](./Polysharp.Playground.CSharp8.CompilerOnly/AsyncStreamExample.cs)                    |       ✔️       |         ❌         |       ❌         |
| [Indices and Range](./Polysharp.Playground.CSharp8.RequirePolyfills/IndicesAndRangesExample.cs)                |       ❌        |        ✔️         |        ❌        |
| [Default interface methods](./Polysharp.Playground.CSharp8.RequireRuntime/DefaultInterfaceMethodsExample.cs)   |       ❌        |         ❌         |       ✔️        |

- - - 

## C# 9.0 Features

| Feature                                                                                                                                             | Out of the Box | Require polyfills | Require Runtime |
|:----------------------------------------------------------------------------------------------------------------------------------------------------|:--------------:|:-----------------:|:---------------:|
| [Records](./Polysharp.Playground.CSharp9.CompilerOnly/RecordsExample.cs)                                                                            |       ✔️       |         ❌         |        ❌        |
| [Target-typed new expressions](./Polysharp.Playground.CSharp9.CompilerOnly/TargetTypedNewExpressionExample.cs)                                      |       ✔️       |         ❌         |        ❌        |
| [Static Anonymous Functions](./Polysharp.Playground.CSharp9.CompilerOnly/StaticAnonymousFunctionsExample.cs)                                        |       ✔️       |         ❌         |        ❌        |
| [Pattern matching enhancements](./Polysharp.Playground.CSharp9.CompilerOnly/PatternMatchingEnhancements.cs)                                         |       ✔️       |         ❌         |        ❌        |
| [Lambda discard parameters](./Polysharp.Playground.CSharp9.CompilerOnly/LambdaDiscardParametersExample.cs)                                          |       ✔️       |         ❌         |        ❌        |
| [Target-typed conditional expressions](./Polysharp.Playground.CSharp9.CompilerOnly/TargetTypedConditionalExpressionsExample.cs)                     |       ✔️       |         ❌         |        ❌        |
| [Target-typed new](./Polysharp.Playground.CSharp9.CompilerOnly/TargetTypedNewExpressionExample.cs)                                                  |       ✔️       |         ❌         |        ❌        |
| [ExtensionGetEnumeratorSupportForeachLoops](./Polysharp.Playground.CSharp9.CompilerOnly/ExtensionGetEnumeratorSupportForeachLoopsExample.cs) |       ✔️       |         ❌         |        ❌        |
| [Native integers](./Polysharp.Playground.CSharp9.CompilerOnly/PointersFeatures/NativeIntegersExample.cs)                                            |       ✔️       |         ❌         |        ❌        |
| [Module initializers](./Polysharp.Playground.CSharp9.RequirePolyfills/ModuleInitializerExample.cs)                                                  |       ✔️       |         ❌         |        ❌        |
| [Attributes on local functions](./Polysharp.Playground.CSharp9.CompilerOnly/AttributeOnLocalFunctionsExample.cs)                                    |       ✔️       |         ❌         |        ❌        |
| [Function pointers](./Polysharp.Playground.CSharp9.CompilerOnly/PointersFeatures/FunctionPointerExample.cs)                                         |       ✔️       |         ❌         |        ❌        |
| [Attributes on parameters](./Polysharp.Playground.CSharp8.CompilerOnly/AttributesOnParametersExample.cs)                                            |       ✔️       |         ❌         |        ❌        |
| [Positional properties](./Polysharp.Playground.CSharp9.RequirePolyfills/PositionalPropertiesExample.cs)                                             |       ❌        |        ✔️         |        ❌        |
| [Init-only properties](./Polysharp.Playground.CSharp9.RequirePolyfills/InitOnlySettersExample.cs)                                                   |       ❌        |        ✔️         |        ❌        |
| [CallerArgumentExpression](./Polysharp.Playground.CSharp9.RequirePolyfills/CallerArgumentExpressionExample.cs)                                      |       ❌        |        ✔️         |        ❌        |
| [Suppress emitting locals init](./Polysharp.Playground.CSharp9.RequirePolyfills/SuppressEmittingLocalInitExample.cs)                                |       ❌        |        ✔️         |        ❌        |
| [Covariant return types](./Polysharp.Playground.CSharp9.RequireRuntime/CovariantReturnTypesExample.cs)                                              |       ❌        |         ❌         |       ✔️        |

- - - 

## C# 10.0 Features

| Feature                                                                                                                       | Out of the Box | Require polyfills | Require Runtime |
|:------------------------------------------------------------------------------------------------------------------------------|:--------------:|:-----------------:|:---------------:|
| [Implicit Usings](./Polysharp.Playground.CSharp10.CompilerOnly/ImplicitUsingExample.cs)                                       |       ✔️       |         ❌         |        ❌        |
| [Global using directives](./Polysharp.Playground.CSharp10.CompilerOnly/GlobalUsingsExample.cs)                                |       ✔️       |         ❌         |        ❌        |
| [File-scoped namespaces](./Polysharp.Playground.CSharp10.CompilerOnly/FileScopedNamespaceExample.cs)                          |       ✔️       |         ❌         |        ❌        |
| [Extended property patterns](./Polysharp.Playground.CSharp10.CompilerOnly/ExtendedPropertyPatternsExample.cs)                 |       ✔️       |         ❌         |        ❌        |
| [Record structs](./Polysharp.Playground.CSharp10.CompilerOnly/RecordStructExample.cs)                                         |       ✔️       |         ❌         |        ❌        |
| [Improved lambda support](./Polysharp.Playground.CSharp10.CompilerOnly/LambdaSupportExample.cs)                               |       ✔️       |         ❌         |        ❌        |
| [Interpolated strings improvements](./Polysharp.Playground.CSharp10.CompilerOnly/InterpolatedStringImprovements.cs)           |       ✔️       |         ❌         |        ❌        |
| [Constant interpolated strings](./Polysharp.Playground.CSharp10.CompilerOnly/ConstantInterpolatedStringExample.cs)            |       ✔️       |         ❌         |        ❌        |
| [Mixed interpolated verbatim strings](./Polysharp.Playground.CSharp10.CompilerOnly/MixedInterpolatedVerbatimStringExample.cs) |       ✔️       |         ❌         |        ❌        |
| [Async methods improvements]                                                                                                  |      ✔️?       |         ❌         |        ❌        |

- - - 

## C# 11.0 Features

| Feature                                                                                                   | Out of the Box | Require polyfills | Require Runtime |
|:----------------------------------------------------------------------------------------------------------|:--------------:|:-----------------:|:---------------:|
| [Raw string literals](./Polysharp.Playground.CSharp11.CompilerOnly/RawStringLiteralsExample.cs)           |       ✔️       |         ❌         |        ❌        |
| [Auto default struct](./Polysharp.Playground.CSharp11.CompilerOnly/AutoDefaultStructExample.cs)           |       ✔️       |         ❌         |        ❌        |
| [UTF 8 string literals](./Polysharp.Playground.CSharp11.CompilerOnly/Utf8StringLiteralExample.cs)         |       ✔️       |         ❌         |        ❌        |
| [File local types](./Polysharp.Playground.CSharp11.CompilerOnly/FileLocalTypesExample.cs)                 |       ✔️       |         ❌         |        ❌        |
| [Extended nameof scope](./Polysharp.Playground.CSharp11.CompilerOnly/ExtendedNameofScopeExample.cs)       |       ✔️       |         ❌         |        ❌        |
| [Generic attribute](./Polysharp.Playground.CSharp11.CompilerOnly/GenericAttributeExample.cs)              |       ✔️       |         ❌         |        ❌        |
| [Pattern matching span](./Polysharp.Playground.CSharp11.CompilerOnly/PatternMatchingSpanExample.cs)       |       ✔️       |         ❌         |        ❌        |
| [Required members](./Polysharp.Playground.CSharp11.RequirePolyfills/RequiredMembersExample.cs)            |       ❌        |        ✔️         |        ❌        |
| [List patterns](./Polysharp.Playground.CSharp11.RequirePolyfills/ListPatternsExample.cs)                  |       ❌        |        ✔️         |        ❌        |
| [Static abstract members](./Polysharp.Playground.CSharp11.RequireRuntime/StaticAbstractMembersExample.cs) |       ❌        |         ❌         |       ✔️        |

- - -

## C# 12.0 Features

| Feature                                                                                                                            | Out of the Box | Require polyfills | Require Runtime |
|:-----------------------------------------------------------------------------------------------------------------------------------|:--------------:|:-----------------:|:---------------:|
| [Collection Expression](./Polysharp.Playground.CSharp12.CompilerOnly/CollectionExpressionExample.cs)                               |       ✔️       |         ❌         |        ❌        |
| [Primary Constructors](./Polysharp.Playground.CSharp12.CompilerOnly/PrimaryConstructorsExample.cs)                                 |       ✔️       |         ❌         |        ❌        |
| [ref readonly parameters](./Polysharp.Playground.CSharp12.CompilerOnly/RefReadonlyParameterExample.cs)                             |       ✔️       |         ❌         |        ❌        |
| [Alias for any type](./Polysharp.Playground.CSharp12.CompilerOnly/AliasAnyTypeExample.cs)                                          |       ✔️       |         ❌         |        ❌        |
| [Optional Lambda expression parameters](./Polysharp.Playground.CSharp12.CompilerOnly/OptionalLambdaExpressionParametersExample.cs) |       ✔️       |         ❌         |        ❌        |
| [Inline array](./Polysharp.Playground.CSharp12.RequireRuntime/InlineArraysExample.cs)                                              |       ❌        |         ❌         |       ✔️        |


- - -

## C# 13.0 Features

| Feature                                                                                     | Out of the Box | Require polyfills | Require Runtime |
|:--------------------------------------------------------------------------------------------|:--------------:|:-----------------:|:---------------:|
| [ParamsCollection](./Polysharp.Playground.CSharp13.CompilerOnly/ParamsCollection)           |       ✔️       |         ❌         |        ❌        |
| [New escape sequence](./Polysharp.Playground.CSharp13.CompilerOnly/NewEscapeCharacter)      |       ✔️️       |         ❌        |        ❌        |
| [Partial members](./Polysharp.Playground.CSharp13.CompilerOnly/CompilerOnly)       |       ✔️️       |         ❌         |        ❌        |
| [New lock object](./Polysharp.Playground.CSharp13.RequireRuntime/NewLockObject)             |       ❌       |         ❌        |        ✔️        |
| [Implicit index access](./Polysharp.Playground.CSharp13.RequireRuntime/ImplicitIndexAccess) |       ❌     |         ❌         |        ✔️️          |
