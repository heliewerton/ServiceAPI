# ServiceAPI
Basic .NET API usage.

# How to run? 
## Download C# 
Download Visual Studio 2017(https://www.visualstudio.com/pt-br/downloads/), which has the latest features built-in. 

To install the latest release without Visual Studio, run one of the following nuget command lines:

nuget install Microsoft.Net.Compilers   # Install C# and VB compilers
nuget install Microsoft.CodeAnalysis    # Install Language APIs and Services

## Debug/run the API adn then using Postman or any similar client send the follow json request:
{
 "Language":"ENG",
 "Currency":"USD",
 "destination":"MCO",
 "DateFrom":"10/12/2018",
 "DateTO":"10/14/2018",
 "Occupancy": {"AdultCount":"1","ChildCount":"1", "ChildAges":["10"] }   
}
