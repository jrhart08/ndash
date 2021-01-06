param(
  [Parameter(Mandatory=$True)]
  [System.String]
  $apiKey,

  [Parameter(Mandatory=$True)]
  [System.String]
  $version
)

dotnet clean -c Release

dotnet build -c Release

if ($LastExitCode -ne 0) {
	throw "Build failed!"
}

dotnet test

if ($LastExitCode -ne 0) {
	throw "Unit tests failed!"
}

dotnet pack -c Release --no-build --include-symbols /p:Version=$version

dotnet nuget push .\src\NDash\bin\Release\*.$version.nupkg -s C:\nuget-repo # https://api.nuget.org/v3/index.json -k $apiKey
