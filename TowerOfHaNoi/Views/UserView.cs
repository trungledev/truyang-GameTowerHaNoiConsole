namespace TowerOfHaNoi.Views;

public static class UserView
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
    public static string? ActionUserFirst(string message)
    {
        Console.WriteLine(message);
        var input = Console.ReadLine();
        return input;
    }
    public static string? SelectSecondTower(string message)
    {
        Console.WriteLine(message);
        var input = Console.ReadLine();
        return input;
    }
}