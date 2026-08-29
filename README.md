[![](https://img.shields.io/nuget/v/soenneker.tests.attributes.local.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.tests.attributes.local/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.tests.attributes.local/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.tests.attributes.local/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.tests.attributes.local.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.tests.attributes.local/)

# Soenneker.Tests.Attributes.Local

Run locally, skip in pipelines.

## Install

```bash
dotnet add package Soenneker.Tests.Attributes.Local
```

## Quick start

```csharp
using Soenneker.Tests.Attributes.Local;

public sealed class Request
{
    [LocalOnly]
    public string? Value { get; init; }
}
```

Run locally, skip in pipelines.

## What you get

- `LocalOnlyAttribute` — Run locally, skip in pipelines.
