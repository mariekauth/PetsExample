# PetsExample
Unit Tests

dotnet new console -n "Pets" -o ./Pets -lang "C#" -f "net6.0"
dotnet new xunit -n "PetsTest" -o ./PetsTest -lang "C#"

dotnet test --collect:"XPlat Code Coverage"

reportgenerator
-reports:"Path\To\TestProject\TestResults\{guid}\coverage.cobertura.xml"
-targetdir:"coveragereport"
-reporttypes:Html

reportgenerator
-reports:"Path\To\TestProject\TestResults\{guid}\coverage.cobertura.xml"
-targetdir:"coveragereport"
-reporttypes:Html

794eef10-cb5d-420c-887c-98d7266020f8
reportgenerator -reports:".\TestResults\794eef10-cb5d-420c-887c-98d7266020f8\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html

reportgenerator -reports:".\TestResults\0000aaaa-1234-abcd-abcd-134567890ab\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
reportgenerator -reports:".\TestResults\d1727395-b6ee-4d54-bda6-95a27859cc44\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
reportgenerator -reports:".\TestResults\1a433232-0c3d-4d63-b768-0707f34b9468\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
reportgenerator -reports:".\TestResults\47bde08c-01fb-4baf-bc76-1340c655105a\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
reportgenerator -reports:".\TestResults\82c046a4-e44c-4070-87ce-75850bf6c7fb\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
reportgenerator -reports:".\TestResults\{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html

$TestOutput = dotnet test --collect "XPlat Code Coverage"
$TestReports = $TestOutput | Select-String coverage.cobertura.xml | ForEach-Object { $_.Line.Trim() } | Join-String -Separator ';'
dotnet reportgenerator "-reports:$TestReports" "-targetdir:./CoverageReport" "-reporttype:Html"

# Run
dotnet run --project ".\Pets\Pets.csproj"

# Run Tests
cd .\PetsTest
dotnet test --collect:"XPlat Code Coverage"
reportgenerator -reports:".\TestResults\{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
cd ..

# View Coverage
Open .\PetsTest\coveragereport\index.html in your browser
Open .\PetsTest\coveragereport\index.htm in your browser


# TODO
- Cleanup Readme
- Implement Dependency Injection
- Improve Test Coverage
- Add additional examples

# TODO Much Later (Possible Changes)
- Build in Pipeline
- Deploy
- Convert to Library
- Convert to WebAPI
- Add a UI
- Update to manage lists, instead of the Pet Example
- LOTS TO DO

# NOTES
7/6/2023 - Test Driven Development (TDD)
