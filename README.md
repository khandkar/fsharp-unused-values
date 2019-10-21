Why are only unused parameters reported?
========================================


Demo
----
```
 $ make                                                                                                                            [9:46:08]
rm -rf bin obj
make build
make[1]: Entering directory 'fsharp-unused-values'
dotnet build
Microsoft (R) Build Engine version 16.2.32702+c4012a063 for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  Restore completed in 144.31 ms for fsharp-unused-values/Foo.fsproj.
fsharp-unused-values/Program.fs(4,24): warning FS1182: The value 'unusedParameter' is unused [fsharp-unused-values/Foo.fsproj]
  Foo -> fsharp-unused-values/bin/Debug/netcoreapp2.1/Foo.dll

Build succeeded.

fsharp-unused-values/Program.fs(4,24): warning FS1182: The value 'unusedParameter' is unused [fsharp-unused-values/Foo.fsproj]
    1 Warning(s)
    0 Error(s)

```

Why weren't `unusedFunction` and `unusedNumber` reported?
