# Reproduction of regression compilation error FS3045 in SDK 5.0.300

## Prerequisites

Install both dotnet SDK 5.0.203 and 5.0.300

```powershell
choco install dotnet-sdk --version 5.0.203 -m
choco install dotnet-sdk --version 5.0.300 -m
```

## To reproduce

```powershell
dotnet tool restore
dotnet paket restore
dotnet build


...error FS3045: Invalid static argument to provided type. Expected an argument of kind 'string'.
```

## Expected behaviour

It should compile

## Workaround

Downgrade to SDK 5.0.203 by editing `global.json`
