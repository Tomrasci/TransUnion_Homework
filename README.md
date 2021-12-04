# TransUnion Homework
Homework application for TransUnion. Implemented CaesarCipher algorithm, where the user can put a string of his choice and the shift number according to which the algorithm shifts the inserted input.

## Technologies used
* C#
* Visual Studio Code
* MSTest for unit testing
* Coverlet MSBuild integration for coverage reports
* .NET Core Test Explorer extension for running selected number of tests and debugging

## How to run the system
In order to run the application, simply press (start debugging/run without debugging) or   
type the command ```dotnet run Program.cs``` in the terminal, while being in the CaesarCipher/CaesarCipher directory

In order to run the tests, type the command ``` dotnet test CaesarCipherTest/CaesarCipherTest.csproj -r CaesarCipherTest /p:CollectCoverage=true  /p:ExcludeByFile=\"**/CaesarCipher/Program.cs"``` in the terminal.  
The test coverage appears in the terminal output and in the created file coverage.json.  
You can also run the tests by selecting the Testing option under Extensions and pressing run if .NET Core Test Explorer is installed.
