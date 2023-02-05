namespace TowerOfHaNoi.Views;

public class UserView
{
    public static string? GetNumberConsole(string message)
    {
        Console.WriteLine(message);
        var input = Console.ReadLine();
        return input;
    }
    public static void ResultAction(string message)
    {
        string result = "Result: " + message;
        Console.WriteLine(result);
    }
}