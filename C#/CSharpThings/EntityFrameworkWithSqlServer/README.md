`dotnet  add  package  Microsoft.EntityFrameworkCore.SqlServer`

# Entity Framework tools

> Podemos instalar herramientas para llevar a acabo tareas relacionadas a EF Core en nuestro proyecto, como crear y crear migraciones de bases de datos, o crear un modelo EF Core basandose en una base de datos ya existente

### Get .NET Core CLI tools (requiere de .NET Core SDK)

```console
dotnet  add  package  Microsoft.EntityFrameworkCore.Design 
```

### Get the Package Manager Console tools

```
dotnet add package   Microsoft.EntityFrameworkCore.Tools
```

### Install the database provider(s) you want target [Providers](https://docs.microsoft.com/en-us/ef/core/providers/)

```console
dotnet  add  package  Microsoft.EntityFrameworkCore.Sqlite
```