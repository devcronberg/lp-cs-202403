using CSLegeplads.ConsoleInputHelper;
using System.Reflection.Metadata;

try
{
    int a = ConsoleInputHelper.GetInt("Input number", 0);
    Console.WriteLine($"User input: {a}");

    double b = ConsoleInputHelper.GetDouble("Input double", 0.0);
    Console.WriteLine($"User input: {b}");

    bool c = ConsoleInputHelper.GetBool("Input bool", false);
    Console.WriteLine($"User input: {c}");

    DateTime d = ConsoleInputHelper.GetDateTime("Input datetime", DateTime.Now);
    Console.WriteLine($"User input: {d}");
}
catch (ConsoleInputException ex)
{
    Console.WriteLine(ex.ToString());
}