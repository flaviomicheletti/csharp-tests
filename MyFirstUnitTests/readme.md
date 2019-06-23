# Getting Started with xUnit.net


https://xunit.net/docs/getting-started/netcore/cmdline


Create the unit test project

    # gitbash
    mkdir MyFirstUnitTests && cd $_

    # powershell
    mkdir MyFirstUnitTests
    cd MyFirstUnitTests

    # create
    dotnet new classlib


Edit file `.csproj`.

    <Project Sdk="Microsoft.NET.Sdk">

      <PropertyGroup>
        <TargetFramework>netcoreapp2.1</TargetFramework>
      </PropertyGroup>

      <ItemGroup>
        <PackageReference Include="Microsoft.NET.Test.Sdk" Version="15.9.0" />
        <PackageReference Include="xunit" Version="2.4.1" />
        <PackageReference Include="xunit.runner.visualstudio" Version="2.4.1" />
      </ItemGroup>

    </Project>


Now let's verify that everything is working.

    dotnet test



