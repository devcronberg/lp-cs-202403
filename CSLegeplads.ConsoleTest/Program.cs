using CSLegeplads.ConsoleHelper;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            RunProgram();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    
    private static void RunProgram()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("da-DK");
        try
        {
            ConsoleHelper_Input_Test.RunTest();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }      

        Console.ReadLine();
    }
}