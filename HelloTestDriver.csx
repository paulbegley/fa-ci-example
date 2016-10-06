#load ".\NunitTests\HelloWorldTest.csx"

using NUnit.Core;

var nunit = Require<NUnitRunner>();
TestResult functionResults = nunit.RunAllUnitTests();
Console.WriteLine("---------------------------------------------");
Console.WriteLine("\tSuccess\tFailure\tError\tTime\tMessage");
foreach (TestResult functionResult in functionResults.Results)
{
    foreach (TestResult result in functionResult.Results)
    {
        Console.WriteLine(
            "{0}\r\n\t{1}\t{2}\t{3}\t{4}s\t{5}",
            result.Name,
            result.IsSuccess,
            result.IsFailure,
            result.IsError,
            string.Format("{0:0.00}", result.Time),
            result.Message);
    }
}
Console.WriteLine("---------------------------------------------");
if (functionResults.IsFailure)
    throw new Exception("Test Failures");
