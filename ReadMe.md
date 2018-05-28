# Stop Finder Automation Test 1

Automation Exercise (notes from Exercise)

Create an automated test for the scenario below in the language (C#, Java etc) and framework (xUnit, BDD etc) of your choice. Note that although the scenario is defined in Gherkin, a BDD implementation is not mandatory. 
 
Scenario: 
- A stop providing multiple transport options can be located
- Given Phileas is looking for a stop
- When he searches for "Wynyard Station"
- Then a stop named "Wynyard Station, Sydney" is found
- And the stop provides more than one mode of transport
 
Use the exercise to showcase best-practice software development and test automation techniques.  
 
The URL for Stop Finder is www.transportnsw.info/web/XML_STOPFINDER_REQUEST?TfNSWSF=true&language=en &name_sf=​stopname​&outputFormat=rapidJSON&type_sf=any&version=10.2.2.48  
 For further reference the web page that consumes the api is transportnsw.info/stops#/

## Getting Started

Download the whole solution to your PC.

### Prerequisites

This C# solution requires:
- Visual Studio 2017 - Community edition should suffice.

In addition the following NuGet packages are required:
- Newtonsoft.Json - v11.0.2

For the application to run:
- Google Chrome - v66.0.3359.181 (64-bit)
- Microsoft .NET Framework 4.6.1: https://www.microsoft.com/en-au/download/details.aspx?id=49981

### Installing

- Install the prerequisites.
- Copy the contents of the .\StopFinderTest1\bin\Release directory into your working directory or new folder on your PC. 
- Double-click on the StopFinderTest1.exe (application).  The test will execute - This will produce Console Messages on success or fail.
- Allow the test to complete.

## Authors

* **Nicole Baker** - *Initial work* - [nbaker74](https://github.com/nbaker74)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

