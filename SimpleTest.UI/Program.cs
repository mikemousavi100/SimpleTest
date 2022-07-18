// See https://aka.ms/new-console-template for more information
using SimpleTest;

Console.WriteLine("Main program starter!");

// Example of a client code calling the SimpleTextParser
// Note: If more time was available,
//       We would use the .Net core depency inject for resolving logger

ILogger logger = new ConsoleLogger();
var parser = new SimpleTest.SimpleTextParser(logger);

string input = "Zebra Abba cat zebra Dog Cat dog abba";
string output = parser.SortStringParagraph(input);

Console.WriteLine($"Input = {input}");
Console.WriteLine($"Output = {output}");


Console.WriteLine("Main program completed, hit a key to finish!");
Console.ReadKey();