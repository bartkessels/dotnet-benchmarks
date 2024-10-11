## DotNet Benchmarks

This project is a tryout for the [BenchmarkDotNet](https://www.nuget.org/packages/BenchmarkDotNet/) package.

### Try it yourself

```shell
$ dotnet restore
$ dotnet run -c Release
```

This will run the benchmarks for a small calculator tool that adds numbers using LINQ and a for loop. The benchmarks
will show up in your console.